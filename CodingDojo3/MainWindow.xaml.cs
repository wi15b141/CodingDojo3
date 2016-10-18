using CodingDojo3.Converters;
using CodingDojo3.Dataoperations;
using CodingDojo3.ViewModel;
using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodingDojo3
{
    /// <summary>
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();
        PriceConverter pc = new PriceConverter();

        public MainWindow()
        {
            InitializeComponent();


        }



        private void Window_Initialized(object sender, RoutedEventArgs e)
        {


        }


        public void add_item(object sender, RoutedEventArgs e)
        {
         

            if (System.Windows.MessageBox.Show("Do you want to add new Software?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {

                MainViewModel mvm1 = (MainViewModel)this.DataContext;
                
                Dataoperations.Dataoperation dop = new Dataoperation();
               
                mvm1.Items1.Add(new StockEntryViewModel(dop.add_new_item()));
                dataGrid.Items.Refresh();
                dataGrid.ItemsSource = mvm1.Items1;
                System.Windows.MessageBox.Show("You added new row. Please edit data with using the Edit button.");

            }
        }

        private void OnRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
           
            if (e.EditAction == DataGridEditAction.Commit)
            {
                
                 ListCollectionView view = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource) as ListCollectionView;
                 if (view.IsAddingNew || view.IsEditingItem)
                 {

                    System.Windows.MessageBox.Show("You finished the editing of row. The changes are recorded.");
                    dataGrid.IsReadOnly = true;

                }
            }
        }

        private void combobox_selchange(object sender, RoutedEventArgs e)
        {
            MainViewModel mvm1 = (MainViewModel)this.DataContext;
           
            foreach (var item in mvm1.Items1)
            {
                
                item.PurchasePrice = pc.CalculateSalesPriceFromEuro(mvm1.SelectedCurrency, item.PurchasePrice1);
                item.SalesPrice = pc.CalculateSalesPriceFromEuro(mvm1.SelectedCurrency, item.SalesPrice1);

            }
            
            dataGrid.Items.Refresh();
            dataGrid.ItemsSource = mvm1.Items1;

        }


        private void edit_button (object sender, RoutedEventArgs e)
        {
            try
            {
                dataGrid.IsReadOnly = false;
              
                dataGrid.Items.Refresh();
                


            }

            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }


        }




        private void delete_button(object sender, RoutedEventArgs e)
        {
            try
            {
                MainViewModel mvm1 = (MainViewModel)this.DataContext;
                StockEntryViewModel sev = null;


                sev = ((StockEntryViewModel)dataGrid.SelectedItem);

                mvm1.Items1.Remove(mvm1.Items1.Where(i => i.Name == sev.Name).First());
                
                
                dataGrid.Items.Refresh();
                dataGrid.ItemsSource = mvm1.Items1;

            }

            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }
    }

  
}
