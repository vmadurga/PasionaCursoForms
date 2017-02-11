using System;
using Windows.System;
using PasionaCursoForms.DependencyService;
using PasionaCursoForms.Windows.DependencyService;

[assembly: Xamarin.Forms.Dependency(typeof(EmailService))]
namespace PasionaCursoForms.Windows.DependencyService
{
    public class EmailService : IEmailService
    {
        public async void SendEmail(string destinationEmail)
        {
            Uri mailtoUri = new Uri("mailto:" + destinationEmail + "?subject=" + "Windows 8.1 Subject!" + "&body=" + "Windows 8.1 Body!");
            await Launcher.LaunchUriAsync(mailtoUri);
        }
    }
}
