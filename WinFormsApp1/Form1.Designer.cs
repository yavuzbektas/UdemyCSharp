namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labeName = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelLastNameValue = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.labelJobValue = new System.Windows.Forms.Label();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTransfered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenMessagePopup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(720, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Label_1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 103);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(133, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "ChangeLabel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(654, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name  : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeName.Location = new System.Drawing.Point(655, 170);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(52, 15);
            this.labeName.TabIndex = 6;
            this.labeName.Text = "Name  : ";
            this.labeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 240);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3);
            this.button3.Size = new System.Drawing.Size(133, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "ChangeLabel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNameValue.Location = new System.Drawing.Point(721, 170);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(32, 15);
            this.labelNameValue.TabIndex = 4;
            this.labelNameValue.Text = "var1";
            this.labelNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLastName.Location = new System.Drawing.Point(655, 188);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 15);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "lastName  : ";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLastNameValue
            // 
            this.labelLastNameValue.AutoSize = true;
            this.labelLastNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastNameValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLastNameValue.Location = new System.Drawing.Point(721, 188);
            this.labelLastNameValue.Name = "labelLastNameValue";
            this.labelLastNameValue.Size = new System.Drawing.Size(32, 15);
            this.labelLastNameValue.TabIndex = 7;
            this.labelLastNameValue.Text = "var1";
            this.labelLastNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelJob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelJob.Location = new System.Drawing.Point(655, 206);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(38, 15);
            this.labelJob.TabIndex = 10;
            this.labelJob.Text = "Job  : ";
            this.labelJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJobValue
            // 
            this.labelJobValue.AutoSize = true;
            this.labelJobValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelJobValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelJobValue.Location = new System.Drawing.Point(721, 206);
            this.labelJobValue.Name = "labelJobValue";
            this.labelJobValue.Size = new System.Drawing.Size(32, 15);
            this.labelJobValue.TabIndex = 9;
            this.labelJobValue.Text = "var1";
            this.labelJobValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(52, 193);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.buttonTransfer.Size = new System.Drawing.Size(133, 40);
            this.buttonTransfer.TabIndex = 11;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 12;
            // 
            // labelTransfered
            // 
            this.labelTransfered.AutoSize = true;
            this.labelTransfered.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransfered.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTransfered.Location = new System.Drawing.Point(209, 165);
            this.labelTransfered.Name = "labelTransfered";
            this.labelTransfered.Size = new System.Drawing.Size(100, 15);
            this.labelTransfered.TabIndex = 13;
            this.labelTransfered.Text = "Label_transfered";
            this.labelTransfered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTransfered);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.labelJobValue);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelLastNameValue);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelNameValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MyCode Form Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label labeName;
        private Button button3;
        private Label labelNameValue;
        private Label labelLastName;
        private Label labelLastNameValue;
        private Label labelJob;
        private Label labelJobValue;
        private Button buttonTransfer;
        private TextBox textBox1;
        private Label labelTransfered;
    }
}