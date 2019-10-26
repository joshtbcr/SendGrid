using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendgridTest
{
    internal class Program
    {
        private static void Main()
        {
            SendEmail().Wait();
        }

        static async Task SendEmail()
        {
         
            var client = new SendGridClient("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"); //Aquí va el API KEY que se crea en Sendgrid
            var from = new EmailAddress("icascantes@ucenfotec.ac.cr"); //Esta es la dirección de correo emisora.
            var to = new EmailAddress("izahir.cascante@avantica.net"); //Esta es la dirección de correo receptora.
            var subject = "Email Test"; //Este es el asunto del correo  
            var plainTextContent = "message";
            var htmlContent = "<div>" +
                "<p>Hello dear Izahir, </p>" +  // Esto será lo que se presente en el cuerpo del correo (Contenido)
                "<p>This is an email test, please ignore it.</p>" + "<br>" + "<br>" +
                "<p> Thank you</p>" +
                "</div>";
            var msg = MailHelper.CreateSingleEmail(
                from, 
                to, 
                subject, 
                plainTextContent, 
                htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
