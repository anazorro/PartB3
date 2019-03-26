namespace CO453PartB3
{
    partial class ResultsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalBillTextBox = new System.Windows.Forms.TextBox();
            this.peopleTextBox = new System.Windows.Forms.TextBox();
            this.paymentsLabel = new System.Windows.Forms.Label();
            this.paysTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.peopleTextBox);
            this.groupBox1.Controls.Add(this.totalBillTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.totalBillLabel);
            this.groupBox1.Location = new System.Drawing.Point(34, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Details";
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Location = new System.Drawing.Point(27, 52);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(101, 26);
            this.totalBillLabel.TabIndex = 0;
            this.totalBillLabel.Text = "Total Bill:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "People:";
            // 
            // totalBillTextBox
            // 
            this.totalBillTextBox.Enabled = false;
            this.totalBillTextBox.Location = new System.Drawing.Point(152, 46);
            this.totalBillTextBox.Name = "totalBillTextBox";
            this.totalBillTextBox.ReadOnly = true;
            this.totalBillTextBox.Size = new System.Drawing.Size(100, 32);
            this.totalBillTextBox.TabIndex = 2;
            // 
            // peopleTextBox
            // 
            this.peopleTextBox.Enabled = false;
            this.peopleTextBox.Location = new System.Drawing.Point(152, 93);
            this.peopleTextBox.Name = "peopleTextBox";
            this.peopleTextBox.ReadOnly = true;
            this.peopleTextBox.Size = new System.Drawing.Size(100, 32);
            this.peopleTextBox.TabIndex = 3;
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.AutoSize = true;
            this.paymentsLabel.Location = new System.Drawing.Point(34, 201);
            this.paymentsLabel.Name = "paymentsLabel";
            this.paymentsLabel.Size = new System.Drawing.Size(117, 26);
            this.paymentsLabel.TabIndex = 1;
            this.paymentsLabel.Text = "Each Pays";
            // 
            // paysTextBox
            // 
            this.paysTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.paysTextBox.Enabled = false;
            this.paysTextBox.Location = new System.Drawing.Point(186, 198);
            this.paysTextBox.Name = "paysTextBox";
            this.paysTextBox.ReadOnly = true;
            this.paysTextBox.Size = new System.Drawing.Size(127, 32);
            this.paysTextBox.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(385, 193);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(85, 36);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 247);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.paysTextBox);
            this.Controls.Add(this.paymentsLabel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ResultsForm";
            this.Text = "Results Form";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.Label paymentsLabel;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.TextBox peopleTextBox;
        public System.Windows.Forms.TextBox totalBillTextBox;
        public System.Windows.Forms.TextBox paysTextBox;
    }
}