﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingDojo4DataLib;
using System.Collections.ObjectModel;
using CodingDojo4DataLib.Converter;
using System.Windows;
using CodingDojo3.Dataoperations;

namespace CodingDojo3.ViewModel
{
    class MainViewModel: BaseViewModel
    {
        public Array Currencies
        {
            get { return Enum.GetValues(typeof(CodingDojo4DataLib.Converter.Currencies)); }
        }

        public Currencies SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                //OnChange("SelectedCurrency");
                this.DoCalculation();
            }
        }

        private void DoCalculation()
        {
            foreach (var item in Items1)
            {
                //item.CalculateSalesPriceFromEuro(SelectedCurrency);
            }
        }

        private List<StockEntry> stock;
        private ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();
        private Currencies selectedCurrency;

        public ObservableCollection<StockEntryViewModel> Items1
        {
            get { return items; }
            set { items = value;
               
            }
        }

    
        public MainViewModel()
        {
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
            Dataoperations.Dataoperation dop = new Dataoperation();

            foreach (var item in stock)
            {

                Items1.Add(new StockEntryViewModel(item));

            }
           // Items1.Add(new StockEntryViewModel(dop.add_new_item()));
        }

      

        public void add_item()
        {



                SampleManager manager = new SampleManager();
                stock = manager.CurrentStock.OnStock;
                Dataoperations.Dataoperation dop = new Dataoperation();

                /*foreach (var item in stock)
                {

                    Items1.Add(new StockEntryViewModel(item));

                }*/
                Items1.Add(new StockEntryViewModel(dop.add_new_item()));
                
           
        }
         
       
    }
}
