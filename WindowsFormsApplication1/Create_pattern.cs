using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Create_pattern : Form
    {
        //public List<Double> list_weight;
        public double[,] list_weight;
        public List<String> list_name;
        Form1 form;
        public String type_patt;

        public Create_pattern(Form1 form)
        {
            int c = 0;

            this.form = form;
            list_weight = new double[20,20];
            type_patt = "";
            list_name = new List<String>();
            InitializeComponent();
            this.textBox1.Text = "24";
            this.panelcheckbox.Location = new Point(50,50);


            for (int i = 0; i < 20; i++)
            {

                for (int j = 0; j < 20; j++)
                {
                    CheckBox checkbox = new CheckBox();
                    checkbox.Name = "checkbox" + c.ToString();
                    checkbox.Text = c.ToString();
                    checkbox.Size = new Size(12,13);
                    checkbox.Location = new Point((j)*25,(i)*25);


                    checkbox.CheckStateChanged += new System.EventHandler(this.checkbox_Click);
                    list_weight[i, j] = 0;
                    list_name.Add(checkbox.Name);

                    c++;

                    this.panelcheckbox.Controls.Add(checkbox);

                    
                }
            }

            for (int i = 0; i < 20; i++)
            {
                Label labi = new Label();
                labi.Location = new Point((i + 2) * 25, 25);
                labi.Size = new Size(20, 20);
                labi.Text = (i + 1).ToString();
                this.Controls.Add(labi);

                Label labj = new Label();
                labj.Location = new Point(25, (i + 2) * 25);
                labj.Size = new Size(20, 20);
                labj.Text = (i + 1).ToString();
                this.Controls.Add(labj);

            }

            
        }


        private void checkbox_Click(object sender, EventArgs e)
        {
            CheckBox che = (CheckBox)sender;

            //MessageBox.Show(che.Name);


            fonction(che, e);
        }

        public void fonction(object sender, EventArgs e)
        {
            CheckBox che = (CheckBox)sender;
            int c = 0;

            
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (list_name[c] == che.Name && che.CheckState == CheckState.Checked)
                    {

                        list_weight[i, j] = 1;
                        //this.Controls[i+1-10].Enabled = false;
                        
                    }

                    else if(list_name[c] == che.Name && che.CheckState == CheckState.Unchecked){
                        list_weight[i,j] = 0;
                    }

                    c++;
                }

                
            }        
        }

        public String get_type()
        {
            return type_patt;
        }

        public double[,] getListWeight()
        {
            return list_weight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.form.labelselpatt.Text = "Selected pattern : " + this.type_patt;
            this.Visible = false;

        }

        private void H_and_S_button_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    if (i == 9 && j == 0 || i == 6 && j == 1 || i == 4 && j == 2 || i == 6 && j == 3 || i == 0 && j == 4 || i == 0 && j == 5 || i == 6 && j == 6 || i == 4 && j == 7 || i == 6 && j == 8 || i == 9 && j == 9)
                    {
                        list_weight[i, j] = 1;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Checked;
                        

                    }
                    else
                    {
                        list_weight[i, j] = 0;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Unchecked;
                    }
                    c++;
                }
            }
            form.labelselpatt.ForeColor = Color.Green;
            type_patt = "Head and shoulders";
        }

        private void inv_H_and_S_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    if (i == 0 && j == 0 || i == 0 && j == 9 || i == 3 && j == 1 || i == 3 && j == 3 || i == 3 && j == 6 || i == 3 && j == 8 || i == 5 && j == 2 || i == 5 && j == 7 || i == 9 && j == 4 || i == 9 && j == 5)
                    {
                        list_weight[i, j] = 1;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        list_weight[i, j] = 0;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Unchecked;
                    }
                    c++;
                }
            }
            type_patt = "Inversed Head and shoulders";
            form.labelselpatt.ForeColor = Color.Green;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {

                        list_weight[i, j] = 0;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Unchecked;
                    
                    c++;
                }
            }
            type_patt = "None";
            form.labelselpatt.ForeColor = Color.Maroon;
        }

        private void diamondbutton_click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    if (i == 0 && j == 5 || i == 1 && j == 3 || i == 2 && j == 1 || i == 2 && j == 7 || i == 5 && j == 0 || i == 5 && j == 9 || i == 7 && j == 8 || i == 8 && j == 2 || i == 8 && j == 6 || i == 9 && j == 4)
                    {
                        list_weight[i, j] = 1;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        list_weight[i, j] = 0;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Unchecked;
                    }
                    c++;
                }
            }
            type_patt = "Diamond";
            form.labelselpatt.ForeColor = Color.Green;
        }

        private void doubletop_button_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    if (i == 0 && j == 2 || i == 0 && j == 7 || i == 3 && j == 3 || i == 3 && j == 6 || i == 5 && j == 1 || i == 5 && j == 4 || i == 5 && j == 5 || i == 5 && j == 8 || i == 9 && j == 0 || i == 9 && j == 9)
                    {
                        list_weight[i, j] = 1;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        list_weight[i, j] = 0;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Unchecked;
                    }
                    c++;
                }
            }

            type_patt = "Double top";
            form.labelselpatt.ForeColor = Color.Green;

        }

        private void inv_doubletop_button_click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {


                    if (i == 0 && j == 0 || i == 0 && j == 9 || i == 4 && j == 1 || i == 4 && j == 4 || i == 4 && j == 5 || i == 4 && j == 8 || i == 6 && j == 3 || i == 6 && j == 6 || i == 9 && j == 2 || i == 9 && j == 7)
                    {
                        list_weight[i, j] = 1;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        list_weight[i, j] = 0;
                        CheckBox checkbox = (CheckBox)this.panelcheckbox.Controls[c];
                        checkbox.CheckState = CheckState.Unchecked;
                    }
                    c++;
                }
            }

            type_patt = "Inversed double top";
            form.labelselpatt.ForeColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.nbHours = int.Parse(this.textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
