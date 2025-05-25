namespace Calendar_App
{
    partial class Form1
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
            this.rtbCal = new System.Windows.Forms.RichTextBox();
            this.btnPrintDate = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbCal
            // 
            this.rtbCal.Location = new System.Drawing.Point(15, 50);
            this.rtbCal.Name = "rtbCal";
            this.rtbCal.ReadOnly = true;
            this.rtbCal.Size = new System.Drawing.Size(282, 127);
            this.rtbCal.TabIndex = 1;
            this.rtbCal.Text = "";
            // 
            // btnPrintDate
            // 
            this.btnPrintDate.Location = new System.Drawing.Point(15, 191);
            this.btnPrintDate.Name = "btnPrintDate";
            this.btnPrintDate.Size = new System.Drawing.Size(282, 23);
            this.btnPrintDate.TabIndex = 3;
            this.btnPrintDate.Text = "Display Calendar";
            this.btnPrintDate.UseVisualStyleBackColor = true;
            this.btnPrintDate.Click += new System.EventHandler(this.btnPrintDate_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(15, 12);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(201, 21);
            this.cbMonth.TabIndex = 4;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(222, 13);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(75, 20);
            this.tbYear.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 226);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.btnPrintDate);
            this.Controls.Add(this.rtbCal);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCal;
        private System.Windows.Forms.Button btnPrintDate;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.TextBox tbYear;
    }
}

