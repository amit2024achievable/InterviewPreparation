using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_SingleResponsibliltyPrinciple
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }

        private ILogger filelogger;
        private MailSender mailSender;

        public Invoice()
        {
            filelogger = new Logger();
            mailSender = new MailSender();
        }


        public void AddInvoice()
        {
            try
            {
               

                filelogger.Info("Generating the Invoice");
                // Logic for Genration
                filelogger.Info("Invoce has been Generated and Sending an Email");
                mailSender.EMailFrom = "emailfrom@xyz.com";
                mailSender.EMailTo = "emailto@xyz.com";
                mailSender.EMailSubject = "Single Responsibility Princile";
                mailSender.EMailBody = "A class should have only one reason to change";
                mailSender.SendEmail();
                filelogger.Info("Invoce Sent!!");

            }
            catch(Exception ex) 
            {
               filelogger.Error(ex.Message , ex);
            }


        }

    }
}
