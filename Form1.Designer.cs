namespace CNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxPlates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSideSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRadius = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDiscrete = new System.Windows.Forms.ComboBox();
            this.numericPasses = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericAllowance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonGenerateCP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSideSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAllowance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPlates
            // 
            this.comboBoxPlates.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxPlates.FormattingEnabled = true;
            this.comboBoxPlates.Location = new System.Drawing.Point(0, 0);
            this.comboBoxPlates.Name = "comboBoxPlates";
            this.comboBoxPlates.Size = new System.Drawing.Size(350, 21);
            this.comboBoxPlates.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер стороны";
            // 
            // numericSideSize
            // 
            this.numericSideSize.DecimalPlaces = 3;
            this.numericSideSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericSideSize.Location = new System.Drawing.Point(98, 26);
            this.numericSideSize.Name = "numericSideSize";
            this.numericSideSize.Size = new System.Drawing.Size(72, 20);
            this.numericSideSize.TabIndex = 2;
            this.numericSideSize.Value = new decimal(new int[] {
            567,
            0,
            0,
            131072});
            // 
            // comboBoxRadius
            // 
            this.comboBoxRadius.FormattingEnabled = true;
            this.comboBoxRadius.Location = new System.Drawing.Point(98, 53);
            this.comboBoxRadius.Name = "comboBoxRadius";
            this.comboBoxRadius.Size = new System.Drawing.Size(72, 21);
            this.comboBoxRadius.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Радиус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дискретность";
            // 
            // comboBoxDiscrete
            // 
            this.comboBoxDiscrete.FormattingEnabled = true;
            this.comboBoxDiscrete.Location = new System.Drawing.Point(274, 25);
            this.comboBoxDiscrete.Name = "comboBoxDiscrete";
            this.comboBoxDiscrete.Size = new System.Drawing.Size(72, 21);
            this.comboBoxDiscrete.TabIndex = 5;
            // 
            // numericPasses
            // 
            this.numericPasses.Location = new System.Drawing.Point(98, 80);
            this.numericPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPasses.Name = "numericPasses";
            this.numericPasses.Size = new System.Drawing.Size(72, 20);
            this.numericPasses.TabIndex = 8;
            this.numericPasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Число проходов";
            // 
            // numericAllowance
            // 
            this.numericAllowance.DecimalPlaces = 2;
            this.numericAllowance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericAllowance.Location = new System.Drawing.Point(274, 54);
            this.numericAllowance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAllowance.Name = "numericAllowance";
            this.numericAllowance.Size = new System.Drawing.Size(72, 20);
            this.numericAllowance.TabIndex = 10;
            this.numericAllowance.Value = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 56);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 101);
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
            this.numericA.Location = new System.Drawing.Point(29, 66);
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
            this.numericA.Size = new System.Drawing.Size(114, 20);
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
            this.label8.Location = new System.Drawing.Point(6, 68);
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
            this.numericZ.Location = new System.Drawing.Point(29, 40);
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
            this.numericZ.Size = new System.Drawing.Size(114, 20);
            this.numericZ.TabIndex = 14;
            this.numericZ.Value = new decimal(new int[] {
            34676789,
            0,
            0,
            393216});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
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
            this.numericX.Location = new System.Drawing.Point(29, 14);
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
            this.numericX.Size = new System.Drawing.Size(114, 20);
            this.numericX.TabIndex = 13;
            this.numericX.Value = new decimal(new int[] {
            234,
            0,
            0,
            196608});
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(179, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Выхаживание";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateCP
            // 
            this.buttonGenerateCP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGenerateCP.Location = new System.Drawing.Point(0, 224);
            this.buttonGenerateCP.Name = "buttonGenerateCP";
            this.buttonGenerateCP.Size = new System.Drawing.Size(350, 30);
            this.buttonGenerateCP.TabIndex = 13;
            this.buttonGenerateCP.Text = "Создать УП";
            this.buttonGenerateCP.UseVisualStyleBackColor = true;
            this.buttonGenerateCP.Click += new System.EventHandler(this.buttonGenerateCP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 254);
            this.Controls.Add(this.buttonGenerateCP);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericAllowance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericPasses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDiscrete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRadius);
            this.Controls.Add(this.numericSideSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Пост-процессор ЧПУ";
            ((System.ComponentModel.ISupportInitialize)(this.numericSideSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAllowance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSideSize;
        private System.Windows.Forms.ComboBox comboBoxRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDiscrete;
        private System.Windows.Forms.NumericUpDown numericPasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericAllowance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGenerateCP;
    }
}

