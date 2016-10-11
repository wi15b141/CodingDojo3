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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void add_item(object sender, RoutedEventArgs e)
        {
           

            if (System.Windows.MessageBox.Show("Are you want to add new Software?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MainViewModel mvm = new MainViewModel();
                mvm.add_item();
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = mvm.Items1;
               
            }
        }

        
        private void button1_Click()
        {
            System.Windows.MessageBox.Show(dataGrid.SelectedIndex.ToString());
           // dataGrid.Items.RemoveAt(dataGrid.SelectedIndex);
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show(dataGrid.SelectedIndex.ToString());
            MainViewModel mvm = new MainViewModel();
            System.Windows.MessageBox.Show(mvm.Items1.Count.ToString());
          
            //mvm.Items1.RemoveAt(mvm.Items1.Count-2);
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = mvm.Items1;
            //dataGrid.Items.Remove(dataGrid.SelectedIndex);
            //  dataGrid.Items.RemoveAt(dataGrid.SelectedIndex);

        }
    }

  
}
