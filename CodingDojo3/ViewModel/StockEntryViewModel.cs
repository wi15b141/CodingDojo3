using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingDojo4DataLib;

namespace CodingDojo3.ViewModel
{
    class StockEntryViewModel : BaseViewModel
    { 
        private StockEntry stockEntry;
       

      //  private double salespriceInEuro;

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

        public double PurchasePrice
        {
            get { return stockEntry.SoftwarePackage.PurchasePrice; }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
                onChange("SalesPrice");
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
        }
    }
}
