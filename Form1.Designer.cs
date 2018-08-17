namespace RezervasyonProjesi
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
            this.components = new System.ComponentModel.Container();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.rdRez1 = new System.Windows.Forms.RadioButton();
            this.rdRez2 = new System.Windows.Forms.RadioButton();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(522, 70);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(133, 21);
            this.cmbSaat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "randevu saati :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "randevu günü : ";
            // 
            // cmbGun
            // 
            this.cmbGun.FormattingEnabled = true;
            this.cmbGun.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba"});
            this.cmbGun.Location = new System.Drawing.Point(522, 25);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(133, 21);
            this.cmbGun.TabIndex = 2;
            // 
            // rdRez1
            // 
            this.rdRez1.AutoSize = true;
            this.rdRez1.Location = new System.Drawing.Point(661, 29);
            this.rdRez1.Name = "rdRez1";
            this.rdRez1.Size = new System.Drawing.Size(52, 17);
            this.rdRez1.TabIndex = 4;
            this.rdRez1.TabStop = true;
            this.rdRez1.Text = "liste 1";
            this.rdRez1.UseVisualStyleBackColor = true;
            // 
            // rdRez2
            // 
            this.rdRez2.AutoSize = true;
            this.rdRez2.Location = new System.Drawing.Point(661, 52);
            this.rdRez2.Name = "rdRez2";
            this.rdRez2.Size = new System.Drawing.Size(52, 17);
            this.rdRez2.TabIndex = 5;
            this.rdRez2.TabStop = true;
            this.rdRez2.Text = "liste 2";
            this.rdRez2.UseVisualStyleBackColor = true;
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Location = new System.Drawing.Point(546, 122);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(139, 54);
            this.btnRezervasyon.TabIndex = 6;
            this.btnRezervasyon.Text = "randevu al";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(516, 407);
            this.listBox.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Veysel SEBU";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.rdRez2);
            this.Controls.Add(this.rdRez1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSaat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Sistemi v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGun;
        private System.Windows.Forms.RadioButton rdRez1;
        private System.Windows.Forms.RadioButton rdRez2;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

