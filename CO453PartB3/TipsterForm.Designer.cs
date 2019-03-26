namespace CO453PartB3
{
    partial class TipsterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipsterForm));
            this.peopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.billLabel = new System.Windows.Forms.Label();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.tipGroupBox = new System.Windows.Forms.GroupBox();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.generousRadioButton = new System.Windows.Forms.RadioButton();
            this.madRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tipGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleNumericUpDown
            // 
            this.peopleNumericUpDown.Location = new System.Drawing.Point(259, 241);
            this.peopleNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.peopleNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.peopleNumericUpDown.Name = "peopleNumericUpDown";
            this.peopleNumericUpDown.Size = new System.Drawing.Size(71, 32);
            this.peopleNumericUpDown.TabIndex = 0;
            this.peopleNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(50, 46);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(113, 26);
            this.billLabel.TabIndex = 1;
            this.billLabel.Text = "Bill Total £";
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(50, 247);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(185, 26);
            this.peopleLabel.TabIndex = 2;
            this.peopleLabel.Text = "Number of people";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(374, 254);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 41);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateAmount);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(468, 254);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(88, 41);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitForm);
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(174, 40);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(156, 32);
            this.billTextBox.TabIndex = 6;
            this.billTextBox.Text = "100";
            // 
            // tipGroupBox
            // 
            this.tipGroupBox.Controls.Add(this.madRadioButton);
            this.tipGroupBox.Controls.Add(this.generousRadioButton);
            this.tipGroupBox.Controls.Add(this.normalRadioButton);
            this.tipGroupBox.Controls.Add(this.noneRadioButton);
            this.tipGroupBox.Location = new System.Drawing.Point(55, 91);
            this.tipGroupBox.Name = "tipGroupBox";
            this.tipGroupBox.Size = new System.Drawing.Size(275, 137);
            this.tipGroupBox.TabIndex = 7;
            this.tipGroupBox.TabStop = false;
            this.tipGroupBox.Text = "Tip";
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(24, 52);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(78, 30);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "none";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Location = new System.Drawing.Point(161, 52);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(97, 30);
            this.normalRadioButton.TabIndex = 1;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // generousRadioButton
            // 
            this.generousRadioButton.AutoSize = true;
            this.generousRadioButton.Location = new System.Drawing.Point(24, 88);
            this.generousRadioButton.Name = "generousRadioButton";
            this.generousRadioButton.Size = new System.Drawing.Size(120, 30);
            this.generousRadioButton.TabIndex = 2;
            this.generousRadioButton.TabStop = true;
            this.generousRadioButton.Text = "generous";
            this.generousRadioButton.UseVisualStyleBackColor = true;
            // 
            // madRadioButton
            // 
            this.madRadioButton.AutoSize = true;
            this.madRadioButton.Location = new System.Drawing.Point(161, 88);
            this.madRadioButton.Name = "madRadioButton";
            this.madRadioButton.Size = new System.Drawing.Size(73, 30);
            this.madRadioButton.TabIndex = 3;
            this.madRadioButton.TabStop = true;
            this.madRadioButton.Text = "mad";
            this.madRadioButton.UseVisualStyleBackColor = true;
            // 
            // TipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 307);
            this.Controls.Add(this.tipGroupBox);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.peopleLabel);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.peopleNumericUpDown);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TipsterForm";
            this.Text = "Tipster Data Entry";
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tipGroupBox.ResumeLayout(false);
            this.tipGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown peopleNumericUpDown;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.GroupBox tipGroupBox;
        private System.Windows.Forms.RadioButton madRadioButton;
        private System.Windows.Forms.RadioButton generousRadioButton;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
    }
}