namespace Project_1
{
    partial class Form4
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
            this.btnform1 = new System.Windows.Forms.Button();
            this.lblcn = new System.Windows.Forms.Label();
            this.tbxcn = new System.Windows.Forms.TextBox();
            this.lbxcn = new System.Windows.Forms.ListBox();
            this.btndiscn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnform1
            // 
            this.btnform1.Location = new System.Drawing.Point(655, 406);
            this.btnform1.Margin = new System.Windows.Forms.Padding(2);
            this.btnform1.Name = "btnform1";
            this.btnform1.Size = new System.Drawing.Size(112, 34);
            this.btnform1.TabIndex = 0;
            this.btnform1.Text = "form3";
            this.btnform1.UseVisualStyleBackColor = true;
            this.btnform1.Click += new System.EventHandler(this.btnform1_Click);
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.Location = new System.Drawing.Point(59, 32);
            this.lblcn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(119, 25);
            this.lblcn.TabIndex = 1;
            this.lblcn.Text = "Course Name";
            // 
            // tbxcn
            // 
            this.tbxcn.Location = new System.Drawing.Point(41, 72);
            this.tbxcn.Margin = new System.Windows.Forms.Padding(2);
            this.tbxcn.Name = "tbxcn";
            this.tbxcn.Size = new System.Drawing.Size(150, 31);
            this.tbxcn.TabIndex = 2;
            // 
            // lbxcn
            // 
            this.lbxcn.FormattingEnabled = true;
            this.lbxcn.ItemHeight = 25;
            this.lbxcn.Location = new System.Drawing.Point(41, 171);
            this.lbxcn.Margin = new System.Windows.Forms.Padding(2);
            this.lbxcn.Name = "lbxcn";
            this.lbxcn.Size = new System.Drawing.Size(653, 79);
            this.lbxcn.TabIndex = 3;
            // 
            // btndiscn
            // 
            this.btndiscn.Location = new System.Drawing.Point(230, 72);
            this.btndiscn.Margin = new System.Windows.Forms.Padding(2);
            this.btndiscn.Name = "btndiscn";
            this.btndiscn.Size = new System.Drawing.Size(172, 34);
            this.btndiscn.TabIndex = 4;
            this.btndiscn.Text = "Display_summary";
            this.btndiscn.UseVisualStyleBackColor = true;
            this.btndiscn.Click += new System.EventHandler(this.btndiscn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 296);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 104);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(366, 296);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(367, 104);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course_details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student_names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Faculty_name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndiscn);
            this.Controls.Add(this.lbxcn);
            this.Controls.Add(this.tbxcn);
            this.Controls.Add(this.lblcn);
            this.Controls.Add(this.btnform1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnform1;
        private Label lblcn;
        private TextBox tbxcn;
        private ListBox lbxcn;
        private Button btndiscn;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Label label3;
      
    }
}