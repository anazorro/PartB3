namespace CO453PartB3
{
    partial class ListBoxes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxes));
            this.startersGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.totalCostGroupBox = new System.Windows.Forms.GroupBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.mainCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.listMain = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startersGroupBox.SuspendLayout();
            this.totalCostGroupBox.SuspendLayout();
            this.mainCourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startersGroupBox
            // 
            this.startersGroupBox.Controls.Add(this.listBox1);
            this.startersGroupBox.Location = new System.Drawing.Point(35, 25);
            this.startersGroupBox.Name = "startersGroupBox";
            this.startersGroupBox.Size = new System.Drawing.Size(253, 134);
            this.startersGroupBox.TabIndex = 0;
            this.startersGroupBox.TabStop = false;
            this.startersGroupBox.Text = "Starters";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Soup of the Day",
            "Chili Fish Cakes",
            "Mozzarella Sticks"});
            this.listBox1.Location = new System.Drawing.Point(16, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 79);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // totalCostGroupBox
            // 
            this.totalCostGroupBox.Controls.Add(this.costLabel);
            this.totalCostGroupBox.Location = new System.Drawing.Point(459, 233);
            this.totalCostGroupBox.Name = "totalCostGroupBox";
            this.totalCostGroupBox.Size = new System.Drawing.Size(167, 100);
            this.totalCostGroupBox.TabIndex = 1;
            this.totalCostGroupBox.TabStop = false;
            this.totalCostGroupBox.Text = "Total Cost";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(16, 34);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 26);
            this.costLabel.TabIndex = 0;
            // 
            // mainCourseGroupBox
            // 
            this.mainCourseGroupBox.Controls.Add(this.listMain);
            this.mainCourseGroupBox.Location = new System.Drawing.Point(35, 165);
            this.mainCourseGroupBox.Name = "mainCourseGroupBox";
            this.mainCourseGroupBox.Size = new System.Drawing.Size(253, 159);
            this.mainCourseGroupBox.TabIndex = 8;
            this.mainCourseGroupBox.TabStop = false;
            this.mainCourseGroupBox.Text = "Main Course";
            // 
            // listMain
            // 
            this.listMain.FormattingEnabled = true;
            this.listMain.ItemHeight = 25;
            this.listMain.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.listMain.Location = new System.Drawing.Point(16, 31);
            this.listMain.Name = "listMain";
            this.listMain.Size = new System.Drawing.Size(208, 104);
            this.listMain.Sorted = true;
            this.listMain.TabIndex = 0;
            this.listMain.SelectedIndexChanged += new System.EventHandler(this.listMain_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(523, 362);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(103, 40);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ice Cream",
            "Souffle"});
            this.comboBox1.Location = new System.Drawing.Point(35, 362);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "<Select Dessert>";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desserts";
            // 
            // ListBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(674, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainCourseGroupBox);
            this.Controls.Add(this.totalCostGroupBox);
            this.Controls.Add(this.startersGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListBoxes";
            this.Text = "Posh Nosher Menu Selection";
            this.startersGroupBox.ResumeLayout(false);
            this.totalCostGroupBox.ResumeLayout(false);
            this.totalCostGroupBox.PerformLayout();
            this.mainCourseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox startersGroupBox;
        private System.Windows.Forms.GroupBox totalCostGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.GroupBox mainCourseGroupBox;
        private System.Windows.Forms.ListBox listMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}