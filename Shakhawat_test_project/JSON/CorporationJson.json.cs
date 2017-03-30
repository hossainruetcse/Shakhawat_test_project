using Shakhawat_test_project.Database;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakhawat_test_project.JSON
{
    partial class CorporationJson : Json
    {
       

        public string FranchiseOfficeID { get; internal set; }
        public FranchiseOffice Office { get; set; }

        // public FranchiseOffice office => Db.SQL<FranchiseOffice>("SELECT o FROM FranchiseOffice o WHERE o.ID= ?", FranchiseOfficeID).First;
        public FranchiseOffice office
        {
            get { return Office = Db.SQL<FranchiseOffice>("SELECT o FROM FranchiseOffice o WHERE o.ID= ?", ID).First; }
            set { Office = value; }
        }

        public IEnumerable<Transection> Transection => Db.SQL<Transection>("SELECT t FROM Transection t WHERE t.ID= ?", ID);
        public Address Addres { get; set; }

        public Address address
        {
            get { return Addres = Db.SQL<Address>("SELECT a FROM Address a WHERE a.parentId= ?", ID).First; }
            set { Addres = value; }
        }

        void Handle(Input.RegisterTrigger action)
        {
            string id = Guid.NewGuid().ToString();
            new Transection
            {
                ID=ID,
                price= NewSalePrice,
                comission= NewComissonInfo

            };
            new Address
            {
                parentId = ID,
                street= NewSaleStreet,
                number= NewSaleNumber,
                zipCode= NewSaleZipCode,
                city= NewSaleCity,
                country= NewSaleCountry
            };
            total_commission += NewComissonInfo;
            number_of_home_sold++;

           Transaction.Commit();
        }
    void Handle(Input.SaveTrigger action)
        {
            if (address == null)
            {
                new Address
                {
                    parentId = ID
                };
                address.street = address.street;
                address.number = address.number;
                address.zipCode = address.zipCode;
                address.city = address.city;
                address.country = address.country;
            }
            Transaction.Commit();
        }

        
    }
}
