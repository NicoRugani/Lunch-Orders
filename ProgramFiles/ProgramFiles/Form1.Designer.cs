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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MainCourseGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.clbAddOnItems.CheckOnClick = true;
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
            this.button1.Location = new System.Drawing.Point(311, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtTax);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(84, 27);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 13;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(84, 59);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(84, 89);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAddOn);
            this.Controls.Add(this.clbAddOnItems);
            this.Controls.Add(this.MainCourseGroupBox);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.MainCourseGroupBox.ResumeLayout(false);
            this.MainCourseGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button button2;
    }
}

