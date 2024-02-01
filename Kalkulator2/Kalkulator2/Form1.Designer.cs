namespace Kalkulator2
{
    partial class Hanum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbil1 = new System.Windows.Forms.TextBox();
            this.txtbil2 = new System.Windows.Forms.TextBox();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btnmodulus = new System.Windows.Forms.Button();
            this.btnpangkat = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Sederhana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilangan 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bilangan 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(100, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // txtbil1
            // 
            this.txtbil1.Location = new System.Drawing.Point(427, 65);
            this.txtbil1.Name = "txtbil1";
            this.txtbil1.Size = new System.Drawing.Size(248, 23);
            this.txtbil1.TabIndex = 4;
            // 
            // txtbil2
            // 
            this.txtbil2.Location = new System.Drawing.Point(427, 131);
            this.txtbil2.Name = "txtbil2";
            this.txtbil2.Size = new System.Drawing.Size(248, 23);
            this.txtbil2.TabIndex = 5;
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(427, 203);
            this.txthasil.Name = "txthasil";
            this.txthasil.ReadOnly = true;
            this.txthasil.Size = new System.Drawing.Size(248, 23);
            this.txthasil.TabIndex = 6;
            // 
            // btntambah
            // 
            this.btntambah.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntambah.Location = new System.Drawing.Point(52, 294);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 7;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnkurang.Location = new System.Drawing.Point(278, 294);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(75, 23);
            this.btnkurang.TabIndex = 8;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = true;
            this.btnkurang.Click += new System.EventHandler(this.btnkurang_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbagi.Location = new System.Drawing.Point(494, 294);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(75, 23);
            this.btnbagi.TabIndex = 9;
            this.btnbagi.Text = "/";
            this.btnbagi.UseVisualStyleBackColor = true;
            this.btnbagi.Click += new System.EventHandler(this.btnbagi_Click);
            // 
            // btnkali
            // 
            this.btnkali.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnkali.Location = new System.Drawing.Point(52, 382);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(75, 23);
            this.btnkali.TabIndex = 10;
            this.btnkali.Text = "x";
            this.btnkali.UseVisualStyleBackColor = true;
            this.btnkali.Click += new System.EventHandler(this.btnkali_Click);
            // 
            // btnmodulus
            // 
            this.btnmodulus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmodulus.Location = new System.Drawing.Point(278, 382);
            this.btnmodulus.Name = "btnmodulus";
            this.btnmodulus.Size = new System.Drawing.Size(75, 23);
            this.btnmodulus.TabIndex = 11;
            this.btnmodulus.Text = "%";
            this.btnmodulus.UseVisualStyleBackColor = true;
            this.btnmodulus.Click += new System.EventHandler(this.btnmodulus_Click);
            // 
            // btnpangkat
            // 
            this.btnpangkat.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpangkat.Location = new System.Drawing.Point(494, 382);
            this.btnpangkat.Name = "btnpangkat";
            this.btnpangkat.Size = new System.Drawing.Size(75, 23);
            this.btnpangkat.TabIndex = 12;
            this.btnpangkat.Text = "^";
            this.btnpangkat.UseVisualStyleBackColor = true;
            this.btnpangkat.Click += new System.EventHandler(this.btnpangkat_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear.Location = new System.Drawing.Point(672, 335);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Hanum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnpangkat);
            this.Controls.Add(this.btnmodulus);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.txtbil2);
            this.Controls.Add(this.txtbil1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hanum";
            this.Text = "Hanum";
            this.DoubleClick += new System.EventHandler(this.Hanum_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbil1;
        private TextBox txtbil2;
        private TextBox txthasil;
        private Button btntambah;
        private Button btnkurang;
        private Button btnbagi;
        private Button btnkali;
        private Button btnmodulus;
        private Button btnpangkat;
        private Button btnclear;
    }
}