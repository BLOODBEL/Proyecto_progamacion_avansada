using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class Utilitarios
    {

        public void EnviarCorreo(string Destino, string Asunto, string Contenido)
        {
            //do submit
            MailMessage emailMessage = new MailMessage();
            emailMessage.From = new MailAddress("dgarcia70246@ufide.ac.cr");
            emailMessage.To.Add(new MailAddress(Destino));
            emailMessage.Subject = Asunto;
            emailMessage.Body = Contenido;
            emailMessage.Priority = MailPriority.Normal;
            SmtpClient MailClient = new SmtpClient("smtp.office365.com", 587);
            MailClient.Credentials = new System.Net.NetworkCredential("dgarcia70246@ufide.ac.cr", "1857Klms+");
            MailClient.Send(emailMessage);

        }




    }
}