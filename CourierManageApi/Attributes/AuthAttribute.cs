using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CourierManageApi.Attributes
{
    public class AuthAttribute : TypeFilterAttribute
    {
        public AuthAttribute(string actionName, string controller) : base(typeof(AuthorizeAction))
        {
            Arguments = new object[] {
            actionName,
            controller
            };
        }
    }
}
