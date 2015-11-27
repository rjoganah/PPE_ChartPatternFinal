﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class statistiques : Form
    {
        public statistiques(graph_form f)
        {
            InitializeComponent();
            f.TopLevel = false;
            f.Visible = true;
            f.FormBorderStyle = FormBorderStyle.None;


            this.MinimumSize = f.MaximumSize;


            this.MaximumSize = new Size(1200, 640);
            this.WindowState = FormWindowState.Maximized;
            //this.tabControl1.Size = f.Size;
            tabControl1.TabPages[0].Controls.Add(f);
            f.Anchor = (AnchorStyles.Left | AnchorStyles.Top );
            //f.Dock = DockStyle.Fill;
           //
            //f.Size = new Size(500, 400);
            //this.tabPage1.Dock = DockStyle.Fill;
            this.tabPage1.Size = f.Size;
            
            //.Size = new Size(800, 500);
            //tabControl1.TabPages[0].Size = new Size(800, 500);

            this.listView1.Columns.Add("Sum");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void addPattern(string name, double nbPattern, int i)
        {
            if (i == 1)
            {
                ListViewItem newitem = new ListViewItem(new string[] { name, nbPattern.ToString(),"","","" });
                this.listView1.Items.Add(newitem);
            }
            if (i == 2 || i == 3 )
            {
                foreach (ListViewItem item in listView1.Items) //Get all items in listView1.Items
                {

                    if (item.SubItems[0].Text == name) //Continue if i.SubItems[3].Text is equal to  

                        item.SubItems[i].Text = nbPattern.ToString(); //Replace   with No
                        
                    
                }
            }
            if (i == 4)
            {
                foreach (ListViewItem item in listView1.Items) //Get all items in listView1.Items
                {

                    if (item.SubItems[0].Text == name) //Continue if i.SubItems[3].Text is equal to  

                        item.SubItems[i].Text = nbPattern.ToString(); //Replace   with No


                }
            }
             
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statistiques_Load(object sender, EventArgs e)
        {

        }
    }
}
