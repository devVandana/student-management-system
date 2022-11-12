using Microsoft.VisualBasic.Devices;
using System.Collections;
using System.Diagnostics;

namespace Project_1
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btnAdds_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="" || textBox4.Text=="" || textBoxr.Text == "")
            {
                MessageBox.Show("please enter values");
            }
            else if (Store.dictionary_s.ContainsKey(Int32.Parse(textBox1.Text)))
            {
                MessageBox.Show("Already exist");

            }
            else
            {
                Store.dictionary_s.Add(Int32.Parse(textBox1.Text), new Student(textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text), textBoxr.Text));
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBoxr.Clear();
            }
        }

        private void btnrmvS_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!Store.dictionary_s.ContainsKey(Int32.Parse(textBox1.Text)))
            {
                MessageBox.Show("Key does not exists");

            }
            else
            {
                Student s1 = Store.dictionary_s[Int32.Parse(textBox1.Text)];
                s1.courses.Remove(textBox2.Text);
                Store.dictionary_s.Remove(Int32.Parse(textBox1.Text));
                textBox1.Clear();

            }
        }

        private void btnclrS_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Store.dictionary_s.Clear();
        }

        private void btndisS_Click(object sender, EventArgs e)
            
        {
            listBox1.Items.Clear();

            if (Store.dictionary_s.Count < 1)
            {
                listBox1.Items.Add("list is empty");
            }
            else
            {
                foreach (KeyValuePair<int, Student> kvp in Store.dictionary_s)
                {
                    Student s1 = kvp.Value;
                    listBox1.Items.Add("SID: " + kvp.Key + " - Name: " + s1.Name + " \n" +"- Age: " + s1.Age + " - Gender: " + s1.Gender + " - Region: " + s1.Region);
                }
            }
        }

        private void btnaddF_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBoxFID.Text == "" || textBoxNF.Text == "" || textBoxGF.Text == "" || textBoxAF.Text == "" || textBoxEF.Text == "")
            {
                MessageBox.Show("please enter values");
            }
            else if (Store.dictionary_f.ContainsKey(Int32.Parse(textBoxFID.Text)))
            {
                MessageBox.Show("Already exist");
            }
            else
            {
                Store.dictionary_f.Add(Int32.Parse(textBoxFID.Text), new Faculty(textBoxNF.Text, textBoxGF.Text, Int32.Parse(textBoxAF.Text), textBoxEF.Text));
                textBoxFID.Clear();
                textBoxNF.Clear();
                textBoxGF.Clear();
                textBoxAF.Clear();
                textBoxEF.Clear();
            }
        }

        private void btnrmvf_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!Store.dictionary_f.ContainsKey(Int32.Parse(textBoxFID.Text)))
            {
                MessageBox.Show("Key does not exists");

            }
            else
            {
                Courses c1 = Store.dictionary_c[textBoxFID.Text];
                c1.faculty_id = 0;
                Store.dictionary_f.Remove(Int32.Parse(textBoxFID.Text));
                textBox1.Clear();

            }
        }

        private void btnclrf_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Store.dictionary_f.Clear();
            
        }

        private void btndisf_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (Store.dictionary_f.Count < 1)
            {
                listBox1.Items.Add("list is empty");
            }
            else
            {
                foreach (KeyValuePair<int, Faculty> kvp in Store.dictionary_f)
                {
                    Faculty f1 = kvp.Value;
                    listBox1.Items.Add("FID: " + kvp.Key + " - Name: " + f1.Name + "\n" +" - Age: " + f1.Age + " - Gender: " + f1.Gender + " - Expertise: " + f1.Expertise);
                }
            }
        }

        private void btnaddc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBoxCN.Text == "" || textBoxCD.Text == "" || textBoxNOB.Text == "" || textBoxT.Text == "")
            {
                MessageBox.Show("please enter values");
            }
            else if (Store.dictionary_c.ContainsKey(textBoxCN.Text))
            {
                MessageBox.Show("Already exist");
            }
            else
            {
                Store.dictionary_c.Add(textBoxCN.Text, new Courses(Int32.Parse(textBoxCD.Text), Int32.Parse(textBoxNOB.Text), textBoxT.Text));
                textBoxCN.Clear();
                textBoxCD.Clear();
                textBoxNOB.Clear();
                textBoxT.Clear();
            }
        }
        private void btnrmvc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!Store.dictionary_c.ContainsKey(textBoxCN.Text))
            {
                MessageBox.Show("Key does not exists");

            }
            else
            {
                Store.dictionary_c.Remove(textBoxCN.Text);
                textBox1.Clear();

            }
        }

        private void btnclrc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Store.dictionary_c.Clear();

        }

        private void btndisc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (KeyValuePair<string, Courses> kvp in Store.dictionary_c)
            {
                Courses f1 = kvp.Value;
                listBox1.Items.Add("Course Name: "+kvp.Key + " - Duration: " + f1.duration + "\n" +" - No. of Books: " + f1.no_of_books + " - Type:" + f1.type);
            }
        }
    }
}