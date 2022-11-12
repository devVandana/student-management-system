using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_1
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
 

        public Form2(Form1 form1)
        {
            InitializeComponent();
            form3 = new Form3(this);
            this.form1 = form1;
           
           
        }


        private void btnform3_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void btnFrom1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            lbxlist.Items.Clear();
            if (textBoxCNF2.Text == "" || textBoxFIDF2.Text == "")
            {
                MessageBox.Show("Please fill both the values");
            }
            else
            {
                if (!Store.dictionary_c.ContainsKey(textBoxCNF2.Text) || !Store.dictionary_f.ContainsKey(Int32.Parse(textBoxFIDF2.Text)))
                {
                    MessageBox.Show("Key does not exists");
                }
                else
                {
                    Faculty f1 = Store.dictionary_f[Int32.Parse(textBoxFIDF2.Text)];
                    if (f1.courses.Contains(textBoxCNF2.Text))
                    {
                        MessageBox.Show("*Course already assigned");
                        textBoxCNF2.Text = "";
                    }
                    else
                    {

                        f1.courses.Add(textBoxCNF2.Text);
                        Courses c1 = Store.dictionary_c[textBoxCNF2.Text];
                        c1.faculty_id = Int32.Parse(textBoxFIDF2.Text);

                        textBoxCNF2.Text = "";
                        MessageBox.Show("Assigned");
                        textBoxCNF2.Clear();
                        textBoxFIDF2.Clear();
                    }
                }
            }
        }
     
        private void btnun_Click(object sender, EventArgs e)
        {
            lbxlist.Items.Clear();
            if (textBoxCNF2.Text == "" || textBoxFIDF2.Text == "")
            {
                MessageBox.Show("Please fill both the values");
            }
            else
            {
                if (!Store.dictionary_c.ContainsKey(textBoxCNF2.Text) || !Store.dictionary_f.ContainsKey(Int32.Parse(textBoxFIDF2.Text)))
                {
                    MessageBox.Show("Key does not exists");
                }
                else
                {
                    Faculty f1 = Store.dictionary_f[Int32.Parse(textBoxFIDF2.Text)];
                    if (f1.courses.Contains(textBoxCNF2.Text))
                    {
                        f1.courses.Remove(textBoxCNF2.Text);
                        Courses c1 = Store.dictionary_c[textBoxCNF2.Text];
                        c1.faculty_id = 0;
                        textBoxCNF2.Text = "";
                        MessageBox.Show("unassigned");
                        textBoxCNF2.Clear();
                    }
                    else
                    {
                        textBoxCNF2.Clear();
                    }
                }
            }
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            if (textBoxFIDF2.Text == "")
            {
                MessageBox.Show("please enter faculty id");
            }
            else {
                lbxlist.Items.Clear();
                if (!Store.dictionary_f.ContainsKey(Int32.Parse(textBoxFIDF2.Text)))
                {
                    MessageBox.Show("Key does not exists");
                }
                else
                {
                    Faculty f1 = Store.dictionary_f[Int32.Parse(textBoxFIDF2.Text)];
                    lbxlist.Items.Clear();

                    if (f1.courses.Count < 1)
                    {
                        MessageBox.Show("*List is Empty");
                    }
                    else
                    {

                        f1.courses.Sort();
                        foreach (string item in f1.courses)
                        {
                            lbxlist.Items.Add(item);
                        
                        }
                        
                    }
                }
            }
        }
    }
}
