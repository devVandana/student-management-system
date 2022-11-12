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

namespace Project_1
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        private Form4 form4;

        public Form3(Form2 form2)
        {
            InitializeComponent();
            form4 = new Form4(this);
            this.form2 = form2;

        }

        private void btnform4_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btnas_Click(object sender, EventArgs e)
        {
            lbxstd.Items.Clear();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill both the values");
            }
            else
            {
                if (!Store.dictionary_c.ContainsKey(textBox2.Text) || !Store.dictionary_s.ContainsKey(Int32.Parse(textBox1.Text)))
                {
                    MessageBox.Show("Key does not exists");

                }
                else
                {
                    Student s1 = Store.dictionary_s[Int32.Parse(textBox1.Text)];

                    if (s1.courses.Contains(textBox2.Text))
                    {
                        MessageBox.Show("*Course already assigned");
                        textBox2.Text = "";
                    }
                    else
                    {
                        s1.courses.Add(textBox2.Text);

                        Courses.students.Add(s1.Name);
                        textBox2.Text = "";
                        MessageBox.Show("Assigned");
                    }
                }
            }

        }
        private void btnuna_Click(object sender, EventArgs e)
        {
            lbxstd.Items.Clear();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill both the values");
            }
            else
            {
                if (!Store.dictionary_c.ContainsKey(textBox2.Text) || !Store.dictionary_s.ContainsKey(Int32.Parse(textBox1.Text)))
                {
                    MessageBox.Show("Key does not exists");
                }
                else
                {
                    Student s1 = Store.dictionary_s[Int32.Parse(textBox1.Text)];
                    if (s1.courses.Contains(textBox2.Text))
                    {
                        s1.courses.Remove(textBox2.Text);
                        textBox2.Text = "";
                        MessageBox.Show("unassigned");
                    }
                    else
                    {
                        textBox2.Clear();
                    }

                }
            }

        }

        private void btndisss_Click(object sender, EventArgs e)
        {
            lbxstd.Items.Clear();
            if (textBox1.Text == "")
            {
                MessageBox.Show("please enter faculty id");
            }
            else
            {
                lbxstd.Items.Clear();
                if (!Store.dictionary_s.ContainsKey(Int32.Parse(textBox1.Text)))
                {
                    MessageBox.Show("Key does not exists");
                }
                else
                {
                    Student s1 = Store.dictionary_s[Int32.Parse(textBox1.Text)];
                    lbxstd.Items.Clear();
                    if (s1.courses.Count < 1)
                    {
                        MessageBox.Show("*List is Empty");
                    }
                    else
                    {
                        s1.courses.Sort();
                        foreach (string item in s1.courses)
                        {
                            lbxstd.Items.Add(item);
                        }
                    }
                }
            }

        }
    }
}
