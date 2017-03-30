using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakhawat_test_project.Database
{
    [Database]
    public class Address
    {
        public string parentId;
        public long street;
        public long number;
        public long zipCode;
        public string city;
        public string country;
    }
}
