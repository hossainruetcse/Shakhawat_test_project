using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakhawat_test_project.Database
{
    [Database]
    public class FranchiseOffice
    {
        public string ID;
        public string name;
        public int number_of_home_sold;
        public int total_commission;
        public int trend;
        public Corporation corporation;
    }
}
