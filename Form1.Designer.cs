
namespace LetterGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.receiverTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4594, 157);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(384, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1253, 107);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto PDF Letter Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Date:";
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.CalendarFont = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(344, 192);
            this.datePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(491, 55);
            this.datePicker.TabIndex = 2;
            this.datePicker.Value = new System.DateTime(2021, 10, 2, 13, 15, 10, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1202, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(1560, 192);
            this.locationTextBox.Multiline = true;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(419, 72);
            this.locationTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 54);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sender(From Address)";
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(59, 356);
            this.senderTextBox.Multiline = true;
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(776, 372);
            this.senderTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1202, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 54);
            this.label5.TabIndex = 7;
            this.label5.Text = "Receiver(To Address)";
            // 
            // receiverTextBox
            // 
            this.receiverTextBox.Location = new System.Drawing.Point(1202, 356);
            this.receiverTextBox.Multiline = true;
            this.receiverTextBox.Name = "receiverTextBox";
            this.receiverTextBox.Size = new System.Drawing.Size(777, 372);
            this.receiverTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 766);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(471, 54);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subject of Message";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(59, 849);
            this.subjectTextBox.Multiline = true;
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(1920, 97);
            this.subjectTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(59, 989);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 54);
            this.label7.TabIndex = 11;
            this.label7.Text = "Body of Message";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(59, 1090);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(1920, 1003);
            this.bodyTextBox.TabIndex = 12;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Silver;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(1436, 2212);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(543, 111);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Generate Letter";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Silver;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(747, 2212);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(543, 111);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset ";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Silver;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Lucida Sans", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(59, 2212);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(543, 111);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(2028, 2556);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.receiverTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.senderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox receiverTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

