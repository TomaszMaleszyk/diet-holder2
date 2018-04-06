using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using DietHolder2ClientWPF.Commands;
using DietHolder2ClientWPF.Interfaces;
using DietHolder2ClientWPF.Models;
using DietHolder2ClientWPF.Models.MediatorPattern;
using DietHolder2ClientWPF.ViewModels.Base;

namespace DietHolder2ClientWPF.ViewModels
{
    public class EatenFoodCalculatorViewModel : ViewModelBase
    {
        private ObservableCollection<IProduct> eatenProductCollection;
        private List<KeyValuePair<Macronutrients, double>> eatenFoodSummaryDetails;
        private Collection<KeyValuePair<Macronutrients, double>> leftToEatFoodSummaryDetails;
        private readonly List<IProduct> allProducts;
        private Product selectedProduct;
        private Product eatenProduct;
        private string userInputProductName;
        private string imageSourcePath;
        private double foodWeight;
        private double eatenCarbo;
        private double eatenProtein;
        private double eatenFat;

        public ICommand AddProduct => new RelayCommand(AddAndUpdateEatenProduct, CanSayHiExcute);

        public ObservableCollection<IProduct> EatenProductCollection
        {
            get { return eatenProductCollection; }
            set
            {
                eatenProductCollection = value;
                OnPropertyChanged("EatenProductCollection");
            }
        }
     

        public List<KeyValuePair<Macronutrients, double>> EatenFoodSummaryDetails
        {
            get { return eatenFoodSummaryDetails; }
            set
            {
                eatenFoodSummaryDetails = value;
                OnPropertyChanged("EatenFoodSummaryDetails");
            }
        }
        public Collection<KeyValuePair<Macronutrients, double>> LeftToEatFoodSummaryDetails
        {
            get { return leftToEatFoodSummaryDetails; }
            set
            {
                leftToEatFoodSummaryDetails = value;
                OnPropertyChanged("LeftToEatFoodSummaryDetails");
            }
        }
        public List<string> ProductNamesList { get; }
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        public Product EatenProduct
        {
            get { return eatenProduct; }
            set
            {
                eatenProduct = value;
                OnPropertyChanged("EatenProduct");
            }
        }
        public string UserInputProductName
        {
            get { return userInputProductName; }
            set
            {
                userInputProductName = value;
                OnPropertyChanged("UserInputProductName");
                SelectedProduct = GetSelectedProduct(userInputProductName);
                UpdateProductImage(SelectedProduct.ProductName);
            }
        }
        public double FoodWeight
        {
            get { return foodWeight; }
            set
            {
                foodWeight = value;
                OnPropertyChanged("FoodWeight");
            }
        }

        public string ImageSourcePath
        {
            get { return imageSourcePath; }
            set
            {
                imageSourcePath = value;
                OnPropertyChanged("ImageSourcePath");
            }
        }

        public EatenFoodCalculatorViewModel()
        {
            eatenProductCollection = new ObservableCollection<IProduct>();
            SelectedProduct = new Product
            {
                ProductName = "Product name",
                ProductCarboValue = 0,
                ProductProteinValue = 0,
                ProductFatValue = 0,
                ProductPrice = 0
            };

            EatenProduct = new Product
            {
                ProductName = "Product name",
                ProductCarboValue = 0,
                ProductProteinValue = 0,
                ProductFatValue = 0,
                ProductPrice = 0
            };

            eatenFoodSummaryDetails = new List<KeyValuePair<Macronutrients, double>>
            {
               new KeyValuePair<Macronutrients, double>(Macronutrients.Carbo,0),
               new KeyValuePair<Macronutrients, double>(Macronutrients.Protein,0),
               new KeyValuePair<Macronutrients, double>(Macronutrients.Fat,0)
            };

            LeftToEatFoodSummaryDetails = new Collection<KeyValuePair<Macronutrients, double>>
            {
               new KeyValuePair<Macronutrients, double>(Macronutrients.Carbo,0),
               new KeyValuePair<Macronutrients, double>(Macronutrients.Protein,0),
               new KeyValuePair<Macronutrients, double>(Macronutrients.Fat,0)
            };



            foodWeight = 0;
            eatenCarbo = 0;
            eatenProtein = 0;
            eatenFat = 0;


            var databaseManager = new ProductDatabaseManager();
            allProducts = databaseManager.GetAll().ToList();

            ProductNamesList = allProducts.Select(a => a.ProductName).ToList();

        }

