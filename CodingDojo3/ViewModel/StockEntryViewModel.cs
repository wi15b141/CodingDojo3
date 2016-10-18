using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;

namespace CodingDojo3.ViewModel
{
    class StockEntryViewModel : BaseViewModel
    {
     
        private StockEntry stockEntry;
        private List<Software> availableSoftware = new List<Software>();
        private List<Group> availableGroups = new List<Group>();

        public String Name
        {
            get { return stockEntry.SoftwarePackage.Name; }
            set { stockEntry.SoftwarePackage.Name = value;
                onChange("Name");
            }
        }

        public String Group
        {
            get { return stockEntry.SoftwarePackage.Category.Name; }
            set
            {
                stockEntry.SoftwarePackage.Category.Name = value;
                onChange("Name");
            }
        }

        public double SalesPrice
        {
            get { return stockEntry.SoftwarePackage.SalesPrice; }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
                onChange("SalesPrice");
            }
        }

        public double SalesPrice1 { get; set; }
        public double PurchasePrice1 { get; set; }




        public double PurchasePrice
        {
            get { return stockEntry.SoftwarePackage.PurchasePrice; }
            set
            {
                stockEntry.SoftwarePackage.PurchasePrice = value;
                onChange("PurchasePrice");
            }
        }

     


        public int OnStock
        {
            get { return stockEntry.Amount; }
            set
            {
                stockEntry.Amount = value;
                onChange("OnStock");
            }
        }

       


        public StockEntryViewModel(StockEntry entry)
        {
          
            stockEntry = entry;
            this.SalesPrice1 = entry.SoftwarePackage.SalesPrice;
            this.PurchasePrice1 = entry.SoftwarePackage.PurchasePrice;
        }

       

        public String toString()
        {
            return this.Name +" -  "+this.Group;
        }

      /*  public void CalculateSalesPriceFromEuro(Currencies currency)
        {
            this.SalesPrice = CurrencyConverter.ConvertFromEuroTo(currency,prices);
        }*/


    }
}
