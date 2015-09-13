using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net .Mail ;
using System.Windows .Forms ;

namespace smtp邮箱
{
    public class Send
    {

        public string sendEmail { get; set; }
        public string getEmail { get; set; }
        public string emailTitle { get; set; }
        public string emailContent { get; set; }


        public void SendStmpEmail()
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(getEmail);
            msg.From = new MailAddress(sendEmail, "ki", System.Text.Encoding.UTF8);
            msg.Subject = emailTitle;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = emailContent;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.High;


            SmtpClient client = new SmtpClient();
            client.Host = "smtp.163.com";
            client.Credentials = new System.Net.NetworkCredential(sendEmail, "leimingkai130262");


            try
            {
                client.Send(msg);
                MessageBox.Show("发送成功！！");

            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message ,"发送失败！！");
            }
        }

    }
}
