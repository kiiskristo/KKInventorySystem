namespace KKInventorySystem
{
    partial class PartForm
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
            this.labelScreen = new System.Windows.Forms.Label();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.radioOutSourced = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.RichTextBox();
            this.txtBoxName = new System.Windows.Forms.RichTextBox();
            this.txtBoxInventory = new System.Windows.Forms.RichTextBox();
            this.txtBoxPrice = new System.Windows.Forms.RichTextBox();
            this.txtBoxMac = new System.Windows.Forms.RichTextBox();
            this.txtBoxDynamic = new System.Windows.Forms.RichTextBox();
            this.txtBoxMin = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScreen
            // 
            this.labelScreen.AutoSize = true;
            this.labelScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScreen.Location = new System.Drawing.Point(24, 20);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(90, 24);
            this.labelScreen.TabIndex = 0;
            this.labelScreen.Text = "Add Part";
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioInHouse.Location = new System.Drawing.Point(162, 20);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(84, 21);
            this.radioInHouse.TabIndex = 1;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-Hound";
            this.radioInHouse.UseVisualStyleBackColor = true;
            // 
            // radioOutSourced
            // 
            this.radioOutSourced.AutoSize = true;
            this.radioOutSourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioOutSourced.Location = new System.Drawing.Point(266, 20);
            this.radioOutSourced.Name = "radioOutSourced";
            this.radioOutSourced.Size = new System.Drawing.Size(100, 21);
            this.radioOutSourced.TabIndex = 2;
            this.radioOutSourced.TabStop = true;
            this.radioOutSourced.Text = "Outsourced";
            this.radioOutSourced.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSave.Location = new System.Drawing.Point(302, 403);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 46);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonCancel.Location = new System.Drawing.Point(397, 403);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 46);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBoxID.Location = new System.Drawing.Point(162, 67);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(204, 34);
            this.txtBoxID.TabIndex = 12;
            this.txtBoxID.Text = "";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBoxName.Location = new System.Drawing.Point(162, 121);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(204, 34);
            this.txtBoxName.TabIndex = 13;
            this.txtBoxName.Text = "";
            // 
            // txtBoxInventory
            // 
            this.txtBoxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBoxInventory.Location = new System.Drawing.Point(162, 172);
            this.txtBoxInventory.Name = "txtBoxInventory";
            this.txtBoxInventory.Size = new System.Drawing.Size(204, 34);
            this.txtBoxInventory.TabIndex = 14;
            this.txtBoxInventory.Text = "";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBoxPrice.Location = new System.Drawing.Point(162, 223);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(204, 34);
            this.txtBoxPrice.TabIndex = 15;
            this.txtBoxPrice.Text = "";
            // 
            // txtBoxMac
            // 
            this.txtBoxMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBoxMac.Location = new System.Drawing.Point(162, 270);
            this.txtBoxMac.Name = "txtBoxMac";
            this.txtBoxMac.Size = new System.Drawing.Size(63, 34);
            this.txtBoxMac.TabIndex = 16;
            this.txtBoxMac.Text = "";
            // 
            // txtBoxDynamic
            // 
            this.txtBoxDynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBoxDynamic.Location = new System.Drawing.Point(161, 320);
            this.txtBoxDynamic.Name = "txtBoxDynamic";
            this.txtBoxDynamic.Size = new System.Drawing.Size(204, 34);
            this.txtBoxDynamic.TabIndex = 17;
            this.txtBoxDynamic.Text = "";
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBoxMin.Location = new System.Drawing.Point(302, 270);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(63, 34);
            this.txtBoxMin.TabIndex = 18;
            this.txtBoxMin.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(249, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(86, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(100, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(73, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(50, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Inventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(28, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Price / Cost";
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDynamic.Location = new System.Drawing.Point(32, 334);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(94, 20);
            this.labelDynamic.TabIndex = 25;
            this.labelDynamic.Text = "Machine ID";
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMin);
            this.Controls.Add(this.txtBoxDynamic);
            this.Controls.Add(this.txtBoxMac);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxInventory);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioOutSourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.labelScreen);
            this.Name = "PartForm";
            this.Text = "PartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.RadioButton radioOutSourced;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RichTextBox txtBoxID;
        private System.Windows.Forms.RichTextBox txtBoxName;
        private System.Windows.Forms.RichTextBox txtBoxInventory;
        private System.Windows.Forms.RichTextBox txtBoxPrice;
        private System.Windows.Forms.RichTextBox txtBoxMac;
        private System.Windows.Forms.RichTextBox txtBoxDynamic;
        private System.Windows.Forms.RichTextBox txtBoxMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDynamic;
    }
}