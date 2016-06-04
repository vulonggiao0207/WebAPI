using System.Web;
using JsonServices;
using JsonServices.Web;
namespace JSONWebAPI
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : JsonHandler
    {
        public Handler1()
        {
            this.service.Name = "JSONWebAPI";
            this.service.Description = "JSON API for android appliation";
            InterfaceConfiguration IConfig = new InterfaceConfiguration("RestAPI", typeof(IServiceAPI), typeof(ServiceAPI));
            this.service.Interfaces.Add(IConfig);
        }
    }
}