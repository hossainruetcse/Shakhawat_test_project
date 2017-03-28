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
               
                var json = new WelcomeJson()
                {
                    Data = "Welcome"
                };

                if (Session.Current == null)
                {
                    Session.Current = new Session();
                }
                json.Session = Session.Current;
                return json;
            });
        }
    }
}
