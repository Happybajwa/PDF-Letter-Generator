using System;
using System.Windows.Forms;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf;

using iText.IO.Font;
using iText.Kernel.Colors;

namespace LetterGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

//PDF Letter Generate Button Code
        private void submitButton_Click(object sender, EventArgs e)
        {
            PdfLetter();
        }
        
        // Path of the Letter
        string path = @"C:\Users\happy\OneDrive\Desktop\letterGenerator\letter.pdf";
        public void PdfLetter()
        {
            try
            {
// create PDFWriter, PDF Document, Document classes for pdf generation
                PdfWriter pWriter = new PdfWriter(path);
                PdfDocument pDocument = new PdfDocument(pWriter);
                Document document = new Document(pDocument);
                var font = iText.Kernel.Font.PdfFontFactory.CreateFont(FontConstants.TIMES_ROMAN);
                document.SetFont(font);
// Create required paragraphs for letter generator and input from UI used
                Paragraph p1_Location = new Paragraph("\n\n");
                Paragraph p2_From = new Paragraph();
                Text From = new Text("From").SetBold();
                p2_From.Add(From);
                Paragraph p3_FromAddress = new Paragraph();
                Paragraph p4_Receiver = new Paragraph();
                Text To = new Text("To").SetBold();
                p4_Receiver.Add(To);
                Paragraph p5_ReceiverAddress = new Paragraph();
                Paragraph p6_Lable= new Paragraph("Dear Sir/Madam");
                Paragraph p7_Subject = new Paragraph();
                Paragraph p8_Body = new Paragraph();
                Paragraph p9_thank = new Paragraph("\n\nThanking You\n\n");
                Paragraph p10_lable2 = new Paragraph("Your Sincerely\n");
                //Get User Input from FORM
                //get Selected date
                string date = datePicker.Value.ToString().Substring(0, 9);
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
                    buf1 += toAddress[i];
                }
                // add the adress abovr to concerned paragraph
                p5_ReceiverAddress.Add(buf1);
                //set padding to the paragraph
                p5_ReceiverAddress.SetPaddingLeft(23.5f);
                //add subject message
                //get subject message from user
                string subject = subjectTextBox.Text;
                p7_Subject.Add(subject);
                //add margin for this subject using marginleft() method
                p7_Subject.SetMarginLeft(23.5f);
                //add body of the message to pragraph
                //get the body of the message from user
                string content = bodyTextBox.Text;
                //add this content to concerned para
                p8_Body.Add(content);
                //set Text alignment for this body
                p8_Body.SetTextAlignment(TextAlignment.JUSTIFIED);
                //set text alignment for thank you
                p9_thank.SetTextAlignment(TextAlignment.CENTER);
                // now set text alignement for lable (your sincerely)
                p10_lable2.SetTextAlignment(TextAlignment.RIGHT);
                // now add all these paragraphs to document object for final pdf
                document.Add(p1_Location);
                document.Add(p2_From);
                document.Add(p3_FromAddress);
                document.Add(p4_Receiver);
                document.Add(p5_ReceiverAddress);
                document.Add(p6_Lable);
                document.Add(p7_Subject);
                document.Add(p8_Body);
                document.Add(p9_thank);
                document.Add(p10_lable2);
                document.Add(p1_Location);
                //Close the document object doc using close instance method
                document.Close();
                //veify and conformation pop up for user
                // use Exist method of file class in c# which is available in system
                if(System.IO.File.Exists(path))
                {
                    MessageBox.Show("Letter has been created Successfully","Success");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        //Reset Button Code
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Clear all text fields setting their value to null
            locationTextBox.Text = "";
            senderTextBox.Text = "";
            receiverTextBox.Text = "";
            subjectTextBox.Text = "";
            bodyTextBox.Text = "";
        }

        //Exit Button Code
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Using static method of application to exit from the application
            Application.Exit();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
