using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingDojo4DataLib;

namespace CodingDojo3.ViewModel
{
    class MainViewModel: BaseViewModel
    {

        private List<StockEntry> stock;
        public MainViewModel()
        {
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
        }
    }
}
