namespace Menu
{
    partial class Form2
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
            this.checkBoxdiscount = new System.Windows.Forms.CheckBox();
            this.buttoncalculate = new System.Windows.Forms.Button();
            this.labelsubtotal = new System.Windows.Forms.Label();
            this.labeltax = new System.Windows.Forms.Label();
            this.labeldiscount = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.labelkeluarsubtotal = new System.Windows.Forms.Label();
            this.labelkeluartax = new System.Windows.Forms.Label();
            this.labelkeluardiscount = new System.Windows.Forms.Label();
            this.labelkeluartotal = new System.Windows.Forms.Label();
            this.labelinput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxdiscount
            // 
            this.checkBoxdiscount.AutoSize = true;
            this.checkBoxdiscount.Location = new System.Drawing.Point(22, 23);
            this.checkBoxdiscount.Name = "checkBoxdiscount";
            this.checkBoxdiscount.Size = new System.Drawing.Size(68, 17);
            this.checkBoxdiscount.TabIndex = 0;
            this.checkBoxdiscount.Text = "Discount";
            this.checkBoxdiscount.UseVisualStyleBackColor = true;
            this.checkBoxdiscount.CheckedChanged += new System.EventHandler(this.checkBoxdiscount_CheckedChanged);
            // 
            // buttoncalculate
            // 
            this.buttoncalculate.Location = new System.Drawing.Point(22, 177);
            this.buttoncalculate.Name = "buttoncalculate";
            this.buttoncalculate.Size = new System.Drawing.Size(93, 42);
            this.buttoncalculate.TabIndex = 1;
            this.buttoncalculate.Text = "Calculate";
            this.buttoncalculate.UseVisualStyleBackColor = true;
            this.buttoncalculate.Click += new System.EventHandler(this.buttoncalculate_Click);
            // 
            // labelsubtotal
            // 
            this.labelsubtotal.AutoSize = true;
            this.labelsubtotal.Location = new System.Drawing.Point(251, 23);
            this.labelsubtotal.Name = "labelsubtotal";
            this.labelsubtotal.Size = new System.Drawing.Size(46, 13);
            this.labelsubtotal.TabIndex = 2;
            this.labelsubtotal.Text = "Subtotal";
            // 
            // labeltax
            // 
            this.labeltax.AutoSize = true;
            this.labeltax.Location = new System.Drawing.Point(254, 51);
            this.labeltax.Name = "labeltax";
            this.labeltax.Size = new System.Drawing.Size(25, 13);
            this.labeltax.TabIndex = 3;
            this.labeltax.Text = "Tax";
            // 
            // labeldiscount
            // 
            this.labeldiscount.AutoSize = true;
            this.labeldiscount.Location = new System.Drawing.Point(254, 82);
            this.labeldiscount.Name = "labeldiscount";
            this.labeldiscount.Size = new System.Drawing.Size(49, 13);
            this.labeldiscount.TabIndex = 4;
            this.labeldiscount.Text = "Discount";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(254, 117);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(31, 13);
            this.labeltotal.TabIndex = 5;
            this.labeltotal.Text = "Total";
            // 
            // labelkeluarsubtotal
            // 
            this.labelkeluarsubtotal.AutoSize = true;
            this.labelkeluarsubtotal.Location = new System.Drawing.Point(354, 22);
            this.labelkeluarsubtotal.Name = "labelkeluarsubtotal";
            this.labelkeluarsubtotal.Size = new System.Drawing.Size(13, 13);
            this.labelkeluarsubtotal.TabIndex = 6;
            this.labelkeluarsubtotal.Text = "0";
            // 
            // labelkeluartax
            // 
            this.labelkeluartax.AutoSize = true;
            this.labelkeluartax.Location = new System.Drawing.Point(354, 51);
            this.labelkeluartax.Name = "labelkeluartax";
            this.labelkeluartax.Size = new System.Drawing.Size(13, 13);
            this.labelkeluartax.TabIndex = 7;
            this.labelkeluartax.Text = "0";
            // 
            // labelkeluardiscount
            // 
            this.labelkeluardiscount.AutoSize = true;
            this.labelkeluardiscount.Location = new System.Drawing.Point(354, 82);
            this.labelkeluardiscount.Name = "labelkeluardiscount";
            this.labelkeluardiscount.Size = new System.Drawing.Size(13, 13);
            this.labelkeluardiscount.TabIndex = 8;
            this.labelkeluardiscount.Text = "0";
            // 
            // labelkeluartotal
            // 
            this.labelkeluartotal.AutoSize = true;
            this.labelkeluartotal.Location = new System.Drawing.Point(354, 117);
            this.labelkeluartotal.Name = "labelkeluartotal";
            this.labelkeluartotal.Size = new System.Drawing.Size(13, 13);
            this.labelkeluartotal.TabIndex = 9;
            this.labelkeluartotal.Text = "0";
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Location = new System.Drawing.Point(3, 46);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(31, 13);
            this.labelinput.TabIndex = 10;
            this.labelinput.Text = "Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelinput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(22, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelkeluartotal);
            this.Controls.Add(this.labelkeluardiscount);
            this.Controls.Add(this.labelkeluartax);
            this.Controls.Add(this.labelkeluarsubtotal);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labeldiscount);
            this.Controls.Add(this.labeltax);
            this.Controls.Add(this.labelsubtotal);
            this.Controls.Add(this.buttoncalculate);
            this.Controls.Add(this.checkBoxdiscount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxdiscount;
        private System.Windows.Forms.Button buttoncalculate;
        private System.Windows.Forms.Label labelsubtotal;
        private System.Windows.Forms.Label labeltax;
        private System.Windows.Forms.Label labeldiscount;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label labelkeluarsubtotal;
        private System.Windows.Forms.Label labelkeluartax;
        private System.Windows.Forms.Label labelkeluardiscount;
        private System.Windows.Forms.Label labelkeluartotal;
        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}