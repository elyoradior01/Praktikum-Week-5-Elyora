namespace Praktikum_Week_5_Elyora
{
    partial class FormUtama
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
            this.labelData = new System.Windows.Forms.Label();
            this.txtBoxIsi = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LabelKoleksi = new System.Windows.Forms.Label();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.CheckBoxAktif = new System.Windows.Forms.CheckBox();
            this.RadioButtonMerah = new System.Windows.Forms.RadioButton();
            this.RadioButtonBiru = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.bttnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(27, 30);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(53, 25);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // txtBoxIsi
            // 
            this.txtBoxIsi.Location = new System.Drawing.Point(86, 27);
            this.txtBoxIsi.Name = "txtBoxIsi";
            this.txtBoxIsi.Size = new System.Drawing.Size(413, 31);
            this.txtBoxIsi.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(524, 25);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(112, 34);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LabelKoleksi
            // 
            this.LabelKoleksi.AutoSize = true;
            this.LabelKoleksi.Location = new System.Drawing.Point(27, 90);
            this.LabelKoleksi.Name = "LabelKoleksi";
            this.LabelKoleksi.Size = new System.Drawing.Size(71, 25);
            this.LabelKoleksi.TabIndex = 3;
            this.LabelKoleksi.Text = "Koleksi:";
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 25;
            this.listBoxKoleksi.Location = new System.Drawing.Point(27, 128);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(292, 279);
            this.listBoxKoleksi.TabIndex = 4;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxKoleksi_SelectedIndexChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(440, 90);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(72, 25);
            this.labelSetting.TabIndex = 5;
            this.labelSetting.Text = "Setting:";
            // 
            // CheckBoxAktif
            // 
            this.CheckBoxAktif.AutoSize = true;
            this.CheckBoxAktif.Location = new System.Drawing.Point(524, 90);
            this.CheckBoxAktif.Name = "CheckBoxAktif";
            this.CheckBoxAktif.Size = new System.Drawing.Size(75, 29);
            this.CheckBoxAktif.TabIndex = 6;
            this.CheckBoxAktif.Text = "Aktif";
            this.CheckBoxAktif.UseVisualStyleBackColor = true;
            this.CheckBoxAktif.CheckedChanged += new System.EventHandler(this.CheckBoxAktif_CheckedChanged);
            // 
            // RadioButtonMerah
            // 
            this.RadioButtonMerah.AutoSize = true;
            this.RadioButtonMerah.Location = new System.Drawing.Point(440, 128);
            this.RadioButtonMerah.Name = "RadioButtonMerah";
            this.RadioButtonMerah.Size = new System.Drawing.Size(142, 29);
            this.RadioButtonMerah.TabIndex = 7;
            this.RadioButtonMerah.TabStop = true;
            this.RadioButtonMerah.Text = "Warna Merah";
            this.RadioButtonMerah.UseVisualStyleBackColor = true;
            this.RadioButtonMerah.CheckedChanged += new System.EventHandler(this.RadioButtonMerah_CheckedChanged);
            // 
            // RadioButtonBiru
            // 
            this.RadioButtonBiru.AutoSize = true;
            this.RadioButtonBiru.Location = new System.Drawing.Point(440, 163);
            this.RadioButtonBiru.Name = "RadioButtonBiru";
            this.RadioButtonBiru.Size = new System.Drawing.Size(122, 29);
            this.RadioButtonBiru.TabIndex = 8;
            this.RadioButtonBiru.TabStop = true;
            this.RadioButtonBiru.Text = "Warna Biru";
            this.RadioButtonBiru.UseVisualStyleBackColor = true;
            this.RadioButtonBiru.CheckedChanged += new System.EventHandler(this.RadioButtonBiru_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(546, 285);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(105, 45);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "label2";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(400, 385);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(361, 34);
            this.bttnClear.TabIndex = 11;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioButtonBiru);
            this.Controls.Add(this.RadioButtonMerah);
            this.Controls.Add(this.CheckBoxAktif);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.LabelKoleksi);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtBoxIsi);
            this.Controls.Add(this.labelData);
            this.Name = "FormUtama";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelData;
        private TextBox txtBoxIsi;
        private Button BtnAdd;
        private Label LabelKoleksi;
        private ListBox listBoxKoleksi;
        private Label labelSetting;
        private CheckBox CheckBoxAktif;
        private RadioButton RadioButtonMerah;
        private RadioButton RadioButtonBiru;
        private Label label1;
        private Label lblOutput;
        private Button bttnClear;
    }
}