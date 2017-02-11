using System;
using MessageUI;
using PasionaCursoForms.DependencyService;
using PasionaCursoForms.iOS.DependencyService;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(EmailService))]
namespace PasionaCursoForms.iOS.DependencyService
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string destinationEmail)
        {
            if (MFMailComposeViewController.CanSendMail)
            {
                var mailController = new MFMailComposeViewController();
                mailController.SetToRecipients(new[] { destinationEmail });
                mailController.SetSubject("mail test");
                mailController.SetMessageBody("this is a test", false);

                mailController.Finished += (s, args) => {
                    Console.WriteLine(args.Result.ToString());
                    args.Controller.DismissViewController(true, null);
                };

                var window = UIApplication.SharedApplication.KeyWindow;
                var viewController = window.RootViewController;
                viewController.PresentViewController(mailController, true, null);
            }
        }
    }
}
