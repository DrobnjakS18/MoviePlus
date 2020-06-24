using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Email
{
    public interface IEmailSender
    {
        void Send(EmailDto dto);
    }

    public class EmailDto
    {
        public string EmailTo { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
