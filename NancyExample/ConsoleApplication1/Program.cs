using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace ConsoleApplication1
{
    class Program
    {   /// <summary>
    /// Aim is building nanyc self hosting
    /// </summary>
        private string _url = "http://localhost";
        private int _port = 12345;
        private NancyHost _nancy;

        public Program()
        {
            //specifiying nancy hosting
            var configuration = new HostConfiguration()
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };
            var uri = new Uri($"{_url}:{_port}/");
            _nancy = new NancyHost(configuration,uri);
        }

        private void Start()
        {
            _nancy.Start();
            Console.WriteLine($"Listennig port {_port}");
            Console.ReadKey();
            _nancy.Stop();
        }
        static void Main(string[] args)
        {
            var p = new Program();
            p.Start();

        }
    }
}
