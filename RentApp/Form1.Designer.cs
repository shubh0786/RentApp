namespace RentApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.cstLbl = new System.Windows.Forms.Label();
            this.datePickerRNT = new System.Windows.Forms.DateTimePicker();
            this.datePickerRTN = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sltcarBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental App";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(23, 151);
            this.customerNameBox.Multiline = true;
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(292, 54);
            this.customerNameBox.TabIndex = 1;
            // 
            // cstLbl
            // 
            this.cstLbl.AutoSize = true;
            this.cstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstLbl.Location = new System.Drawing.Point(18, 111);
            this.cstLbl.Name = "cstLbl";
            this.cstLbl.Size = new System.Drawing.Size(167, 25);
            this.cstLbl.TabIndex = 2;
            this.cstLbl.Text = "Customer Name";
            // 
            // datePickerRNT
            // 
            this.datePickerRNT.Location = new System.Drawing.Point(23, 252);
            this.datePickerRNT.Name = "datePickerRNT";
            this.datePickerRNT.Size = new System.Drawing.Size(292, 26);
            this.datePickerRNT.TabIndex = 3;
            // 
            // datePickerRTN
            // 
            this.datePickerRTN.Location = new System.Drawing.Point(478, 252);
            this.datePickerRTN.Name = "datePickerRTN";
            this.datePickerRTN.Size = new System.Drawing.Size(292, 26);
            this.datePickerRTN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Returned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Rented";
            // 
            // sltcarBox
            // 
            this.sltcarBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltcarBox.FormattingEnabled = true;
            this.sltcarBox.Items.AddRange(new object[] {
            "Honda ",
            "Toyota",
            "Suzuki",
            "Nissan"});
            this.sltcarBox.Location = new System.Drawing.Point(23, 328);
            this.sltcarBox.Name = "sltcarBox";
            this.sltcarBox.Size = new System.Drawing.Size(292, 28);
            this.sltcarBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type Of Car";
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.Black;
            this.submitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitbtn.Location = new System.Drawing.Point(478, 308);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(198, 77);
            this.submitbtn.TabIndex = 9;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tbcost
            // 
            this.tbcost.Location = new System.Drawing.Point(478, 151);
            this.tbcost.Multiline = true;
            this.tbcost.Name = "tbcost";
            this.tbcost.Size = new System.Drawing.Size(292, 54);
            this.tbcost.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sltcarBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePickerRTN);
            this.Controls.Add(this.datePickerRNT);
            this.Controls.Add(this.cstLbl);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label cstLbl;
        private System.Windows.Forms.DateTimePicker datePickerRNT;
        private System.Windows.Forms.DateTimePicker datePickerRTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sltcarBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbcost;
        private System.Windows.Forms.Label label2;
    }
}

