namespace CNC
{
    partial class PlateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlateForm));
            this.comboBoxPlates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSideSize = new System.Windows.Forms.NumericUpDown();
            this.cbRadius = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDiscrete = new System.Windows.Forms.ComboBox();
            this.numPasses = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numAllowance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkFinishing = new System.Windows.Forms.CheckBox();
            this.buttonGenerateCP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numPlateExit = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SketchBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSideSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlateExit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPlates
            // 
            this.comboBoxPlates.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxPlates.FormattingEnabled = true;
            this.comboBoxPlates.Location = new System.Drawing.Point(0, 0);
            this.comboBoxPlates.Name = "comboBoxPlates";
            this.comboBoxPlates.Size = new System.Drawing.Size(424, 21);
            this.comboBoxPlates.TabIndex = 0;
            this.comboBoxPlates.SelectedIndexChanged += new System.EventHandler(this.plateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер стороны";
            // 
            // numSideSize
            // 
            this.numSideSize.DecimalPlaces = 3;
            this.numSideSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numSideSize.Location = new System.Drawing.Point(104, 14);
            this.numSideSize.Name = "numSideSize";
            this.numSideSize.Size = new System.Drawing.Size(72, 20);
            this.numSideSize.TabIndex = 2;
            this.numSideSize.Value = new decimal(new int[] {
            567,
            0,
            0,
            131072});
            // 
            // cbRadius
            // 
            this.cbRadius.FormattingEnabled = true;
            this.cbRadius.Location = new System.Drawing.Point(104, 41);
            this.cbRadius.Name = "cbRadius";
            this.cbRadius.Size = new System.Drawing.Size(72, 21);
            this.cbRadius.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Радиус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дискретность";
            // 
            // cbDiscrete
            // 
            this.cbDiscrete.FormattingEnabled = true;
            this.cbDiscrete.Location = new System.Drawing.Point(316, 40);
            this.cbDiscrete.Name = "cbDiscrete";
            this.cbDiscrete.Size = new System.Drawing.Size(72, 21);
            this.cbDiscrete.TabIndex = 5;
            // 
            // numPasses
            // 
            this.numPasses.Location = new System.Drawing.Point(316, 14);
            this.numPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasses.Name = "numPasses";
            this.numPasses.Size = new System.Drawing.Size(72, 20);
            this.numPasses.TabIndex = 8;
            this.numPasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Число проходов";
            // 
            // numAllowance
            // 
            this.numAllowance.DecimalPlaces = 2;
            this.numAllowance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAllowance.Location = new System.Drawing.Point(104, 68);
            this.numAllowance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAllowance.Name = "numAllowance";
            this.numAllowance.Size = new System.Drawing.Size(72, 20);
            this.numAllowance.TabIndex = 10;
            this.numAllowance.Value = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Припуск";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericZ);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 44);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные координаты";
            // 
            // numericA
            // 
            this.numericA.DecimalPlaces = 3;
            this.numericA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericA.Location = new System.Drawing.Point(207, 14);
            this.numericA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(60, 20);
            this.numericA.TabIndex = 16;
            this.numericA.Value = new decimal(new int[] {
            91234546,
            0,
            0,
            458752});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "A:";
            // 
            // numericZ
            // 
            this.numericZ.DecimalPlaces = 3;
            this.numericZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericZ.Location = new System.Drawing.Point(29, 14);
            this.numericZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericZ.Name = "numericZ";
            this.numericZ.Size = new System.Drawing.Size(60, 20);
            this.numericZ.TabIndex = 14;
            this.numericZ.Value = new decimal(new int[] {
            2023523,
            0,
            0,
            393216});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Z:";
            // 
            // numericX
            // 
            this.numericX.DecimalPlaces = 3;
            this.numericX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericX.Location = new System.Drawing.Point(118, 14);
            this.numericX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(60, 20);
            this.numericX.TabIndex = 13;
            this.numericX.Value = new decimal(new int[] {
            234898,
            0,
            0,
            393216});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "X:";
            // 
            // checkFinishing
            // 
            this.checkFinishing.AutoSize = true;
            this.checkFinishing.Location = new System.Drawing.Point(221, 71);
            this.checkFinishing.Name = "checkFinishing";
            this.checkFinishing.Size = new System.Drawing.Size(96, 17);
            this.checkFinishing.TabIndex = 12;
            this.checkFinishing.Text = "Выхаживание";
            this.checkFinishing.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateCP
            // 
            this.buttonGenerateCP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGenerateCP.Location = new System.Drawing.Point(0, 563);
            this.buttonGenerateCP.Name = "buttonGenerateCP";
            this.buttonGenerateCP.Size = new System.Drawing.Size(424, 30);
            this.buttonGenerateCP.TabIndex = 13;
            this.buttonGenerateCP.Text = "Создать УП";
            this.buttonGenerateCP.UseVisualStyleBackColor = true;
            this.buttonGenerateCP.Click += new System.EventHandler(this.buttonGenerateCP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "мм";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "мм";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "мм";
            // 
            // numPlateExit
            // 
            this.numPlateExit.DecimalPlaces = 2;
            this.numPlateExit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPlateExit.Location = new System.Drawing.Point(104, 96);
            this.numPlateExit.Name = "numPlateExit";
            this.numPlateExit.Size = new System.Drawing.Size(72, 20);
            this.numPlateExit.TabIndex = 18;
            this.numPlateExit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Выход пластины";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "мм";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.numSideSize);
            this.groupBox2.Controls.Add(this.numPlateExit);
            this.groupBox2.Controls.Add(this.cbRadius);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbDiscrete);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numPasses);
            this.groupBox2.Controls.Add(this.checkFinishing);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numAllowance);
            this.groupBox2.Location = new System.Drawing.Point(12, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 127);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SketchBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 348);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Эскиз";
            // 
            // SketchBox
            // 
            this.SketchBox.Location = new System.Drawing.Point(7, 19);
            this.SketchBox.Name = "SketchBox";
            this.SketchBox.Size = new System.Drawing.Size(387, 324);
            this.SketchBox.TabIndex = 0;
            this.SketchBox.TabStop = false;
            // 
            // PlateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 593);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonGenerateCP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxPlates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlateForm";
            this.Text = "Пост-процессор ЧПУ";
            ((System.ComponentModel.ISupportInitialize)(this.numSideSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlateExit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSideSize;
        private System.Windows.Forms.ComboBox cbRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDiscrete;
        private System.Windows.Forms.NumericUpDown numPasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAllowance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkFinishing;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGenerateCP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numPlateExit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox SketchBox;
    }
}

