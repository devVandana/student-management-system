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
    
    public partial class Form4 : Form
    {
        private Form3 form3;


        public Form4(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;

        }
        private void btnform1_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void btndiscn_Click(object sender, EventArgs e)
        {
            lbxcn.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (tbxcn.Text == "")
            {
                MessageBox.Show("please fill the value");
            }
            else
            {
                if (!Store.dictionary_c.ContainsKey(tbxcn.Text))
                {
                    MessageBox.Show("course name does not exist");
                }
                else
                {
                  

                    Courses c1 = Store.dictionary_c[tbxcn.Text]; ;
                    lbxcn.Items.Add("CID: "+tbxcn.Text + " - Duration: " + c1.duration + " - Faculty ID: " + c1.faculty_id + " - No. of Books: " + c1.no_of_books + " - Type: " + c1.type);
                    if (c1.faculty_id < 1)
                    {
                        listBox2.Items.Add("Not Assigned");
                    }
                    else
                    {
                        Faculty fn = Store.dictionary_f[c1.faculty_id];
                        listBox2.Items.Add(fn.Name);
                    }
                    if (Courses.students.Count <1)
                    {
                        listBox1.Text = "*List is Empty";
                    }
                    else
                    {
                        Courses.students.Sort();
                        foreach (string item in Courses.students)
                        {
                            listBox1.Items.Add(item);

                        }

                    }

                    tbxcn.Clear();

                }


            }
            


        }
    }
}
