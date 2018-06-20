using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace ConsoleApplication1
{
    class ExampleModule : NancyModule
    {
        public ExampleModule() : base ("/config")
        {
            Get["/"] = _ => "Received GET request";

            Post["/important"] = _ => "Received POST request";
        }
    }
}
