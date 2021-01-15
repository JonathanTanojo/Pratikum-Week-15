using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cekdelete()
        {
            if (listBoxjenis.Items.Count != 0)
            {
                buttondelete.Enabled = true;
            }
            if (listBoxjenis.Items.Count == 0)
            {
                buttondelete.Enabled = false;
            }
        }
        private void buttonbuy_Click(object sender, EventArgs e)
        {
            listBoxjenis.Items.Add(comboBoxpilihan.SelectedItem);
            if (comboBoxpilihan.SelectedItem.ToString() == "Nasi Goreng")
            {
                listBoxharga.Items.Add(10000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nasi Goreng Spesial")
            {
                listBoxharga.Items.Add(12000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                listBoxharga.Items.Add(15000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Ayam Bakar")
            {
                listBoxharga.Items.Add(15000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Es Teh" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(5000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Teh Hangat" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(3000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nutrisari" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(6000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Aqua" && radioButtonnormal.Checked == true)
            {
                listBoxharga.Items.Add(2000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Es Teh" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(7000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Teh Hangat" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(5000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nutrisari" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(10000);
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Aqua" && radioButtonjumbo.Checked == true)
            {
                listBoxharga.Items.Add(5000);
            }
            cekdelete();
        }

        private void radioButtonminuman_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxpilihan.Text = "";
            labelhargakeluar.Text = "";
            if (radioButtonminuman.Checked == true)
            {
                comboBoxpilihan.Items.Add("Es Teh");
                comboBoxpilihan.Items.Add("Teh Hangat");
                comboBoxpilihan.Items.Add("Nutrisari");
                comboBoxpilihan.Items.Add("Aqua");
                panelminuman.Visible = true;
            }
            if (radioButtonminuman.Checked == false)
            {
                comboBoxpilihan.Items.Clear();
            }
            labelsize.Visible = true;
            radioButtonjumbo.Visible = true;
            radioButtonnormal.Visible = true;
        }

        private void radioButtonmakanan_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxpilihan.Text = "";
            labelhargakeluar.Text = "";
            if (radioButtonmakanan.Checked == true)
            {
                comboBoxpilihan.Items.Add("Nasi Goreng");
                comboBoxpilihan.Items.Add("Nasi Goreng Spesial");
                comboBoxpilihan.Items.Add("Nasi Goreng Pete");
                comboBoxpilihan.Items.Add("Ayam Bakar");
            }
            if (radioButtonmakanan.Checked == false)
            {
                comboBoxpilihan.Items.Clear();
            }
            labelsize.Visible = false;
            radioButtonjumbo.Visible = false;
            radioButtonnormal.Visible = false;
            
        }

        private void comboBoxpilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxpilihan.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelhargakeluar.Text = "10000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nasi Goreng Spesial")
            {
                labelhargakeluar.Text = "12000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                labelhargakeluar.Text = "15000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Ayam Bakar")
            {
                labelhargakeluar.Text = "15000";
            }

            radioButtonnormal_CheckedChanged(sender, e);
            radioButtonjumbo_CheckedChanged(sender, e);
        }

        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            
            if (listBoxjenis.Items.Count == 0)
            {
                MessageBox.Show("Pilihan menu ");
            }
            else 
            {
                Form2 formkedua = new Form2();
                formkedua.ShowDialog();
            }
            
        }

        private void radioButtonnormal_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxpilihan.SelectedItem.ToString() == "Es Teh" && radioButtonnormal.Checked == true)
            {
                labelhargakeluar.Text = "5000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Teh Hangat" && radioButtonnormal.Checked == true)
            {
                labelhargakeluar.Text = "3000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nutrisari" && radioButtonnormal.Checked == true)
            {
                labelhargakeluar.Text = "6000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Aqua" && radioButtonnormal.Checked == true)
            {
                labelhargakeluar.Text = "2000";
            }
        }

        private void radioButtonjumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxpilihan.SelectedItem.ToString() == "Es Teh" && radioButtonjumbo.Checked == true)
            {
                labelhargakeluar.Text = "7000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Teh Hangat" && radioButtonjumbo.Checked == true)
            {
                labelhargakeluar.Text = "5000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Nutrisari" && radioButtonjumbo.Checked == true)
            {
                labelhargakeluar.Text = "10000";
            }
            if (comboBoxpilihan.SelectedItem.ToString() == "Aqua" && radioButtonjumbo.Checked == true)
            {
                labelhargakeluar.Text = "5000";
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            
            listBoxjenis.Items.RemoveAt(listBoxjenis.SelectedIndex);
            listBoxharga.Items.RemoveAt(listBoxharga.SelectedIndex);
            cekdelete();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cekdelete();
        }
    }
}
