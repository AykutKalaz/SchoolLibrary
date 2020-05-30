namespace SchoolLibrary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdnBtnGenc = new System.Windows.Forms.RadioButton();
            this.rdnBtnOrta = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnBtnCocuk = new System.Windows.Forms.RadioButton();
            this.rdnBtn1 = new System.Windows.Forms.RadioButton();
            this.rdnBtn2 = new System.Windows.Forms.RadioButton();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lblTavsiye = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yaş aralığınız nedir?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hangi tür kitaplardan hoşlanırsınız?";
            // 
            // rdnBtnGenc
            // 
            this.rdnBtnGenc.AutoSize = true;
            this.rdnBtnGenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdnBtnGenc.Location = new System.Drawing.Point(208, 60);
            this.rdnBtnGenc.Name = "rdnBtnGenc";
            this.rdnBtnGenc.Size = new System.Drawing.Size(74, 26);
            this.rdnBtnGenc.TabIndex = 3;
            this.rdnBtnGenc.TabStop = true;
            this.rdnBtnGenc.Text = "16-25";
            this.rdnBtnGenc.UseVisualStyleBackColor = true;
            this.rdnBtnGenc.CheckedChanged += new System.EventHandler(this.rdnBtnGenc_CheckedChanged);
            // 
            // rdnBtnOrta
            // 
            this.rdnBtnOrta.AutoSize = true;
            this.rdnBtnOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdnBtnOrta.Location = new System.Drawing.Point(365, 60);
            this.rdnBtnOrta.Name = "rdnBtnOrta";
            this.rdnBtnOrta.Size = new System.Drawing.Size(59, 26);
            this.rdnBtnOrta.TabIndex = 4;
            this.rdnBtnOrta.TabStop = true;
            this.rdnBtnOrta.Text = "25/-";
            this.rdnBtnOrta.UseVisualStyleBackColor = true;
            this.rdnBtnOrta.CheckedChanged += new System.EventHandler(this.rdnBtnOrta_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnBtn2);
            this.groupBox1.Controls.Add(this.rdnBtn1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 122);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rdnBtnCocuk
            // 
            this.rdnBtnCocuk.AutoSize = true;
            this.rdnBtnCocuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdnBtnCocuk.Location = new System.Drawing.Point(38, 60);
            this.rdnBtnCocuk.Name = "rdnBtnCocuk";
            this.rdnBtnCocuk.Size = new System.Drawing.Size(64, 26);
            this.rdnBtnCocuk.TabIndex = 2;
            this.rdnBtnCocuk.TabStop = true;
            this.rdnBtnCocuk.Text = "9-15";
            this.rdnBtnCocuk.UseVisualStyleBackColor = true;
            this.rdnBtnCocuk.CheckedChanged += new System.EventHandler(this.rdnBtnCocuk_CheckedChanged);
            // 
            // rdnBtn1
            // 
            this.rdnBtn1.AutoSize = true;
            this.rdnBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdnBtn1.Location = new System.Drawing.Point(22, 78);
            this.rdnBtn1.Name = "rdnBtn1";
            this.rdnBtn1.Size = new System.Drawing.Size(14, 13);
            this.rdnBtn1.TabIndex = 6;
            this.rdnBtn1.TabStop = true;
            this.rdnBtn1.UseVisualStyleBackColor = true;
            // 
            // rdnBtn2
            // 
            this.rdnBtn2.AutoSize = true;
            this.rdnBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdnBtn2.Location = new System.Drawing.Point(252, 78);
            this.rdnBtn2.Name = "rdnBtn2";
            this.rdnBtn2.Size = new System.Drawing.Size(14, 13);
            this.rdnBtn2.TabIndex = 7;
            this.rdnBtn2.TabStop = true;
            this.rdnBtn2.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(38, 220);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(160, 36);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Kitabı Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lblTavsiye
            // 
            this.lblTavsiye.AutoSize = true;
            this.lblTavsiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTavsiye.Location = new System.Drawing.Point(33, 272);
            this.lblTavsiye.Name = "lblTavsiye";
            this.lblTavsiye.Size = new System.Drawing.Size(0, 22);
            this.lblTavsiye.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 328);
            this.Controls.Add(this.lblTavsiye);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdnBtnOrta);
            this.Controls.Add(this.rdnBtnGenc);
            this.Controls.Add(this.rdnBtnCocuk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdnBtnGenc;
        private System.Windows.Forms.RadioButton rdnBtnOrta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnBtn2;
        private System.Windows.Forms.RadioButton rdnBtn1;
        private System.Windows.Forms.RadioButton rdnBtnCocuk;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label lblTavsiye;
    }
}

