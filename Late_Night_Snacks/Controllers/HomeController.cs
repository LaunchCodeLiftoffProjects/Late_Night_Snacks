using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Late_Night_Snacks.Models;
using Late_Night_Snacks.ViewModels;
using System.Net.Mail;
using System.Net;

namespace Late_Night_Snacks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ContactViewModel contactViewModel = new ContactViewModel();
            return View(contactViewModel);
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                var mailbody =
                    $@"Hello owner,
                    
                    This is a new message from the website:

                    Name: {contactViewModel.Name}
                    Email: {contactViewModel.Email}
                    Message: ""{contactViewModel.Message}""

                    Cheers,
                    .NET Core email system";
                using (var message = new MailMessage())
                {
                    message.To.Add(new MailAddress("adiputra.ismail@gmail.com"));
                    message.From = new MailAddress("ismail@mail.workdaystl.org");
                    message.Subject = "New E-Mail from Website";
                    message.Body = mailbody;
                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.Host = "smtp.sparkpostmail.com";
                        smtpClient.Port = 587;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential("SMTP_Injection", "8fb8c1803f294bbef3f9b7912fcdb61189b33295");
                        smtpClient.Send(message);
                    }
                }
                return View();
            }
            return View(contactViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
