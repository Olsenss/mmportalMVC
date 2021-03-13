using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace mmportalMVC.Services
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            var smtpClient = new SmtpClient("send.one.com")
            {
                Port = 587,                
                Credentials = new NetworkCredential("service@mellemmanden.dk", "23gvVHt6jHTPgqw"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("service@mellemmanden.dk"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(to);
            smtpClient.Send(mailMessage);
        }
    }
}