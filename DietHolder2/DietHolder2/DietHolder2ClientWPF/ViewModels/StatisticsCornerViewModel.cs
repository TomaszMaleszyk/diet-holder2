using System.Windows;
using System.Windows.Input;
using DietHolder2ClientWPF.Commands;
using DietHolder2ClientWPF.Models.MediatorPattern;
using DietHolder2ClientWPF.ViewModels.Base;

namespace DietHolder2ClientWPF.ViewModels
{
    public class StatisticsCornerViewModel : ViewModelBase
    {
  
        public ICommand ShowProductsCompariserCommand => new RelayCommand(ShowProductsCompariserViewModel, CanSayHiExcute);
        public ICommand ShowProductsStatisticsCommand => new RelayCommand(ShowProductsStatisticsViewModel, CanSayHiExcute);
        public StatisticsCornerViewModel()
        {
          
        }
        public void ShowProductsCompariserViewModel()
        {
            if(Application.Current.MainWindow != null)
                ((MainWindow)Application.Current.MainWindow).DataContext = new ProductsCompariserViewModel();
        }
        public void ShowProductsStatisticsViewModel()
        {
            if(Application.Current.MainWindow != null)
                ((MainWindow)Application.Current.MainWindow).DataContext = new ProductsStatisticsViewModel();
        }


        private bool CanSayHiExcute()
        {
            return true; //tutaj coś podziergać jeszcze
        }
    }
}
