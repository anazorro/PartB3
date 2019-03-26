namespace CO453PartB3
{
    partial class CurrencyForm
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
            this.poundsLabel = new System.Windows.Forms.Label();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dollarsRadioButton = new System.Windows.Forms.RadioButton();
            this.eurosRadioButton = new System.Windows.Forms.RadioButton();
            this.rupeesRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(38, 107);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(123, 26);
            this.poundsLabel.TabIndex = 0;
            this.poundsLabel.Text = "UK Pounds";
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(227, 107);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(100, 32);
            this.poundsTextBox.TabIndex = 1;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(42, 171);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(88, 26);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(227, 171);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 32);
            this.amountTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rupeesRadioButton);
            this.panel1.Controls.Add(this.eurosRadioButton);
            this.panel1.Controls.Add(this.dollarsRadioButton);
            this.panel1.Location = new System.Drawing.Point(497, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 237);
            this.panel1.TabIndex = 4;
            // 
            // dollarsRadioButton
            // 
            this.dollarsRadioButton.AutoSize = true;
            this.dollarsRadioButton.Location = new System.Drawing.Point(36, 18);
            this.dollarsRadioButton.Name = "dollarsRadioButton";
            this.dollarsRadioButton.Size = new System.Drawing.Size(98, 30);
            this.dollarsRadioButton.TabIndex = 0;
            this.dollarsRadioButton.TabStop = true;
            this.dollarsRadioButton.Text = "Dollars";
            this.dollarsRadioButton.UseVisualStyleBackColor = true;
            this.dollarsRadioButton.CheckedChanged += new System.EventHandler(this.dollarsRadioButton_CheckedChanged);
            // 
            // eurosRadioButton
            // 
            this.eurosRadioButton.AutoSize = true;
            this.eurosRadioButton.Location = new System.Drawing.Point(36, 93);
            this.eurosRadioButton.Name = "eurosRadioButton";
            this.eurosRadioButton.Size = new System.Drawing.Size(87, 30);
            this.eurosRadioButton.TabIndex = 1;
            this.eurosRadioButton.TabStop = true;
            this.eurosRadioButton.Text = "Euros";
            this.eurosRadioButton.UseVisualStyleBackColor = true;
            // 
            // rupeesRadioButton
            // 
            this.rupeesRadioButton.AutoSize = true;
            this.rupeesRadioButton.Location = new System.Drawing.Point(36, 170);
            this.rupeesRadioButton.Name = "rupeesRadioButton";
            this.rupeesRadioButton.Size = new System.Drawing.Size(105, 30);
            this.rupeesRadioButton.TabIndex = 2;
            this.rupeesRadioButton.TabStop = true;
            this.rupeesRadioButton.Text = "Rupees";
            this.rupeesRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Currency Converter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.poundsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CurrencyForm";
            this.Text = "Ana\'s Currency Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rupeesRadioButton;
        private System.Windows.Forms.RadioButton eurosRadioButton;
        private System.Windows.Forms.RadioButton dollarsRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

