using System;
using System.Collections.Generic;
using System.Linq;
using DietHolder2ClientWPF.Interfaces;
using DietHolder2ClientWPF.Models;
using DietHolder2ClientWPF.Models.MediatorPattern;
using DietHolder2ClientWPF.ViewModels.Base;

namespace DietHolder2ClientWPF.ViewModels
{
    public class ProductsCompariserViewModel :ViewModelBase
    {
        private readonly List<IProduct> allProductsList;
        private Product selectedFirstProduct;
        private Product selectedSecondProduct;
        private string firstUserInputProductName;
        private string secondUserInputProductName;
        private string firstProductImageSourcePath;
        private string secondProductImageSourcePath;

        public List<string> ProductsNames { get; }
        public Product SelectedFirstProduct
        {
            get { return selectedFirstProduct; }
            set
            {
                selectedFirstProduct = value;
                OnPropertyChanged("SelectedFirstProduct");
                UpdateFirstProduct(SelectedFirstProduct.ProductName);
            }
        }
        public Product SelectedSecondProduct
        {
            get { return selectedSecondProduct; }
            set
            {
                selectedSecondProduct = value;
                OnPropertyChanged("SelectedSecondProduct");
                UpdateSecondProduct(SelectedSecondProduct.ProductName);
            }
        }
        public string FirstUserInputProductName
        {
            get { return firstUserInputProductName; }
            set
            {
                firstUserInputProductName = value;
                OnPropertyChanged("FirstUserInputProductName");
                SelectedFirstProduct = CreateProduct(firstUserInputProductName);
            }
        }
        public string SecondUserInputProductName
        {
            get { return secondUserInputProductName; }
            set
            {
                secondUserInputProductName = value;
                OnPropertyChanged("SecondUserInputProductName");
                SelectedSecondProduct = CreateProduct(secondUserInputProductName);
            }
        }
        public string FirstProductImageSourcePath
        {
            get { return firstProductImageSourcePath; }
            set
            {
                firstProductImageSourcePath = value;
                OnPropertyChanged("FirstProductImageSourcePath");
            }
        }
        public string SecondProductImageSourcePath
        {
            get { return secondProductImageSourcePath; }
            set
            {
                secondProductImageSourcePath = value;
                OnPropertyChanged("SecondProductImageSourcePath");
            }
        }

        public ProductsCompariserViewModel()
        { 
            SelectedFirstProduct = new Product
            {
                ProductName = "Unknown",
                ProductCarboValue = 0,
                ProductProteinValue = 0,
                ProductFatValue = 0,
                ProductPrice = 0
            };

            SelectedSecondProduct = new Product
            {
                ProductName = "Unknown",
                ProductCarboValue = 0,
                ProductProteinValue = 0,
                ProductFatValue = 0,
                ProductPrice = 0
            };

            var databaseManager = new ProductDatabaseManager();
            allProductsList = databaseManager.GetAll().ToList();

            ProductsNames = allProductsList.Select(x => x.ProductName).ToList();
        }

        public void UpdateFirstProduct(string productName)
        {
            if(productName == "Unknown" || productName == null)
            {
                FirstProductImageSourcePath = "../Assets/Products/None.png";
            }
            else
            {
                FirstProductImageSourcePath = $"../Assets/Products/{productName}.png";
            }
        }

        public void UpdateSecondProduct(string productName)
        {
            if(productName == "Unknown" || productName == null)
            {
                SecondProductImageSourcePath = "../Assets/Products/None.png";
            }
            else
            {
                SecondProductImageSourcePath = $"../Assets/Products/{productName}.png";
            }
        }

        private Product CreateProduct(string userInputProductName)
        {
            var product = (Product)allProductsList.FirstOrDefault
                              (x => string.Equals(x.ProductName, userInputProductName, StringComparison.CurrentCultureIgnoreCase)) ??
                          new Product
                          {
                              ProductName = "Unknown",
                              ProductCarboValue = 0,
                              ProductProteinValue = 0,
                              ProductFatValue = 0,
                              ProductPrice = 0
                          };

            return product;
        }
    }
}
