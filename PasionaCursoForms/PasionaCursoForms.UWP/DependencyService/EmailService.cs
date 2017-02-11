using System;
using Windows.ApplicationModel.Email;
using PasionaCursoForms.DependencyService;
using PasionaCursoForms.UWP.DependencyService;

[assembly: Xamarin.Forms.Dependency(typeof(EmailService))]
namespace PasionaCursoForms.UWP.DependencyService
{
    public class EmailService : IEmailService
    {
        public async void SendEmail(string destinationEmail)
        {
            var emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient(destinationEmail));
            emailMessage.Body = "Hello World";
            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }
    }
}
