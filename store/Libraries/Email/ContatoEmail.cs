using store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace store.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            /*
             SMTP -> Servidor que envia a mensagem
            */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //remove as credencias padrão
            smtp.UseDefaultCredentials = false;
            //
            smtp.Credentials = new NetworkCredential("", "");
            smtp.EnableSsl = true;

            /*
             MailMessage -> constroi a mensagem
            */

            /*mockup da mensagem*/
            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" +
                "<b>Nome: </b> {0} <br />"+
                "<b>Email: </b> {1} <br/ >"+
                "<b>Texto: </b> {2}"+
                "<br /> Email enviado automaticamente do site LojaVirtual.",
                contato.Nome, 
                contato.Email,
                contato.Texto
                );


            string remetente = "";

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(remetente);
            mensagem.To.Add(remetente);
            mensagem.Subject = "Contato - LojaVIrtual - Email: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;
            //enviar msg via smtp
            smtp.Send(mensagem);
            
        }
    }
}
