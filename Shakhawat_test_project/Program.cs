using System;
using Starcounter;
using Shakhawat_test_project.API;

namespace Shakhawat_test_project
{
    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            MainHandler mainHandler = new MainHandler();
            mainHandler.handler();

        }
    }
}