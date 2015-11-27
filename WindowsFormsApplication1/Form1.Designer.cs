namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.sel_pattern = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hist_data_button = new System.Windows.Forms.Button();
            this.load_data_live = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.labelhist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.file_name = new System.Windows.Forms.Label();
            this.loadtime = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.save_xml_button = new System.Windows.Forms.Button();
            this.load_xml_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_patdet = new System.Windows.Forms.Label();
            this.labelselpatt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(41, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select a stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.sel_stock_Click);
            // 
            // sel_pattern
            // 
            this.sel_pattern.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sel_pattern.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sel_pattern.BackgroundImage")));
            this.sel_pattern.Enabled = false;
            this.sel_pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_pattern.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sel_pattern.Location = new System.Drawing.Point(709, 88);
            this.sel_pattern.Name = "sel_pattern";
            this.sel_pattern.Size = new System.Drawing.Size(84, 37);
            this.sel_pattern.TabIndex = 3;
            this.sel_pattern.Text = "Graph";
            this.sel_pattern.UseVisualStyleBackColor = false;
            this.sel_pattern.Click += new System.EventHandler(this.sel_pattern_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(211, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.hist_data_button);
            this.groupBox2.Controls.Add(this.load_data_live);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(230, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 145);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel";
            // 
            // hist_data_button
            // 
            this.hist_data_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hist_data_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hist_data_button.BackgroundImage")));
            this.hist_data_button.Enabled = false;
            this.hist_data_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hist_data_button.Location = new System.Drawing.Point(33, 29);
            this.hist_data_button.Name = "hist_data_button";
            this.hist_data_button.Size = new System.Drawing.Size(84, 56);
            this.hist_data_button.TabIndex = 5;
            this.hist_data_button.Text = "Load historical data";
            this.hist_data_button.UseVisualStyleBackColor = false;
            this.hist_data_button.Click += new System.EventHandler(this.load_hist_data_Click);
            // 
            // load_data_live
            // 
            this.load_data_live.BackColor = System.Drawing.SystemColors.ControlDark;
            this.load_data_live.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load_data_live.BackgroundImage")));
            this.load_data_live.Enabled = false;
            this.load_data_live.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.load_data_live.Location = new System.Drawing.Point(33, 91);
            this.load_data_live.Name = "load_data_live";
            this.load_data_live.Size = new System.Drawing.Size(84, 42);
            this.load_data_live.TabIndex = 2;
            this.load_data_live.Text = "Load excel live";
            this.load_data_live.UseVisualStyleBackColor = false;
            this.load_data_live.Click += new System.EventHandler(this.load_data_live_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(780, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 38);
            this.button6.TabIndex = 4;
            this.button6.Text = "Run detection";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.run_detection_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(623, 263);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 37);
            this.button7.TabIndex = 3;
            this.button7.Text = "Create the pattern";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.create_pattern_Click);
            // 
            // labelhist
            // 
            this.labelhist.AutoSize = true;
            this.labelhist.Location = new System.Drawing.Point(227, 186);
            this.labelhist.Name = "labelhist";
            this.labelhist.Size = new System.Drawing.Size(0, 13);
            this.labelhist.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(392, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selected stock : None";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // file_name
            // 
            this.file_name.AutoSize = true;
            this.file_name.BackColor = System.Drawing.Color.PaleGreen;
            this.file_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_name.ForeColor = System.Drawing.Color.Maroon;
            this.file_name.Location = new System.Drawing.Point(405, 186);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(133, 15);
            this.file_name.TabIndex = 10;
            this.file_name.Text = "Selected file : None";
            this.file_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // loadtime
            // 
            this.loadtime.AutoSize = true;
            this.loadtime.BackColor = System.Drawing.Color.PaleGreen;
            this.loadtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadtime.ForeColor = System.Drawing.Color.Green;
            this.loadtime.Location = new System.Drawing.Point(405, 257);
            this.loadtime.Name = "loadtime";
            this.loadtime.Size = new System.Drawing.Size(67, 15);
            this.loadtime.TabIndex = 11;
            this.loadtime.Text = "Loading :";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.PaleGreen;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Green;
            this.time.Location = new System.Drawing.Point(405, 319);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(86, 15);
            this.time.TabIndex = 12;
            this.time.Text = "Time spent :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.save_xml_button);
            this.groupBox3.Controls.Add(this.load_xml_button);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(39, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 145);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML";
            // 
            // save_xml_button
            // 
            this.save_xml_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.save_xml_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_xml_button.BackgroundImage")));
            this.save_xml_button.Enabled = false;
            this.save_xml_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save_xml_button.Location = new System.Drawing.Point(34, 91);
            this.save_xml_button.Name = "save_xml_button";
            this.save_xml_button.Size = new System.Drawing.Size(84, 42);
            this.save_xml_button.TabIndex = 6;
            this.save_xml_button.Text = "Save xml";
            this.save_xml_button.UseVisualStyleBackColor = false;
            this.save_xml_button.Click += new System.EventHandler(this.save_xml_button_Click);
            // 
            // load_xml_button
            // 
            this.load_xml_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.load_xml_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load_xml_button.BackgroundImage")));
            this.load_xml_button.Enabled = false;
            this.load_xml_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.load_xml_button.Location = new System.Drawing.Point(34, 29);
            this.load_xml_button.Name = "load_xml_button";
            this.load_xml_button.Size = new System.Drawing.Size(84, 42);
            this.load_xml_button.TabIndex = 5;
            this.load_xml_button.Text = "Load xml";
            this.load_xml_button.UseVisualStyleBackColor = false;
            this.load_xml_button.Click += new System.EventHandler(this.load_xml_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "1 - Select a stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(163, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "2 - Load a file";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(556, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 370);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox2.Location = new System.Drawing.Point(25, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(504, 3);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(666, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "3 - Draw the graph";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox3.Location = new System.Drawing.Point(574, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(324, 3);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(619, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "4 - Choose the pattern to find !";
            // 
            // label_patdet
            // 
            this.label_patdet.AutoSize = true;
            this.label_patdet.BackColor = System.Drawing.Color.PaleGreen;
            this.label_patdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_patdet.ForeColor = System.Drawing.Color.Green;
            this.label_patdet.Location = new System.Drawing.Point(781, 324);
            this.label_patdet.MaximumSize = new System.Drawing.Size(90, 0);
            this.label_patdet.Name = "label_patdet";
            this.label_patdet.Size = new System.Drawing.Size(0, 16);
            this.label_patdet.TabIndex = 22;
            this.label_patdet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelselpatt
            // 
            this.labelselpatt.AutoSize = true;
            this.labelselpatt.BackColor = System.Drawing.Color.PaleGreen;
            this.labelselpatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelselpatt.ForeColor = System.Drawing.Color.Maroon;
            this.labelselpatt.Location = new System.Drawing.Point(602, 324);
            this.labelselpatt.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelselpatt.Name = "labelselpatt";
            this.labelselpatt.Size = new System.Drawing.Size(120, 30);
            this.labelselpatt.TabIndex = 23;
            this.labelselpatt.Text = "Selected pattern : None";
            this.labelselpatt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fond_vert2__1_;
            this.ClientSize = new System.Drawing.Size(925, 405);
            this.Controls.Add(this.labelselpatt);
            this.Controls.Add(this.label_patdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sel_pattern);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.time);
            this.Controls.Add(this.loadtime);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelhist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pattern Detector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sel_pattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelhist;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label file_name;
        public System.Windows.Forms.Button hist_data_button;
        private System.Windows.Forms.Label loadtime;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button load_xml_button;
        public System.Windows.Forms.Button save_xml_button;
        public System.Windows.Forms.Button load_data_live;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_patdet;
        public System.Windows.Forms.Label labelselpatt;
    }
}

