using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicos
{
    public class EmailServices
    {
        private const string SenhaApp = "xwip hzyb mvwf xhhv";
        private const string UsuarioApp = "allan.r.aguiar@aluno.senai.br";
        private const string GmailSmtp = "smtp.gmail.com";
        private const int GmailPorta = 587;

        public string Remetente { get; private set; }
        public string Destinatario { get; private set; }
        public string Assunto { get; private set; }
        public string Mensagem { get; private set; }


        public EmailServices(string remetente, string destinatario, string assunto, string mensagem)
        {
            Remetente = remetente;
            Destinatario = destinatario;
            Assunto = assunto;
            Mensagem = mensagem;
        }

        public bool EnviarEmail()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", Remetente));
            message.To.Add(new MailboxAddress("", Destinatario));
            message.Subject = Assunto;

            message.Body = new TextPart("plain")
            {
                Text = Mensagem
            };

            using (var client = new SmtpClient())
            {
                client.Connect(GmailSmtp, GmailPorta, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("joey", "password");

                client.Send(message);
                client.Disconnect(true);
                return true;
            }
        }     
    }
}      
        
    

