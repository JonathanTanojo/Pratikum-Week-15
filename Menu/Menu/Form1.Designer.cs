namespace Menu
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
            this.labeldewi = new System.Windows.Forms.Label();
            this.radioButtonmakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonminuman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxpilihan = new System.Windows.Forms.ComboBox();
            this.labelharga = new System.Windows.Forms.Label();
            this.labelhargakeluar = new System.Windows.Forms.Label();
            this.listBoxjenis = new System.Windows.Forms.ListBox();
            this.listBoxharga = new System.Windows.Forms.ListBox();
            this.labelitems = new System.Windows.Forms.Label();
            this.buttondelete = new System.Windows.Forms.Button();
            this.labelsize = new System.Windows.Forms.Label();
            this.radioButtonnormal = new System.Windows.Forms.RadioButton();
            this.radioButtonjumbo = new System.Windows.Forms.RadioButton();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.buttoncheckout = new System.Windows.Forms.Button();
            this.panelminuman = new System.Windows.Forms.Panel();
            this.panelminuman.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeldewi
            // 
            this.labeldewi.AutoSize = true;
            this.labeldewi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldewi.Location = new System.Drawing.Point(241, 36);
            this.labeldewi.Name = "labeldewi";
            this.labeldewi.Size = new System.Drawing.Size(130, 33);
            this.labeldewi.TabIndex = 0;
            this.labeldewi.Text = "Bu Dewi";
            // 
            // radioButtonmakanan
            // 
            this.radioButtonmakanan.AutoSize = true;
            this.radioButtonmakanan.Location = new System.Drawing.Point(350, 94);
            this.radioButtonmakanan.Name = "radioButtonmakanan";
            this.radioButtonmakanan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonmakanan.TabIndex = 1;
            this.radioButtonmakanan.TabStop = true;
            this.radioButtonmakanan.Text = "Makanan";
            this.radioButtonmakanan.UseVisualStyleBackColor = true;
            this.radioButtonmakanan.CheckedChanged += new System.EventHandler(this.radioButtonmakanan_CheckedChanged);
            // 
            // radioButtonminuman
            // 
            this.radioButtonminuman.AutoSize = true;
            this.radioButtonminuman.Location = new System.Drawing.Point(456, 94);
            this.radioButtonminuman.Name = "radioButtonminuman";
            this.radioButtonminuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonminuman.TabIndex = 2;
            this.radioButtonminuman.TabStop = true;
            this.radioButtonminuman.Text = "Minuman";
            this.radioButtonminuman.UseVisualStyleBackColor = true;
            this.radioButtonminuman.CheckedChanged += new System.EventHandler(this.radioButtonminuman_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " Menu :";
            // 
            // comboBoxpilihan
            // 
            this.comboBoxpilihan.FormattingEnabled = true;
            this.comboBoxpilihan.Location = new System.Drawing.Point(400, 133);
            this.comboBoxpilihan.Name = "comboBoxpilihan";
            this.comboBoxpilihan.Size = new System.Drawing.Size(121, 21);
            this.comboBoxpilihan.TabIndex = 4;
            this.comboBoxpilihan.SelectedIndexChanged += new System.EventHandler(this.comboBoxpilihan_SelectedIndexChanged);
            // 
            // labelharga
            // 
            this.labelharga.AutoSize = true;
            this.labelharga.Location = new System.Drawing.Point(527, 136);
            this.labelharga.Name = "labelharga";
            this.labelharga.Size = new System.Drawing.Size(45, 13);
            this.labelharga.TabIndex = 5;
            this.labelharga.Text = " Harga :";
            // 
            // labelhargakeluar
            // 
            this.labelhargakeluar.AutoSize = true;
            this.labelhargakeluar.Location = new System.Drawing.Point(579, 136);
            this.labelhargakeluar.Name = "labelhargakeluar";
            this.labelhargakeluar.Size = new System.Drawing.Size(0, 13);
            this.labelhargakeluar.TabIndex = 6;
            // 
            // listBoxjenis
            // 
            this.listBoxjenis.FormattingEnabled = true;
            this.listBoxjenis.Location = new System.Drawing.Point(12, 94);
            this.listBoxjenis.Name = "listBoxjenis";
            this.listBoxjenis.Size = new System.Drawing.Size(172, 225);
            this.listBoxjenis.TabIndex = 7;
            // 
            // listBoxharga
            // 
            this.listBoxharga.FormattingEnabled = true;
            this.listBoxharga.Location = new System.Drawing.Point(190, 95);
            this.listBoxharga.Name = "listBoxharga";
            this.listBoxharga.Size = new System.Drawing.Size(120, 225);
            this.listBoxharga.TabIndex = 8;
            // 
            // labelitems
            // 
            this.labelitems.AutoSize = true;
            this.labelitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelitems.Location = new System.Drawing.Point(162, 73);
            this.labelitems.Name = "labelitems";
            this.labelitems.Size = new System.Drawing.Size(58, 18);
            this.labelitems.TabIndex = 9;
            this.labelitems.Text = "ITEMS";
            // 
            // buttondelete
            // 
            this.buttondelete.Enabled = false;
            this.buttondelete.Location = new System.Drawing.Point(220, 326);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 10;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // labelsize
            // 
            this.labelsize.AutoSize = true;
            this.labelsize.Location = new System.Drawing.Point(12, 11);
            this.labelsize.Name = "labelsize";
            this.labelsize.Size = new System.Drawing.Size(33, 13);
            this.labelsize.TabIndex = 11;
            this.labelsize.Text = "Size :";
            this.labelsize.Visible = false;
            // 
            // radioButtonnormal
            // 
            this.radioButtonnormal.AutoSize = true;
            this.radioButtonnormal.Location = new System.Drawing.Point(13, 37);
            this.radioButtonnormal.Name = "radioButtonnormal";
            this.radioButtonnormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonnormal.TabIndex = 12;
            this.radioButtonnormal.TabStop = true;
            this.radioButtonnormal.Text = "Normal";
            this.radioButtonnormal.UseVisualStyleBackColor = true;
            this.radioButtonnormal.Visible = false;
            this.radioButtonnormal.CheckedChanged += new System.EventHandler(this.radioButtonnormal_CheckedChanged);
            // 
            // radioButtonjumbo
            // 
            this.radioButtonjumbo.AutoSize = true;
            this.radioButtonjumbo.Location = new System.Drawing.Point(102, 37);
            this.radioButtonjumbo.Name = "radioButtonjumbo";
            this.radioButtonjumbo.Size = new System.Drawing.Size(56, 17);
            this.radioButtonjumbo.TabIndex = 13;
            this.radioButtonjumbo.TabStop = true;
            this.radioButtonjumbo.Text = "Jumbo";
            this.radioButtonjumbo.UseVisualStyleBackColor = true;
            this.radioButtonjumbo.Visible = false;
            this.radioButtonjumbo.CheckedChanged += new System.EventHandler(this.radioButtonjumbo_CheckedChanged);
            // 
            // buttonbuy
            // 
            this.buttonbuy.Location = new System.Drawing.Point(405, 280);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(107, 39);
            this.buttonbuy.TabIndex = 14;
            this.buttonbuy.Text = "Buy";
            this.buttonbuy.UseVisualStyleBackColor = true;
            this.buttonbuy.Click += new System.EventHandler(this.buttonbuy_Click);
            // 
            // buttoncheckout
            // 
            this.buttoncheckout.Location = new System.Drawing.Point(542, 314);
            this.buttoncheckout.Name = "buttoncheckout";
            this.buttoncheckout.Size = new System.Drawing.Size(97, 35);
            this.buttoncheckout.TabIndex = 15;
            this.buttoncheckout.Text = "Check Out";
            this.buttoncheckout.UseVisualStyleBackColor = true;
            this.buttoncheckout.Click += new System.EventHandler(this.buttoncheckout_Click);
            // 
            // panelminuman
            // 
            this.panelminuman.Controls.Add(this.labelsize);
            this.panelminuman.Controls.Add(this.radioButtonnormal);
            this.panelminuman.Controls.Add(this.radioButtonjumbo);
            this.panelminuman.Location = new System.Drawing.Point(363, 172);
            this.panelminuman.Name = "panelminuman";
            this.panelminuman.Size = new System.Drawing.Size(180, 102);
            this.panelminuman.TabIndex = 16;
            this.panelminuman.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 375);
            this.Controls.Add(this.panelminuman);
            this.Controls.Add(this.buttoncheckout);
            this.Controls.Add(this.buttonbuy);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.labelitems);
            this.Controls.Add(this.listBoxharga);
            this.Controls.Add(this.listBoxjenis);
            this.Controls.Add(this.labelhargakeluar);
            this.Controls.Add(this.labelharga);
            this.Controls.Add(this.comboBoxpilihan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonminuman);
            this.Controls.Add(this.radioButtonmakanan);
            this.Controls.Add(this.labeldewi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelminuman.ResumeLayout(false);
            this.panelminuman.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldewi;
        private System.Windows.Forms.RadioButton radioButtonmakanan;
        private System.Windows.Forms.RadioButton radioButtonminuman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxpilihan;
        private System.Windows.Forms.Label labelharga;
        private System.Windows.Forms.Label labelhargakeluar;
        private System.Windows.Forms.ListBox listBoxjenis;
        private System.Windows.Forms.ListBox listBoxharga;
        private System.Windows.Forms.Label labelitems;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Label labelsize;
        private System.Windows.Forms.RadioButton radioButtonnormal;
        private System.Windows.Forms.RadioButton radioButtonjumbo;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.Button buttoncheckout;
        private System.Windows.Forms.Panel panelminuman;
    }
}

