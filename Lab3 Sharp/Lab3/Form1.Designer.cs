namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.allPat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.averLoad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.dynam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число дней";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(418, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 755);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // allPat
            // 
            chartArea5.Name = "ChartArea1";
            this.allPat.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.allPat.Legends.Add(legend5);
            this.allPat.Location = new System.Drawing.Point(415, 137);
            this.allPat.Name = "allPat";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.MediumSeaGreen;
            series8.Legend = "Legend1";
            series8.Name = "dt";
            series8.YValuesPerPoint = 2;
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.Gold;
            series9.Legend = "Legend1";
            series9.Name = "Спец. состояния";
            this.allPat.Series.Add(series8);
            this.allPat.Series.Add(series9);
            this.allPat.Size = new System.Drawing.Size(300, 300);
            this.allPat.TabIndex = 8;
            this.allPat.Text = "chart1";
            // 
            // averTime
            // 
            chartArea6.Name = "ChartArea1";
            this.averTime.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.averTime.Legends.Add(legend6);
            this.averTime.Location = new System.Drawing.Point(737, 137);
            this.averTime.Name = "averTime";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.MediumSeaGreen;
            series10.Legend = "Legend1";
            series10.Name = "dt";
            series10.YValuesPerPoint = 2;
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.Gold;
            series11.Legend = "Legend1";
            series11.Name = "Спец. состояния";
            this.averTime.Series.Add(series10);
            this.averTime.Series.Add(series11);
            this.averTime.Size = new System.Drawing.Size(300, 300);
            this.averTime.TabIndex = 9;
            this.averTime.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Число пациентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Среднее время пребывания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Средняя загрузка палаты";
            // 
            // averLoad
            // 
            chartArea7.Name = "ChartArea1";
            this.averLoad.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.averLoad.Legends.Add(legend7);
            this.averLoad.Location = new System.Drawing.Point(418, 468);
            this.averLoad.Name = "averLoad";
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.MediumSeaGreen;
            series12.Legend = "Legend1";
            series12.Name = "dt";
            series12.YValuesPerPoint = 2;
            series13.ChartArea = "ChartArea1";
            series13.Color = System.Drawing.Color.Gold;
            series13.Legend = "Legend1";
            series13.Name = "Спец. состояния";
            this.averLoad.Series.Add(series12);
            this.averLoad.Series.Add(series13);
            this.averLoad.Size = new System.Drawing.Size(300, 300);
            this.averLoad.TabIndex = 12;
            this.averLoad.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Динамика больных в палате";
            // 
            // dynam
            // 
            chartArea8.Name = "ChartArea1";
            this.dynam.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.dynam.Legends.Add(legend8);
            this.dynam.Location = new System.Drawing.Point(737, 468);
            this.dynam.Name = "dynam";
            series14.ChartArea = "ChartArea1";
            series14.Color = System.Drawing.Color.MediumSeaGreen;
            series14.Legend = "Legend1";
            series14.Name = "dt";
            series14.YValuesPerPoint = 2;
            this.dynam.Series.Add(series14);
            this.dynam.Size = new System.Drawing.Size(300, 300);
            this.dynam.TabIndex = 14;
            this.dynam.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 779);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dynam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.averLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.averTime);
            this.Controls.Add(this.allPat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart allPat;
        private System.Windows.Forms.DataVisualization.Charting.Chart averTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart averLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart dynam;
    }
}

