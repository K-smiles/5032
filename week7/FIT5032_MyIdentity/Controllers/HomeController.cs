using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Runtime.ConstrainedExecution;

namespace FIT5032_MyIdentity.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            
            Task task = send();
            task.Wait();
            System.Diagnostics.Debug.Write("\nFinished {0} loop iterations");
            ViewBag.Message = "Your contact page.";
            return View();
        }

        static async Task send()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("lu452126871@gmail.com", "Example User");
            var subject = "Sending with Twilio SendGrid is Fun";
            var to = new EmailAddress("lucheng202303@163.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            System.Diagnostics.Debug.Write("Finished {0} loop iterations");

           var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
        }


    }
}


