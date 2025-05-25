namespace _3D_Array_TimeTable
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
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.tbEnterSub = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSearchSub = new System.Windows.Forms.Button();
            this.btnViewTimeTbl = new System.Windows.Forms.Button();
            this.rtbDisplayTimeTbl = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbGrade.Location = new System.Drawing.Point(382, 62);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(121, 21);
            this.cbGrade.TabIndex = 0;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cbDay.Location = new System.Drawing.Point(12, 62);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 21);
            this.cbDay.TabIndex = 1;
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "Period 1",
            "Period 2",
            "Period 3",
            "Period 4",
            "Period 5",
            "Period 6"});
            this.cbPeriod.Location = new System.Drawing.Point(198, 62);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(121, 21);
            this.cbPeriod.TabIndex = 2;
            // 
            // tbEnterSub
            // 
            this.tbEnterSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnterSub.Location = new System.Drawing.Point(198, 23);
            this.tbEnterSub.Name = "tbEnterSub";
            this.tbEnterSub.Size = new System.Drawing.Size(121, 20);
            this.tbEnterSub.TabIndex = 3;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(12, 229);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(121, 23);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Set Subject";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnSearchSub
            // 
            this.btnSearchSub.Location = new System.Drawing.Point(139, 229);
            this.btnSearchSub.Name = "btnSearchSub";
            this.btnSearchSub.Size = new System.Drawing.Size(121, 23);
            this.btnSearchSub.TabIndex = 5;
            this.btnSearchSub.Text = "Search Subject";
            this.btnSearchSub.UseVisualStyleBackColor = true;
            this.btnSearchSub.Click += new System.EventHandler(this.btnSearchSub_Click);
            // 
            // btnViewTimeTbl
            // 
            this.btnViewTimeTbl.Location = new System.Drawing.Point(266, 229);
            this.btnViewTimeTbl.Name = "btnViewTimeTbl";
            this.btnViewTimeTbl.Size = new System.Drawing.Size(121, 23);
            this.btnViewTimeTbl.TabIndex = 6;
            this.btnViewTimeTbl.Text = "View Timetable";
            this.btnViewTimeTbl.UseVisualStyleBackColor = true;
            this.btnViewTimeTbl.Click += new System.EventHandler(this.btnViewTimeTbl_Click);
            // 
            // rtbDisplayTimeTbl
            // 
            this.rtbDisplayTimeTbl.Location = new System.Drawing.Point(12, 102);
            this.rtbDisplayTimeTbl.Name = "rtbDisplayTimeTbl";
            this.rtbDisplayTimeTbl.ReadOnly = true;
            this.rtbDisplayTimeTbl.Size = new System.Drawing.Size(491, 121);
            this.rtbDisplayTimeTbl.TabIndex = 7;
            this.rtbDisplayTimeTbl.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Subject Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDisplayTimeTbl);
            this.Controls.Add(this.btnViewTimeTbl);
            this.Controls.Add(this.btnSearchSub);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.tbEnterSub);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.TextBox tbEnterSub;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSearchSub;
        private System.Windows.Forms.Button btnViewTimeTbl;
        private System.Windows.Forms.RichTextBox rtbDisplayTimeTbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

