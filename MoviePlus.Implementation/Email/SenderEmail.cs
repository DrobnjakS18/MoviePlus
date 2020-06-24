using MoviePlus.Application.Email;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MoviePlus.Implementation.Email
{
    public class SenderEmail : IEmailSender
    {
        private readonly string _sender;
        private readonly string _password;

        public SenderEmail(string sender, string password)
        {
            _sender = sender;
            _password = password;
        }

        public void Send(EmailDto dto)
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_sender, _password)
            };

            var message = new MailMessage(_sender, dto.EmailTo);
            message.Subject = dto.Subject;
            message.Body = dto.Content;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
    }
}
