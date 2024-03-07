namespace ProgramFiles
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
            this.MainCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.rdSalad = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdPizza = new System.Windows.Forms.RadioButton();
            this.rdHamburger = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbHandburger = new System.Windows.Forms.GroupBox();
            this.cbItemsThree = new System.Windows.Forms.CheckBox();
            this.cbItemsTwo = new System.Windows.Forms.CheckBox();
            this.cbItemsOne = new System.Windows.Forms.CheckBox();
            this.gbPizza = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.gbSalad = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainCourseGroupBox.SuspendLayout();
            this.gbHandburger.SuspendLayout();
            this.gbPizza.SuspendLayout();
            this.gbSalad.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainCourseGroupBox
            // 
            this.MainCourseGroupBox.Controls.Add(this.rdSalad);
            this.MainCourseGroupBox.Controls.Add(this.radioButton3);
            this.MainCourseGroupBox.Controls.Add(this.rdPizza);
            this.MainCourseGroupBox.Controls.Add(this.rdHamburger);
            this.MainCourseGroupBox.Location = new System.Drawing.Point(25, 31);
            this.MainCourseGroupBox.Name = "MainCourseGroupBox";
            this.MainCourseGroupBox.Size = new System.Drawing.Size(184, 122);
            this.MainCourseGroupBox.TabIndex = 0;
            this.MainCourseGroupBox.TabStop = false;
            this.MainCourseGroupBox.Text = "Main Course";
            this.MainCourseGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdSalad
            // 
            this.rdSalad.AutoSize = true;
            this.rdSalad.Location = new System.Drawing.Point(22, 83);
            this.rdSalad.Name = "rdSalad";
            this.rdSalad.Size = new System.Drawing.Size(85, 17);
            this.rdSalad.TabIndex = 2;
            this.rdSalad.TabStop = true;
            this.rdSalad.Text = "Salad- $4.95";
            this.rdSalad.UseVisualStyleBackColor = true;
            this.rdSalad.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdPizza
            // 
            this.rdPizza.AutoSize = true;
            this.rdPizza.Location = new System.Drawing.Point(21, 50);
            this.rdPizza.Name = "rdPizza";
            this.rdPizza.Size = new System.Drawing.Size(86, 17);
            this.rdPizza.TabIndex = 1;
            this.rdPizza.TabStop = true;
            this.rdPizza.Text = "Pizza - $5.95";
            this.rdPizza.UseVisualStyleBackColor = true;
            this.rdPizza.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // rdHamburger
            // 
            this.rdHamburger.AutoSize = true;
            this.rdHamburger.Location = new System.Drawing.Point(22, 19);
            this.rdHamburger.Name = "rdHamburger";
            this.rdHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdHamburger.TabIndex = 0;
            this.rdHamburger.TabStop = true;
            this.rdHamburger.Text = "Hamburger - $6.95";
            this.rdHamburger.UseVisualStyleBackColor = true;
            this.rdHamburger.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // gbHandburger
            // 
            this.gbHandburger.Controls.Add(this.cbItemsThree);
            this.gbHandburger.Controls.Add(this.cbItemsTwo);
            this.gbHandburger.Controls.Add(this.cbItemsOne);
            this.gbHandburger.Location = new System.Drawing.Point(249, 31);
            this.gbHandburger.Name = "gbHandburger";
            this.gbHandburger.Size = new System.Drawing.Size(218, 122);
            this.gbHandburger.TabIndex = 1;
            this.gbHandburger.TabStop = false;
            this.gbHandburger.Text = "Add-on-items ($.75/each)";
            // 
            // cbItemsThree
            // 
            this.cbItemsThree.AutoSize = true;
            this.cbItemsThree.Location = new System.Drawing.Point(19, 83);
            this.cbItemsThree.Name = "cbItemsThree";
            this.cbItemsThree.Size = new System.Drawing.Size(81, 17);
            this.cbItemsThree.TabIndex = 2;
            this.cbItemsThree.Text = "French fries";
            this.cbItemsThree.UseVisualStyleBackColor = true;
            this.cbItemsThree.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbItemsTwo
            // 
            this.cbItemsTwo.AutoSize = true;
            this.cbItemsTwo.Location = new System.Drawing.Point(19, 50);
            this.cbItemsTwo.Name = "cbItemsTwo";
            this.cbItemsTwo.Size = new System.Drawing.Size(162, 17);
            this.cbItemsTwo.TabIndex = 1;
            this.cbItemsTwo.Text = "Ketchup, Mustard, and mayo";
            this.cbItemsTwo.UseVisualStyleBackColor = true;
            // 
            // cbItemsOne
            // 
            this.cbItemsOne.AutoSize = true;
            this.cbItemsOne.Location = new System.Drawing.Point(19, 19);
            this.cbItemsOne.Name = "cbItemsOne";
            this.cbItemsOne.Size = new System.Drawing.Size(158, 17);
            this.cbItemsOne.TabIndex = 0;
            this.cbItemsOne.Text = "Lettuce, tomato, and onions";
            this.cbItemsOne.UseVisualStyleBackColor = true;
            // 
            // gbPizza
            // 
            this.gbPizza.Controls.Add(this.checkBox1);
            this.gbPizza.Controls.Add(this.checkBox2);
            this.gbPizza.Controls.Add(this.checkBox3);
            this.gbPizza.Location = new System.Drawing.Point(249, 31);
            this.gbPizza.Name = "gbPizza";
            this.gbPizza.Size = new System.Drawing.Size(218, 122);
            this.gbPizza.TabIndex = 3;
            this.gbPizza.TabStop = false;
            this.gbPizza.Text = "Add-on-items ($.50/each)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Olives";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Sausage";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Pepperoni";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // gbSalad
            // 
            this.gbSalad.Controls.Add(this.checkBox4);
            this.gbSalad.Controls.Add(this.checkBox5);
            this.gbSalad.Controls.Add(this.checkBox6);
            this.gbSalad.Location = new System.Drawing.Point(249, 31);
            this.gbSalad.Name = "gbSalad";
            this.gbSalad.Size = new System.Drawing.Size(218, 122);
            this.gbSalad.TabIndex = 4;
            this.gbSalad.TabStop = false;
            this.gbSalad.Text = "Add-on-items ($.25/each)";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(19, 83);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(84, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Bread sticks";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 50);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(76, 17);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "Bacon bits";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(68, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Croutons";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSalad);
            this.Controls.Add(this.gbPizza);
            this.Controls.Add(this.gbHandburger);
            this.Controls.Add(this.MainCourseGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainCourseGroupBox.ResumeLayout(false);
            this.MainCourseGroupBox.PerformLayout();
            this.gbHandburger.ResumeLayout(false);
            this.gbHandburger.PerformLayout();
            this.gbPizza.ResumeLayout(false);
            this.gbPizza.PerformLayout();
            this.gbSalad.ResumeLayout(false);
            this.gbSalad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainCourseGroupBox;
        private System.Windows.Forms.RadioButton rdSalad;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdPizza;
        private System.Windows.Forms.RadioButton rdHamburger;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbHandburger;
        private System.Windows.Forms.CheckBox cbItemsThree;
        private System.Windows.Forms.CheckBox cbItemsTwo;
        private System.Windows.Forms.CheckBox cbItemsOne;
        private System.Windows.Forms.GroupBox gbPizza;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox gbSalad;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label1;
    }
}

