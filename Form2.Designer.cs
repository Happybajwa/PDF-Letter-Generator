
namespace LetterGenerator
{
    partial class EmailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            this.list = new System.Windows.Forms.ListBox();
            this.attachmentButton = new System.Windows.Forms.Button();
            this.openLetterFormButton = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.sujectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recevierTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AccessibleName = "";
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(142, 391);
            this.list.Margin = new System.Windows.Forms.Padding(1);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(308, 64);
            this.list.TabIndex = 46;
            // 
            // attachmentButton
            // 
            this.attachmentButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.attachmentButton.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attachmentButton.Location = new System.Drawing.Point(5, 391);
            this.attachmentButton.Margin = new System.Windows.Forms.Padding(1);
            this.attachmentButton.Name = "attachmentButton";
            this.attachmentButton.Size = new System.Drawing.Size(103, 26);
            this.attachmentButton.TabIndex = 45;
            this.attachmentButton.Text = "AttachFile";
            this.attachmentButton.UseVisualStyleBackColor = true;
            this.attachmentButton.UseWaitCursor = true;
            this.attachmentButton.Click += new System.EventHandler(this.attachmentButton_Click_1);
            // 
            // openLetterFormButton
            // 
            this.openLetterFormButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.openLetterFormButton.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openLetterFormButton.Location = new System.Drawing.Point(281, 499);
            this.openLetterFormButton.Margin = new System.Windows.Forms.Padding(1);
            this.openLetterFormButton.Name = "openLetterFormButton";
            this.openLetterFormButton.Size = new System.Drawing.Size(167, 31);
            this.openLetterFormButton.TabIndex = 44;
            this.openLetterFormButton.Text = "Open Letter Generator";
            this.openLetterFormButton.UseVisualStyleBackColor = true;
            this.openLetterFormButton.UseWaitCursor = true;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendEmailButton.Location = new System.Drawing.Point(344, 468);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(1);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(103, 24);
            this.sendEmailButton.TabIndex = 43;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Email:";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Password:";
            this.label4.UseWaitCursor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.passwordTextBox.Location = new System.Drawing.Point(142, 356);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(307, 23);
            this.passwordTextBox.TabIndex = 40;
            this.passwordTextBox.UseWaitCursor = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.usernameTextBox.Location = new System.Drawing.Point(142, 324);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(307, 23);
            this.usernameTextBox.TabIndex = 39;
            this.usernameTextBox.UseWaitCursor = true;
            // 
            // sujectTextBox
            // 
            this.sujectTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.sujectTextBox.Location = new System.Drawing.Point(142, 57);
            this.sujectTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.sujectTextBox.Multiline = true;
            this.sujectTextBox.Name = "sujectTextBox";
            this.sujectTextBox.Size = new System.Drawing.Size(307, 23);
            this.sujectTextBox.TabIndex = 38;
            this.sujectTextBox.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Subject:";
            this.label3.UseWaitCursor = true;
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bodyTextBox.Location = new System.Drawing.Point(142, 98);
            this.bodyTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(307, 218);
            this.bodyTextBox.TabIndex = 36;
            this.bodyTextBox.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Message:";
            this.label2.UseWaitCursor = true;
            // 
            // recevierTextBox
            // 
            this.recevierTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.recevierTextBox.Location = new System.Drawing.Point(142, 24);
            this.recevierTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.recevierTextBox.Multiline = true;
            this.recevierTextBox.Name = "recevierTextBox";
            this.recevierTextBox.Size = new System.Drawing.Size(307, 23);
            this.recevierTextBox.TabIndex = 34;
            this.recevierTextBox.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "To:";
            this.label1.UseWaitCursor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(468, 552);
            this.Controls.Add(this.list);
            this.Controls.Add(this.attachmentButton);
            this.Controls.Add(this.openLetterFormButton);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.sujectTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recevierTextBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "EmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button attachmentButton;
        private System.Windows.Forms.Button openLetterFormButton;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox sujectTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recevierTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}