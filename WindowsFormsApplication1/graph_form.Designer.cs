namespace WindowsFormsApplication1
{
    partial class graph_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graph_form));
            this.panel_chart = new System.Windows.Forms.Panel();
            this.panel_button = new System.Windows.Forms.Panel();
            this.labeltime = new System.Windows.Forms.Label();
            this.label_patt_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_previous_patt = new System.Windows.Forms.Button();
            this.button_next_pattern = new System.Windows.Forms.Button();
            this.labeldezoom = new System.Windows.Forms.Label();
            this.labelzoom = new System.Windows.Forms.Label();
            this.trackBarDezoom = new System.Windows.Forms.TrackBar();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDezoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_chart
            // 
            this.panel_chart.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Gradient_Series___Dark_Green;
            this.panel_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chart.Location = new System.Drawing.Point(0, 0);
            this.panel_chart.MaximumSize = new System.Drawing.Size(613, 461);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(613, 461);
            this.panel_chart.TabIndex = 1;
            this.panel_chart.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_chart_Paint);
            // 
            // panel_button
            // 
            this.panel_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Gradient_Series___Dark_Green;
            this.panel_button.Controls.Add(this.labeltime);
            this.panel_button.Controls.Add(this.label_patt_type);
            this.panel_button.Controls.Add(this.label1);
            this.panel_button.Controls.Add(this.button_previous_patt);
            this.panel_button.Controls.Add(this.button_next_pattern);
            this.panel_button.Controls.Add(this.labeldezoom);
            this.panel_button.Controls.Add(this.labelzoom);
            this.panel_button.Controls.Add(this.trackBarDezoom);
            this.panel_button.Controls.Add(this.trackBarZoom);
            this.panel_button.Controls.Add(this.button2);
            this.panel_button.Controls.Add(this.button1);
            this.panel_button.Location = new System.Drawing.Point(620, 0);
            this.panel_button.MaximumSize = new System.Drawing.Size(164, 461);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(164, 461);
            this.panel_button.TabIndex = 0;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.BackColor = System.Drawing.Color.PaleGreen;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.Green;
            this.labeltime.Location = new System.Drawing.Point(70, 9);
            this.labeltime.MaximumSize = new System.Drawing.Size(90, 0);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(0, 16);
            this.labeltime.TabIndex = 10;
            // 
            // label_patt_type
            // 
            this.label_patt_type.AutoSize = true;
            this.label_patt_type.BackColor = System.Drawing.Color.PaleGreen;
            this.label_patt_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_patt_type.ForeColor = System.Drawing.Color.Green;
            this.label_patt_type.Location = new System.Drawing.Point(13, 416);
            this.label_patt_type.Name = "label_patt_type";
            this.label_patt_type.Size = new System.Drawing.Size(0, 16);
            this.label_patt_type.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(55, 307);
            this.label1.MaximumSize = new System.Drawing.Size(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patterns";
            // 
            // button_previous_patt
            // 
            this.button_previous_patt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_previous_patt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_previous_patt.BackgroundImage")));
            this.button_previous_patt.ForeColor = System.Drawing.SystemColors.Control;
            this.button_previous_patt.Location = new System.Drawing.Point(16, 347);
            this.button_previous_patt.MaximumSize = new System.Drawing.Size(54, 33);
            this.button_previous_patt.Name = "button_previous_patt";
            this.button_previous_patt.Size = new System.Drawing.Size(54, 33);
            this.button_previous_patt.TabIndex = 7;
            this.button_previous_patt.Text = "<-";
            this.button_previous_patt.UseVisualStyleBackColor = false;
            this.button_previous_patt.Visible = false;
            this.button_previous_patt.Click += new System.EventHandler(this.button_previous_patt_Click);
            // 
            // button_next_pattern
            // 
            this.button_next_pattern.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_next_pattern.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_next_pattern.BackgroundImage")));
            this.button_next_pattern.ForeColor = System.Drawing.SystemColors.Control;
            this.button_next_pattern.Location = new System.Drawing.Point(98, 347);
            this.button_next_pattern.MaximumSize = new System.Drawing.Size(54, 33);
            this.button_next_pattern.Name = "button_next_pattern";
            this.button_next_pattern.Size = new System.Drawing.Size(54, 33);
            this.button_next_pattern.TabIndex = 6;
            this.button_next_pattern.Text = "->";
            this.button_next_pattern.UseVisualStyleBackColor = false;
            this.button_next_pattern.Visible = false;
            this.button_next_pattern.Click += new System.EventHandler(this.button_next_pattern_Click);
            // 
            // labeldezoom
            // 
            this.labeldezoom.AutoSize = true;
            this.labeldezoom.Location = new System.Drawing.Point(71, 250);
            this.labeldezoom.Name = "labeldezoom";
            this.labeldezoom.Size = new System.Drawing.Size(18, 13);
            this.labeldezoom.TabIndex = 5;
            this.labeldezoom.Text = "x2";
            this.labeldezoom.Click += new System.EventHandler(this.labeldezoom_Click);
            // 
            // labelzoom
            // 
            this.labelzoom.AutoSize = true;
            this.labelzoom.Location = new System.Drawing.Point(72, 120);
            this.labelzoom.Name = "labelzoom";
            this.labelzoom.Size = new System.Drawing.Size(18, 13);
            this.labelzoom.TabIndex = 4;
            this.labelzoom.Text = "x2";
            // 
            // trackBarDezoom
            // 
            this.trackBarDezoom.BackColor = System.Drawing.Color.ForestGreen;
            this.trackBarDezoom.Location = new System.Drawing.Point(37, 218);
            this.trackBarDezoom.Maximum = 8;
            this.trackBarDezoom.MaximumSize = new System.Drawing.Size(83, 45);
            this.trackBarDezoom.Minimum = 2;
            this.trackBarDezoom.Name = "trackBarDezoom";
            this.trackBarDezoom.Size = new System.Drawing.Size(83, 45);
            this.trackBarDezoom.SmallChange = 2;
            this.trackBarDezoom.TabIndex = 3;
            this.trackBarDezoom.TickFrequency = 2;
            this.trackBarDezoom.Value = 2;
            this.trackBarDezoom.Scroll += new System.EventHandler(this.trackBarDezoom_Scroll);
            this.trackBarDezoom.MouseCaptureChanged += new System.EventHandler(this.trackBarDezoom_MouseCaptureChanged);
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.BackColor = System.Drawing.Color.ForestGreen;
            this.trackBarZoom.Location = new System.Drawing.Point(39, 88);
            this.trackBarZoom.Maximum = 8;
            this.trackBarZoom.MaximumSize = new System.Drawing.Size(83, 45);
            this.trackBarZoom.Minimum = 2;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(83, 45);
            this.trackBarZoom.SmallChange = 2;
            this.trackBarZoom.TabIndex = 2;
            this.trackBarZoom.TickFrequency = 2;
            this.trackBarZoom.Value = 2;
            this.trackBarZoom.MouseCaptureChanged += new System.EventHandler(this.trackBarZoom_MouseCaptureChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Aqua_Dark_Green;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(37, 40);
            this.button2.MaximumSize = new System.Drawing.Size(84, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zoom";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Aqua_Dark_Green;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(37, 170);
            this.button1.MaximumSize = new System.Drawing.Size(84, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dezoom";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graph_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel_chart);
            this.Controls.Add(this.panel_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "graph_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.graph_form_Load);
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDezoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.Label labeldezoom;
        private System.Windows.Forms.Label labelzoom;
        private System.Windows.Forms.TrackBar trackBarDezoom;
        public System.Windows.Forms.Button button_next_pattern;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_previous_patt;
        private System.Windows.Forms.Label label_patt_type;
        private System.Windows.Forms.Label labeltime;
    }
}