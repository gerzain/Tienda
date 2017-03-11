using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace Tienda_Virtual
{
    class SendEmail
    {
        private string smtp = "", correoFrom = "", contra = "", _correoTo, _body, _subject;

        public string subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private bool _enviado;

        public bool enviado
        {
            get { return _enviado; }
            set { _enviado = value; }
        }

        public string body
        {
            get { return _body; }
            set { _body = value; }
        }

        public string correoTo
        {
            get { return _correoTo; }
            set { _correoTo = value; }
        }

        public void CreateEmail()
        {
            string[] split = _correoTo.Split(new char[] { '@' });
            if (split[1] == "gmail.com")
            {
                smtp = "smtp.gmail.com";
                correoFrom = "irving.java@gmail.com";
                contra = "64325010";
            }
            else if (split[1] == "outlook.com" || split[1] == "hotmail.com" || split[1] == "live.com")
            {
                smtp = "smtp.live.com";
                correoFrom = "torby@outlook.com";
                contra = "e.-94B:_41";
            }
            MailMessage mail = new MailMessage();
                mail.From = new MailAddress("torby@outlook.com");
                mail.To.Add(_correoTo);
                mail.Subject = _subject;
                mail.IsBodyHtml = true;
                mail.Body = _body;
            SmtpClient SmtpServer = new SmtpClient(smtp);
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(correoFrom, contra);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            _enviado = true;
        }
    }
}
