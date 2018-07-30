using Microsoft.AspNetCore.Antiforgery;
using DotNetCoreWebApiProject.Controllers;

namespace DotNetCoreWebApiProject.Web.Host.Controllers
{
    public class AntiForgeryController : DotNetCoreWebApiProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
