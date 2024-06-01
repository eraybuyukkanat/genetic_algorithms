namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            functionResults = new ListBox();
            label4 = new Label();
            label7 = new Label();
            populationList = new ListBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(254, 23);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "Population";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 6;
            label2.Text = "Crossover Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 7;
            label3.Text = "Mutation Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 114);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 9;
            label5.Text = "Generation Count";
            // 
            // button1
            // 
            button1.Location = new Point(12, 147);
            button1.Name = "button1";
            button1.Size = new Size(178, 23);
            button1.TabIndex = 10;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 22);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 11;
            // 
            // functionResults
            // 
            functionResults.FormattingEnabled = true;
            functionResults.ItemHeight = 15;
            functionResults.Location = new Point(207, 209);
            functionResults.Name = "functionResults";
            functionResults.Size = new Size(178, 229);
            functionResults.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 191);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 13;
            label4.Text = "Function Results";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 191);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 15;
            label7.Text = "Population Pool";
            // 
            // populationList
            // 
            populationList.FormattingEnabled = true;
            populationList.ItemHeight = 15;
            populationList.Location = new Point(12, 209);
            populationList.Name = "populationList";
            populationList.Size = new Size(178, 229);
            populationList.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(412, 46);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(412, 85);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(412, 109);
            label10.Name = "label10";
            label10.Size = new Size(0, 21);
            label10.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(412, 109);
            label11.Name = "label11";
            label11.Size = new Size(0, 21);
            label11.TabIndex = 19;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(412, 191);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(376, 247);
            chart1.TabIndex = 20;
            chart1.Text = "chart1";
            // 
            // button2
            // 
            button2.Location = new Point(207, 147);
            button2.Name = "button2";
            button2.Size = new Size(178, 23);
            button2.TabIndex = 21;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(chart1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(populationList);
            Controls.Add(label4);
            Controls.Add(functionResults);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Label label6;
        private ListBox functionResults;
        private Label label4;
        private Label label7;
        private ListBox populationList;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button2;
    }
}