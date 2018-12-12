using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using CourtService;

namespace CourtHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CourtService.Court));
            //ServiceEndpoint ep = host.AddServiceEndpoint(typeof(ICourt), new WebHttpBinding(), "");
           // ServiceDebugBehavior sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            //sdb.HttpHelpPageEnabled = false;
            host.Open();
            Console.WriteLine("Service Hosted Sucessfully");
            Console.Read();
        }
    }
}
