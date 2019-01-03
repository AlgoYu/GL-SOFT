using System.Diagnostics;
using VerifyCode.Gif;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class ValidateCodeController : ManagementSystemControllerBase
    {
        // GET: ValidateCode
        [AllowAnonymous]
        public FileResult Index()
        {
            var vg = new VerificationGif(105, 30);
            var stream = vg.Create();

            HttpContext.Session.SetString("ValidateCode", vg.IdentifyingCode.ToLower());
            Debug.WriteLine(HttpContext.Session.GetString("ValidateCode"));
            Debug.WriteLine("进页面时："+HttpContext.Session.Id);
            

            var codeBytes = stream.ToArray();
            stream.Close();

            return File(codeBytes, "image/gif");
        }
    }
}