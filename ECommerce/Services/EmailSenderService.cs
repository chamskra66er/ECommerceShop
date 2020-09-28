using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Services
{
    public class EmailSenderService : IEmailGoogle
    {
        public IConfiguration Configuration { get; }
        public EmailSenderService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task SendEmailAsync(string emailFrom, string emailTo, string subject, string message)
        {
            MailMessage mailMessage = new MailMessage(emailFrom, emailTo);
            mailMessage.Subject = subject;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                string email = Configuration["SmtpCredential:Email"];
                string password = Configuration["SmtpCredential:Password"];

                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(email, password);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                await smtpClient.SendMailAsync(mailMessage);

                smtpClient.Dispose();
            }
        }
    }
}
