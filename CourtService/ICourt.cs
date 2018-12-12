using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CourtService
{
    [ServiceContract]
    public interface ICourt
    {
        [OperationContract]
        int MakeDecision(ServiceContract composite);
    }

    [DataContract]
    public class ServiceContract
    {
        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public double TotalPartCost { get; set; }

        [DataMember]
        public double TotalServicesCost { get; set; }

        [DataMember]
        public double Total { get; set; }
    }
}