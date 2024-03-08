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
            this.clbAddOnItems = new System.Windows.Forms.CheckedListBox();
            this.lblAddOn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MainCourseGroupBox.SuspendLayout();
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
            // clbAddOnItems
            // 
            this.clbAddOnItems.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clbAddOnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAddOnItems.FormattingEnabled = true;
            this.clbAddOnItems.Items.AddRange(new object[] {
            "Lettuce, tomato, and onions",
            "Ketchup, mustard, and mayo",
            "French fries"});
            this.clbAddOnItems.Location = new System.Drawing.Point(228, 50);
            this.clbAddOnItems.Name = "clbAddOnItems";
            this.clbAddOnItems.Size = new System.Drawing.Size(268, 100);
            this.clbAddOnItems.TabIndex = 7;
            // 
            // lblAddOn
            // 
            this.lblAddOn.AutoSize = true;
            this.lblAddOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOn.Location = new System.Drawing.Point(225, 34);
            this.lblAddOn.Name = "lblAddOn";
            this.lblAddOn.Size = new System.Drawing.Size(155, 16);
            this.lblAddOn.TabIndex = 8;
            this.lblAddOn.Text = "Add-on items ($.75/each)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAddOn);
            this.Controls.Add(this.clbAddOnItems);
            this.Controls.Add(this.MainCourseGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainCourseGroupBox.ResumeLayout(false);
            this.MainCourseGroupBox.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox clbAddOnItems;
        private System.Windows.Forms.Label lblAddOn;
        private System.Windows.Forms.Button button1;
    }
}