        private Product GetSelectedProduct(string choosenProductName)
        {
            if(choosenProductName == string.Empty)
            {
                return new Product
                {
                    ProductName = "Unknown"
                };
            }

            var temporarySelectedProduct =
                (Product)allProducts.FirstOrDefault(x =>
                   x.ProductName.ToLower().StartsWith(choosenProductName.ToLower())); //get Single

            if(temporarySelectedProduct == null)
            {
                return new Product
                {
                    ProductName = "Unknown"
                };
            }

            return temporarySelectedProduct;
        }

        public void UpdateProductImage(string choosenProductName)
        {
            if(choosenProductName == "Unknown" || choosenProductName == null)
            {
                ImageSourcePath = "../Assets/Products/None.png";
            }
            else
            {
                ImageSourcePath = $"../Assets/Products/{choosenProductName}.png";
            }
        }

        private void AddAndUpdateEatenProduct()
        {
            AddEatenProduct();
            SetChart();
        }

        private void AddEatenProduct()
        {
            if(SelectedProduct == null)
            {
                throw new ArgumentNullException();
            }

            EatenProduct = GetEatenProduct(SelectedProduct, foodWeight);
            eatenProductCollection.Add(EatenProduct);
        }

        private static Product GetEatenProduct(IProduct temporarySelectedProduct, double foodWeight)
        {
            var temporaryEatenProduct = new Product
            {
                ProductName = temporarySelectedProduct.ProductName,
                ProductPrice = temporarySelectedProduct.ProductPrice * (decimal)foodWeight,
                ProductCarboValue = temporarySelectedProduct.ProductCarboValue * foodWeight,
                ProductProteinValue = temporarySelectedProduct.ProductProteinValue * foodWeight,
                ProductFatValue = temporarySelectedProduct.ProductFatValue * foodWeight
            };

            return temporaryEatenProduct;
        }

        private void SetChart()
        {
            UpdateEatenMacros(EatenProduct);
            ComputeMacrosToEat();
        }

        private void UpdateEatenMacros(IProduct temporaryEatenProduct)
        {
            eatenCarbo += temporaryEatenProduct.ProductCarboValue;
            eatenProtein += temporaryEatenProduct.ProductProteinValue;
            eatenFat += temporaryEatenProduct.ProductFatValue;

            EatenFoodSummaryDetails = new List<KeyValuePair<Macronutrients, double>>
            {
               new KeyValuePair<Macronutrients, double>(Macronutrients.Carbo,eatenCarbo),
               new KeyValuePair<Macronutrients, double>(Macronutrients.Protein,eatenProtein),
               new KeyValuePair<Macronutrients, double>(Macronutrients.Fat,eatenFat)
            };
        }
        private void ComputeMacrosToEat()
        {
            var tdeeValue = Convert.ToDouble(MediatorSingleton.Instance.GetPropertyValue("TdeeValue"));
            var macrosToEat = MacronutrientsDistibutionCalculator.GetMacrosDistribution(tdeeValue);

            LeftToEatFoodSummaryDetails = new Collection<KeyValuePair<Macronutrients, double>>
            {
                new KeyValuePair<Macronutrients, double>(Macronutrients.Carbo, macrosToEat[Macronutrients.Carbo] - eatenCarbo),
                new KeyValuePair<Macronutrients, double>(Macronutrients.Protein, macrosToEat[Macronutrients.Protein] - eatenProtein),
                new KeyValuePair<Macronutrients, double>(Macronutrients.Fat, macrosToEat[Macronutrients.Fat] - eatenFat)
            };

        }
        private bool CanSayHiExcute()
        {
            return true; //tutaj coś podziergać jeszcze
        }
    }
}