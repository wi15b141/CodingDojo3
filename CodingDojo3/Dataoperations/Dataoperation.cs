using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingDojo4DataLib;

namespace CodingDojo3.Dataoperations
{
    class Dataoperation
    {
        private List<Software> availableSoftware = new List<Software>();
        private List<Group> availableGroups = new List<Group>();
        private Stock currentStock;

        public Dataoperation()
        {

        }
        public StockEntry add_new_item()
        {
            availableSoftware.Add(new Software("New Software"));
            availableGroups.Add(new Group()

            {
                Name = "New Group",
                Software = new List<Software>()
                {
                    availableSoftware[0],

                }
            });
            availableSoftware[0].Category = availableGroups.Last();
            currentStock = new Stock();
            StockEntry st= new StockEntry() { SoftwarePackage = availableSoftware[0], Amount = 0 };
            return st;
          
        }
    }

}
