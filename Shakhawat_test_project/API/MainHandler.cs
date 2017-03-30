using Shakhawat_test_project.Database;
using Shakhawat_test_project.JSON;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakhawat_test_project.API
{
    class MainHandler
    {
        public void handler()
        {
            Handle.GET("/welcome", () =>
            {
                return Db.Scope(() =>
                {
                    var json = new WelcomeJson();


                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });
               
            });

            Handle.GET("/office/{?}", (string Id) =>
            {
                return Db.Scope(() =>
                {
                    FranchiseOffice office = Db.SQL<FranchiseOffice>("SELECT o FROM FranchiseOffice o WHERE o.ID= ?", Id).First;
                    var json = new CorporationJson()
                    {
                        Data = office
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });
            });
              
        }
    }

   
}
