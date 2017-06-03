using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

namespace CMSServer
{
    class SendEmail
    {
        MailAddress fromAddress = new MailAddress("issProject001@gmail.com");
        const string fromPassword = "proiectiss";

        
        private MailAddress toAddress;
        private string subject;
        private string message;

        public SendEmail(MailAddress toAddress, string subject,string message)
        {
            this.toAddress = toAddress;
            this.subject = subject;
            this.message = message;
        }

        public void send()
        {

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (MailMessage msg = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = message
            })
        {
            smtp.Send(msg);
        }
}

        

    }
}
