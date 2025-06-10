using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BibliotekaServer)))
            {
                host.AddServiceEndpoint(typeof(IBiblioteka),
                    new BasicHttpBinding(), new Uri("http://localhost:8000"));
                host.Open();
                Console.WriteLine("Servis pokrenut...");
                Console.ReadKey();
            }
        }
    }
}
