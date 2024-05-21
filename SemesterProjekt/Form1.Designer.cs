namespace SemesterProjekt
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.currTemp1 = new System.Windows.Forms.Label();
            this.currTemp2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.avgTemp2 = new System.Windows.Forms.Label();
            this.avgTemp1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.curTemp1 = new System.Windows.Forms.Label();
            this.curTemp2 = new System.Windows.Forms.Label();
            this.avgTempRoom1 = new System.Windows.Forms.Label();
            this.avgTempRoom2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(560, 63);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1312, 722);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(55, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(449, 444);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(55, 582);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(449, 558);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // currTemp1
            // 
            this.currTemp1.AutoSize = true;
            this.currTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.currTemp1.Location = new System.Drawing.Point(556, 804);
            this.currTemp1.Name = "currTemp1";
            this.currTemp1.Size = new System.Drawing.Size(331, 29);
            this.currTemp1.TabIndex = 5;
            this.currTemp1.Text = "Nuværende tempratur i rum 1:";
            // 
            // currTemp2
            // 
            this.currTemp2.AutoSize = true;
            this.currTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.currTemp2.Location = new System.Drawing.Point(1317, 804);
            this.currTemp2.Name = "currTemp2";
            this.currTemp2.Size = new System.Drawing.Size(331, 29);
            this.currTemp2.TabIndex = 6;
            this.currTemp2.Text = "Nuværende tempratur i rum 2:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.panel1.Location = new System.Drawing.Point(561, 836);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 4);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.panel2.Location = new System.Drawing.Point(1323, 836);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 4);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.panel3.Location = new System.Drawing.Point(563, 898);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 4);
            this.panel3.TabIndex = 10;
            // 
            // avgTemp2
            // 
            this.avgTemp2.AutoSize = true;
            this.avgTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.avgTemp2.Location = new System.Drawing.Point(1317, 866);
            this.avgTemp2.Name = "avgTemp2";
            this.avgTemp2.Size = new System.Drawing.Size(477, 29);
            this.avgTemp2.TabIndex = 9;
            this.avgTemp2.Text = "Gennemsnit af 10 seneste målinger, Rum 2:";
            // 
            // avgTemp1
            // 
            this.avgTemp1.AutoSize = true;
            this.avgTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.avgTemp1.Location = new System.Drawing.Point(556, 866);
            this.avgTemp1.Name = "avgTemp1";
            this.avgTemp1.Size = new System.Drawing.Size(477, 29);
            this.avgTemp1.TabIndex = 8;
            this.avgTemp1.Text = "Gennemsnit af 10 seneste målinger, Rum 1:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.panel4.Location = new System.Drawing.Point(1323, 898);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 4);
            this.panel4.TabIndex = 8;
            // 
            // curTemp1
            // 
            this.curTemp1.AutoSize = true;
            this.curTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.curTemp1.Location = new System.Drawing.Point(960, 804);
            this.curTemp1.Name = "curTemp1";
            this.curTemp1.Size = new System.Drawing.Size(0, 29);
            this.curTemp1.TabIndex = 11;
            // 
            // curTemp2
            // 
            this.curTemp2.AutoSize = true;
            this.curTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.curTemp2.Location = new System.Drawing.Point(1721, 804);
            this.curTemp2.Name = "curTemp2";
            this.curTemp2.Size = new System.Drawing.Size(0, 29);
            this.curTemp2.TabIndex = 12;
            // 
            // avgTempRoom1
            // 
            this.avgTempRoom1.AutoSize = true;
            this.avgTempRoom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.avgTempRoom1.Location = new System.Drawing.Point(972, 866);
            this.avgTempRoom1.Name = "avgTempRoom1";
            this.avgTempRoom1.Size = new System.Drawing.Size(0, 29);
            this.avgTempRoom1.TabIndex = 13;
            // 
            // avgTempRoom2
            // 
            this.avgTempRoom2.AutoSize = true;
            this.avgTempRoom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.avgTempRoom2.Location = new System.Drawing.Point(1733, 866);
            this.avgTempRoom2.Name = "avgTempRoom2";
            this.avgTempRoom2.Size = new System.Drawing.Size(0, 29);
            this.avgTempRoom2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rum 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(156, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rum 2";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "label8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(283, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 29);
            this.label11.TabIndex = 29;
            this.label11.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgTempRoom2);
            this.Controls.Add(this.avgTempRoom1);
            this.Controls.Add(this.curTemp2);
            this.Controls.Add(this.curTemp1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.avgTemp2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.avgTemp1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currTemp2);
            this.Controls.Add(this.currTemp1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label currTemp1;
        private System.Windows.Forms.Label currTemp2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label avgTemp2;
        private System.Windows.Forms.Label avgTemp1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label curTemp1;
        private System.Windows.Forms.Label curTemp2;
        private System.Windows.Forms.Label avgTempRoom1;
        private System.Windows.Forms.Label avgTempRoom2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}

