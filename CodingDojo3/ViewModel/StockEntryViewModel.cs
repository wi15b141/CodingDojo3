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

        private double salespriceinEuro;
    
        public StockEntryViewModel(StockEntry entry)
        {
            stockEntry = entry;
        }
    }
}
