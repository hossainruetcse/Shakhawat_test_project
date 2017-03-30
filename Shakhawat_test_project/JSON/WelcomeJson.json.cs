using Shakhawat_test_project.Database;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakhawat_test_project.JSON
{
    partial class WelcomeJson:Json
    {
        private static string NUMBER_OF_HOME= "number_of_home_sold";
        public IEnumerable<Corporation> Corporations => Db.SQL<Corporation>("SELECT c FROM Corporation c");
        public IEnumerable<FranchiseOffice> offices { get; set; }
        public IEnumerable<FranchiseOffice> Offices
        {
            get { return offices = Db.SQL<FranchiseOffice>("SELECT o FROM FranchiseOffice o"); }
            set { offices = value; }
        }
            



        void Handle(Input.CreateTrigger action)
        {
            new Corporation()
            {
                name = NewName
            };
            Transaction.Commit();
        }

        void Handle(Input.CreateOfficeTrigger action)
        {
            new FranchiseOffice()
            {
                ID = Guid.NewGuid().ToString(),
                name = NewOfficeName,
                number_of_home_sold = 0,
                total_commission = 0,
                trend = 0
            };
            Transaction.Commit();
        }

        void Handle(Input.sortByHomesTrigger action)
        {
            Offices = orderBy(NUMBER_OF_HOME);
            Transaction.Commit();
        }
        public IEnumerable<FranchiseOffice> orderBy(string property)
        {
            string query = "SELECT o FROM FranchiseOffice o ORDER BY " + property;
            return Db.SQL<FranchiseOffice>(query);
        }

    }
}
