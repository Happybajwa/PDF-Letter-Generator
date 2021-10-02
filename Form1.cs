using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf;



namespace LetterGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
// Path of the Letter

        string path = @"C:\Users\happy\OneDrive\Desktop\letterGenerator";

//PDF Letter Generate Button Code
        private void submitButton_Click(object sender, EventArgs e)
        {
            pdfLetter();
        }

        public void pdfLetter()
        {
            try
            {
// create PDFWriter, PDF Document, Document classes for pdf generation
                PdfWriter pWriter = new PdfWriter(path);
                PdfDocument pDocument = new PdfDocument(pWriter);
                Document document = new Document(pDocument);
// Create required paragraphs for letter generator and input from UI used
                Paragraph p1_Location = new Paragraph();
                Paragraph p2_From = new Paragraph("From");
                Paragraph p3_FromAddress = new Paragraph();
                Paragraph p4_Receiver = new Paragraph("To");
                Paragraph p5_ReceiverAddress = new Paragraph();
                Paragraph p6_Lable= new Paragraph("Dear Sir/Madam");
                Paragraph p7_Subject = new Paragraph("To");
                Paragraph p8_Body = new Paragraph("To");
                Paragraph p9_thank = new Paragraph("To");
                Paragraph p10_lable2 = new Paragraph("Your Sincerely");
                //Get User Input from FORM
                //get Selected date
                string date = datePicker.ToString().Substring(0, 9);
                //get location from Location TextBox
                string location = locationTextBox.Text;
                //add location and date to first paragraph
                p1_Location.Add(date + "\n" + location);
                //set the alignment for date and location
                p1_Location.SetTextAlignment(TextAlignment.RIGHT);
                //get user address line by line using split() method
                string sender = senderTextBox.Text;
                string[] address = sender.Split('\n');
                string buf = "";
                //add adress one by one in the string buf
                for(int i = -0;i<address.Length;i++)
                {
                    buf += address[i];
                }
                //add address to paragraph
                p3_FromAddress.Add(buf);
                //set padding to the paragraph
                p3_FromAddress.SetPaddingLeft(23.5f);
                // now process the address
                string receiver = receiverTextBox.Text;
                // split address line by line using split method()
                string[] toAddress = receiver.Split('\n');
                string buf1 = "";
                //add adress one by one in the string buf
                for (int i = -0; i < toAddress.Length; i++)
                {
                    buf += toAddress[i];
                }
                // add the adress abovr to concerned paragraph
                p5_ReceiverAddress.Add(buf1);
                //add subject message
                //get subject message from user
                string subject = subjectTextBox.Text;
                p7_Subject.Add(subject);
                //add margin for this subject using marginleft() method
                p7_Subject.SetMarginLeft(23.5f);








            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        //Reset Button Code
        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        //Exit Button Code
        private void exitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
