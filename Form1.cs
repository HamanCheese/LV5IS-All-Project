using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Project_Charlie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool buttonwasclicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in panel1.Controls)
            {
                if (ctl is ComboBox)
                        
                {
                    int find = ctl.Name.ToString().IndexOf("_required", 0);
                    if (find > 0 && ctl.Text == "")
                    {
                        ctl.BackColor = Color.Red;
                        ErrorMessage.Text = "Mandatory Field Should Be filled";
                        ErrorMessage.ForeColor = Color.Red;
                        ErrorMessage.Visible = true;
                    }
                    else
                    {

                        ctl.BackColor = Color.White;
                        ErrorMessage.Text = "Please Fill In All The required Areas";
                        ErrorMessage.ForeColor = Color.Green;
                        ErrorMessage.Visible = true;

                    }
                    {
                        if (ValidateChildren(ValidationConstraints.Enabled))
                        {
                            MessageBox.Show("Missing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (buttonwasclicked == false)
                         {
                            MessageBox.Show("Please Click The Button");
                        }
                        

                            listBox1.Items.Add("Name: " + txtFname.Text + " " + txtLname.Text);
                            listBox1.Items.Add("Mobile Number: " + txtmobile_required.Text);
                            listBox1.Items.Add("Hours: " + numericUpDown1.Value + " " + numericUpDown2.Value);
                            listBox1.Items.Add("Meeting With: " + comboBox.SelectedItem);
                            listBox1.Items.Add("Date: " + dateTimePicker.Value);
                        
                    }
                }
            }



        }



        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.radioButton1.Checked == true)
                    button2.Text = f2.radioButton1.Text;
                else if (f2.radioButton2.Checked == true)
                    button2.Text = f2.radioButton2.Text;
                else if (f2.radioButton3.Checked == true)
                    button2.Text = f2.radioButton3.Text;
                else if (f2.radioButton4.Checked == true)
                    button2.Text = f2.radioButton4.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFname_required_TextChanged(object sender, EventArgs e)
        {
           
        }
       
        private void txtfname_required_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                char chr = e.KeyChar;
                if (!char.IsLetter(chr) && chr != 8)
                {
                    e.Handled = true;
                    MessageBox.Show("Please Enter A vaild Name");
                }
            
        }
        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {

            char chr = e.KeyChar;
            if (!char.IsLetter(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A vaild Name");
            }

        }

        private void txtmobile_required_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A vaild Mobile Number");
            }

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtmobile_required.Clear();
            txtemail.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            comboBox.Text = "Select Any";
            button2.Text = "Meeting Aim";
            dateTimePicker.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove("Name: " + txtFname.Text + " " + txtLname.Text);
            listBox1.Items.Remove("Mobile Number: " + txtmobile_required.Text);
            listBox1.Items.Remove("Hours: " + numericUpDown1.Value + " " + numericUpDown2.Value);
            listBox1.Items.Remove("Meeting With: " + comboBox.SelectedItem);
            listBox1.Items.Remove("Date: " + dateTimePicker.Value);
        }

        //private void txtemail_required_Leave(object sender, EventArgs e)
        //{
        //string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        //if (Regex.IsMatch(txtemail_required.Text,pattern))

        //{
        //errorProvider.Clear();
    }
            //else
            //{
                //errorProvider.SetError(this.txtemail_required, "Please Provide A Valid Email Adress");
               // return;
            }
//}
//}
//}




//notes
//if(textbox1.text=="")
//{ messagebox.show("Fisrt Name");
//}
//textbox1.backcolr=color.red;
//textbox1.focus();
//else if (int.tryparse(textbox2.text,out num)==false) {textbox1.backcolor = color.white;}
//int num = 0;
//messagebox.show("Enter Digits Only");
//textbox2.backcolr=color.green;
//else if
//{textbox2.backcolr==colr.blue;}
//else if numeric updawn.value=0
//messagebox.show("Please enter the hour time");

//important

//else if(combobox1.selectedIndex==-1)
//{messagebox.show("Please select any item");}


//buttonwasclicked = true;
//else if (buttonwasclicked == false)
//messagebox.show("Please click the button");
//

//
//
//
//
//
//
//
//
//
//
//
//
//
//
//