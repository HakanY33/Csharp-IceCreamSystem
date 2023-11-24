using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

namespace IceCreamSystem
{

    public partial class Form1 : Form
    {


        double lemPrice;
        int lemCalorie;
        double banPrice;
        int banCalorie;
        double strPrice;
        int strCalorie;
        double choPrice;
        int choCalorie;

        int pieceLem;
        int pieceBan;
        int pieceStr;
        int pieceCho;

        int Amnt;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0))
            {
                pictureBox1.Image = imageList1.Images[0];
                numericUpDown1.Enabled = true;
            }
            else { pictureBox1.Image = null; }

            if (checkedListBox1.GetItemChecked(1))
            {
                pictureBox2.Image = imageList1.Images[1];
                numericUpDown2.Enabled = true;
            }
            else { pictureBox2.Image = null; }

            if (checkedListBox1.GetItemChecked(2))
            {
                pictureBox3.Image = imageList1.Images[2];
                numericUpDown3.Enabled = true;
            }
            else { pictureBox3.Image = null; }

            if (checkedListBox1.GetItemChecked(3))
            {
                pictureBox4.Image = imageList1.Images[3];
                numericUpDown4.Enabled = true;
            }
            else { pictureBox4.Image = null; }



        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Enabled || radioButton2.Enabled || radioButton3.Enabled)
            {
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox7.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;


            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {


        }
        private void priceandcalorie(object? sender, EventArgs e)
        {
            double totalprice = 0;
            double totalcalorie = 0;
            double amount = 0;

            if (radioButton1.Checked)
            {
                lemPrice = 0.25;
                lemCalorie = 115;
                banPrice = 0.55;
                banCalorie = 175;
                strPrice = 0.75;
                strCalorie = 135;
                choPrice = 0.80;
                choCalorie = 235;

                pieceLem = (int)numericUpDown1.Value;
                pieceBan = (int)numericUpDown2.Value;
                pieceStr = (int)numericUpDown3.Value;
                pieceCho = (int)numericUpDown4.Value;



            }
            else if (radioButton2.Checked)
            {
                lemPrice = 0.35;
                lemCalorie = 125;
                banPrice = 0.65;
                banCalorie = 325;
                strPrice = 0.85;
                strCalorie = 225;
                choPrice = 0.90;
                choCalorie = 340;

                pieceLem = (int)numericUpDown1.Value;
                pieceBan = (int)numericUpDown2.Value;
                pieceStr = (int)numericUpDown3.Value;
                pieceCho = (int)numericUpDown4.Value;
            }
            else if (radioButton3.Checked)
            {
                lemPrice = 0.40;
                lemCalorie = 175;
                banPrice = 0.80;
                banCalorie = 365;
                strPrice = 0.85;
                strCalorie = 280;
                choPrice = 1;
                choCalorie = 400;

                pieceLem = (int)numericUpDown1.Value;
                pieceBan = (int)numericUpDown2.Value;
                pieceStr = (int)numericUpDown3.Value;
                pieceCho = (int)numericUpDown4.Value;
            }

            totalcalorie = (pieceLem * lemCalorie) + (pieceBan * banCalorie) + (pieceStr * strCalorie) + (pieceCho * choCalorie);
            totalprice = (pieceLem * lemPrice) + (pieceBan * banPrice) + (pieceStr * strPrice) + (pieceCho * choPrice);
            amount = (int)numericUpDown5.Value * totalprice;

            if (radioButton4.Checked)
            {
                totalcalorie += 30;
            }
            else if (radioButton5.Checked)
            {
                totalcalorie += 45;
            }
            else if (radioButton6.Checked)
            {
                totalcalorie += 75;
            }


            textBox5.Text = amount.ToString();
            textBox4.Text = totalcalorie.ToString();
            textBox3.Text = totalprice.ToString();

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedNut = "";
            string selectedItems = "";
            string selectedMilk = "";
            if (radioButton1.Checked)
            {
                selectedMilk += "Diet ";
            }
            if (radioButton2.Checked)
            {
                selectedMilk += "Low Fat Milk";
            }
            if (radioButton3.Checked)
            {
                selectedMilk += "Fat Milk";
            }
            if (radioButton4.Checked)
            {
                selectedNut += "Peanut";
            }
            if (radioButton5.Checked)
            {
                selectedNut += "Hazelnut";
            }
            if (radioButton6.Checked)
            {
                selectedNut += "Pistachio";
            }
            if (checkedListBox1.GetItemChecked(0))
            {
                selectedItems += "Lemon, ";
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                selectedItems += "Banana, ";
            }
            if (checkedListBox1.GetItemChecked(2))
            {
                selectedItems += "Strawberry, ";
            }
            if (checkedListBox1.GetItemChecked(3))
            {
                selectedItems += "Chocolate, ";
            }

            if (!string.IsNullOrEmpty(selectedItems))
            {
                selectedItems = selectedItems.TrimEnd(',', ' ');
                insertitems(selectedMilk, selectedItems, Amnt, selectedNut);
            }
            else
            {
                MessageBox.Show("Please select at least one item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            geneltoplamguncelle();

        }

        private void insertitems(string selectedMilk, string itemName, int Amnt, string selectedNut)
        {

            ListViewItem newitem = new ListViewItem(selectedMilk);
            newitem.SubItems.Add(itemName);
            newitem.SubItems.Add(selectedNut);
            newitem.SubItems.Add(textBox3.Text);
            newitem.SubItems.Add(textBox4.Text);
            newitem.SubItems.Add(numericUpDown5.Value.ToString());
            newitem.SubItems.Add(textBox5.Text);



            button1.Enabled = false;



            listView1.Items.Add(newitem);



        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            listView1.Items.Clear();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.ValueChanged += priceandcalorie;
            numericUpDown2.ValueChanged += priceandcalorie;
            numericUpDown3.ValueChanged += priceandcalorie;
            numericUpDown4.ValueChanged += priceandcalorie;
            numericUpDown5.ValueChanged += priceandcalorie;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }


        }
        private void geneltoplamguncelle()
        {
            decimal grandTotal = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                decimal totalPrice;
                if (decimal.TryParse(item.SubItems[6].Text, out totalPrice))
                {
                    grandTotal += totalPrice;
                }
            }

            textBox6.Text = grandTotal.ToString("0.00");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            geneltoplamguncelle();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}
