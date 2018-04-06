using System.Collections.Generic;
using System.Windows;
using DietHolder2ClientWPF.Models.MediatorPattern;
using DietHolder2ClientWPF.ViewModels;
using DietHolder2ClientWPF.ViewModels.Base;
using Microsoft.VisualBasic.ApplicationServices;

namespace DietHolder2ClientWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MediatorSingleton.Instance.Register(new KeyValuePair<string, object>("TdeeValue", 0));
        }


        private void ShowMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMenuButton.Visibility = Visibility.Collapsed;
            HideMenuButton.Visibility = Visibility.Visible;
        }

        private void HideMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMenuButton.Visibility = Visibility.Visible;
            HideMenuButton.Visibility = Visibility.Collapsed;
        }

        private void CloseApplicationButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TdeeOptionListView_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new TdeeCalculatorViewModel();
        }

        private void EatenFoodOptionListView_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new EatenFoodCalculatorViewModel();
        }

        protected void StatisticsCornerListView_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new StatisticsCornerViewModel();
        }
    }
}
