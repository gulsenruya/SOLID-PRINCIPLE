namespace KrediKartBuilder_WFA
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
            this.cmBoxKartipi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnVar = new System.Windows.Forms.RadioButton();
            this.nupKartLimit = new System.Windows.Forms.NumericUpDown();
            this.tbxBankaAdi = new System.Windows.Forms.TextBox();
            this.btnKartOlustur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKartLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBoxKartipi
            // 
            this.cmBoxKartipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxKartipi.FormattingEnabled = true;
            this.cmBoxKartipi.Items.AddRange(new object[] {
            "Visa",
            "Master",
            "American Express"});
            this.cmBoxKartipi.Location = new System.Drawing.Point(113, 93);
            this.cmBoxKartipi.Name = "cmBoxKartipi";
            this.cmBoxKartipi.Size = new System.Drawing.Size(162, 26);
            this.cmBoxKartipi.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmBoxKartipi);
            this.groupBox1.Controls.Add(this.radBtnVar);
            this.groupBox1.Controls.Add(this.nupKartLimit);
            this.groupBox1.Controls.Add(this.tbxBankaAdi);
            this.groupBox1.Controls.Add(this.btnKartOlustur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cüzdan Tanımla";
            // 
            // radBtnVar
            // 
            this.radBtnVar.AutoSize = true;
            this.radBtnVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnVar.Location = new System.Drawing.Point(112, 199);
            this.radBtnVar.Name = "radBtnVar";
            this.radBtnVar.Size = new System.Drawing.Size(120, 24);
            this.radBtnVar.TabIndex = 8;
            this.radBtnVar.TabStop = true;
            this.radBtnVar.Text = "Taksit Imkani";
            this.radBtnVar.UseVisualStyleBackColor = true;
            // 
            // nupKartLimit
            // 
            this.nupKartLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupKartLimit.Location = new System.Drawing.Point(110, 149);
            this.nupKartLimit.Name = "nupKartLimit";
            this.nupKartLimit.Size = new System.Drawing.Size(165, 26);
            this.nupKartLimit.TabIndex = 7;
            // 
            // tbxBankaAdi
            // 
            this.tbxBankaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBankaAdi.Location = new System.Drawing.Point(112, 36);
            this.tbxBankaAdi.Name = "tbxBankaAdi";
            this.tbxBankaAdi.Size = new System.Drawing.Size(163, 26);
            this.tbxBankaAdi.TabIndex = 5;
            // 
            // btnKartOlustur
            // 
            this.btnKartOlustur.Location = new System.Drawing.Point(110, 257);
            this.btnKartOlustur.Name = "btnKartOlustur";
            this.btnKartOlustur.Size = new System.Drawing.Size(146, 33);
            this.btnKartOlustur.TabIndex = 4;
            this.btnKartOlustur.Text = "Oluştur";
            this.btnKartOlustur.UseVisualStyleBackColor = true;
            this.btnKartOlustur.Click += new System.EventHandler(this.BtnKartOlustur_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taksit :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kart Limiti:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Tipi :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Adi :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(333, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 339);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Banka Adi";
            this.columnHeader1.Width = 156;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kart Tipi";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kart Tipi";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Taksit";
            this.columnHeader4.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(907, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKartLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxKartipi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnVar;
        private System.Windows.Forms.NumericUpDown nupKartLimit;
        private System.Windows.Forms.TextBox tbxBankaAdi;
        private System.Windows.Forms.Button btnKartOlustur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

