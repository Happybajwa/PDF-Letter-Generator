using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterGenerator
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }
        private void openLetterFormButton_Click(object sender, EventArgs e)
        {
            Form1 form = new();
            this.Hide();
            form.Show();
        }
        //Open file dialog box when link is clicked

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string filePath in openFileDialog1.FileNames)
            {
                if (File.Exists(filePath))
                {
                    try
                    {
                        string fileName = Path.GetFileName(filePath);
                        list.Items.Add(fileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private async Task sendEmailButton_Click_1(object sender, EventArgs e)
        {
            //using (MailMessage mm = new MailMessage(usernameTextBox.Text.Trim(), recevierTextBox.Text.Trim()))
            //{
            //    mm.Subject = sujectTextBox.Text;
            //    mm.Body = bodyTextBox.Text;
            //    foreach (string filePath in ofd.FileNames)
            //    {
            //        if (File.Exists(filePath))
            //        {
            //            string fileName = Path.GetFileName(filePath);
            //            mm.Attachments.Add(new Attachment(filePath));
            //        }
            //    }
            //    mm.IsBodyHtml = false;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.EnableSsl = true;
            //    NetworkCredential NetworkCred = new NetworkCredential(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
            //    smtp.UseDefaultCredentials = true;
            //    smtp.Credentials = NetworkCred;
            //    smtp.Port = 587;
            //    smtp.Send(mm);
            //    MessageBox.Show("Email sent.", "Message");
            //}
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(usernameTextBox.Text.Trim());
                mail.To.Add(recevierTextBox.Text.Trim());
                mail.Subject = sujectTextBox.Text;
                mail.Body = bodyTextBox.Text;
                mail.IsBodyHtml = false;
                foreach (string filePath in openFileDialog1.FileNames)
                {
                    if (File.Exists(filePath))
                    {
                        string fileName = Path.GetFileName(filePath);
                        mail.Attachments.Add(new Attachment(filePath));
                    }
                }


                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    MessageBox.Show("Your Email has been sent successfully.", "Email Sent");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    sujectTextBox.Text = "";
                    bodyTextBox.Text = "";
                    recevierTextBox.Text = "";
                    list.Items.Clear();
                }
            }
        }

        private void attachmentButton_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
