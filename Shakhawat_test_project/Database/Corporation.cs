﻿using Starcounter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakhawat_test_project.Database
{
    [Database]
    public class Corporation
    {
        public string name;
        public IEnumerable FranchiseOffice
        {
            get { return Db.SQL<FranchiseOffice>("select e from FranchiseOffice o where o.corporation = ?", this); }
        }
    }
}
