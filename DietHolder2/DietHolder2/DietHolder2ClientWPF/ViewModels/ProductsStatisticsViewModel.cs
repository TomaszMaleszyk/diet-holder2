using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;
using DietHolder2ClientWPF.Commands;
using DietHolder2ClientWPF.Interfaces;
using DietHolder2ClientWPF.Models;
using DietHolder2ClientWPF.Models.Filter;
using DietHolder2ClientWPF.Models.MediatorPattern;
using DietHolder2ClientWPF.ViewModels.Base;

namespace DietHolder2ClientWPF.ViewModels
{
    public class ProductsStatisticsViewModel : ViewModelBase
    {
        private readonly FilterModeInfoCreator summaryCreator;
        private string filterSummary;
        private int rowsNumber;
        private FilterOperationValue selectedCarboFilter;
        private FilterOperationValue selectedProteinFilter;
        private FilterOperationValue selectedFatFilter;
        private FilterOperationValue selectedCaloriesFilter;
        private FilterOperationValue selectedPriceFilter;
        private ObservableCollection<IProduct> productCollection;
        private List<KeyValuePair<FilterOperationKind, FilterOperationValue>> operationList;
        public ICommand ShowResultsCommand => new RelayCommand(ShowResults, CanSayHiExcute);

        public CollectionView Options { get; }
        public ObservableCollection<IProduct> ProductCollection
        {
            get { return productCollection; }
            set
            {
                productCollection = value;
                OnPropertyChanged("ProductCollection");
            }
        }
        public FilterOperationValue SelectedCarboFilter
        {
            get { return selectedCarboFilter; }
            set
            {
                selectedCarboFilter = value;
                OnPropertyChanged("SelectedCarboFilter");
                UpdateFilterSummary(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Carbo, selectedCarboFilter));
                UpdateOperationsList(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Carbo, selectedCarboFilter));
            }
        }
        public FilterOperationValue SelectedProteinFilter
        {
            get
            {
                return selectedProteinFilter;
            }
            set
            {
                selectedProteinFilter = value;
                OnPropertyChanged("SelectedProteinFilter");
                UpdateFilterSummary(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Protein, selectedProteinFilter));
                UpdateOperationsList(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Protein, selectedProteinFilter));
            }
        }
        public FilterOperationValue SelectedFatFilter
        {
            get
            {
                return selectedFatFilter;
            }
            set
            {
                selectedFatFilter = value;
                OnPropertyChanged("SelectedFatFilter");
                UpdateFilterSummary(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Fat, selectedFatFilter));
                UpdateOperationsList(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Fat, selectedFatFilter));
            }
        }
        public FilterOperationValue SelectedCaloriesFilter
        {
            get
            {
                return selectedCaloriesFilter;
            }
            set
            {
                selectedCaloriesFilter = value;
                OnPropertyChanged("SelectedCaloriesFilter");
                UpdateFilterSummary(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Calories, selectedCaloriesFilter));
                UpdateOperationsList(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Calories, selectedCaloriesFilter));

            }
        }
        public FilterOperationValue SelectedPriceFilter
        {
            get
            {
                return selectedPriceFilter;
            }
            set
            {
                selectedPriceFilter = value;
                OnPropertyChanged("SelectedPriceFilter");
                UpdateFilterSummary(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Price, selectedPriceFilter));
                UpdateOperationsList(new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Price, selectedPriceFilter));
            }
        }
        public string FilterSummary
        {
            get { return filterSummary; }
            set
            {
                filterSummary = value;
                OnPropertyChanged("FilterSummary");
            }
        }
        public int RowsNumber
        {
            get { return rowsNumber; }
            set
            {
                rowsNumber = value;
                OnPropertyChanged("RowsNumber");
            }
        }
 
        public ProductsStatisticsViewModel()
        {
            var filterOptions = new List<FilterOperationValue>
            {
                FilterOperationValue.Off,
                FilterOperationValue.Min,
                FilterOperationValue.Average,
                FilterOperationValue.Max
            };

            Options = new CollectionView(filterOptions);
            summaryCreator = new FilterModeInfoCreator();
            operationList =
                new List<KeyValuePair<FilterOperationKind, FilterOperationValue>>();
            //                {
            //                    new KeyValuePair<FilterOperationKind, FilterOperationValue>(FilterOperationKind.Fat,
            //                        FilterOperationValue.Off)
            //                };
        }

        private void UpdateFilterSummary(KeyValuePair<FilterOperationKind, FilterOperationValue> filter)
        {
            //            if(filter.Value.ToString() == null)
            //            {
            //                return;
            //            }
            //            FilterSummary = summaryCreator.UpdateSummary(filter);
        }

        private void ShowResults()
        {
            var databaseConnetor = new ProductDatabaseManager();
            var allProducts = databaseConnetor.GetAll().ToList();

            ProductCollection = new ObservableCollection<IProduct>(FilterTableProducts.StartFiltration(allProducts, operationList, RowsNumber));
        }

        private void UpdateOperationsList(KeyValuePair<FilterOperationKind, FilterOperationValue> operation)
        {
            if(operationList.Exists(x => x.Key == operation.Key) && operationList.Exists(x => x.Value != operation.Value))
            {
                var a = operationList.FindIndex(x => x.Key == operation.Key);
                operationList.RemoveAt(a);
                var b = operation.Key;
                var c = operation.Value;
                operationList.Insert(a, new KeyValuePair<FilterOperationKind, FilterOperationValue>(b, c));
                return;
            }

            operationList.Add(operation);
        }

        private bool CanSayHiExcute()
        {
            return true; //validate data
        }
    }
}
