using Android.Content;
using PasionaCursoForms.DependencyService;
using PasionaCursoForms.Droid.DependencyService;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(EmailService))]
namespace PasionaCursoForms.Droid.DependencyService
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string destinationEmail)
        {
            var email = new Intent(Intent.ActionSend);
            email.PutExtra(Intent.ExtraEmail, new[] { destinationEmail });
            email.PutExtra(Intent.ExtraSubject, "Hello Email");
            email.PutExtra(Intent.ExtraText, "Hello from Xamarin.Android");
            email.SetType("message/rfc822");
            Forms.Context.StartActivity(email);
        }
    }
}