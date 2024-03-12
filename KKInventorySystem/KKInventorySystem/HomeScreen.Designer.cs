namespace KKInventorySystem
{
    partial class HomeScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnPartsDelete = new System.Windows.Forms.Button();
            this.btnPartsEdit = new System.Windows.Forms.Button();
            this.btnPartsAdd = new System.Windows.Forms.Button();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.btnPartsSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProductsDelete = new System.Windows.Forms.Button();
            this.btnProductsEdit = new System.Windows.Forms.Button();
            this.btnProductsAdd = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnProductsSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(18, 71);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnPartsDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnPartsEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnPartsAdd);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewParts);
            this.splitContainer1.Panel1.Controls.Add(this.btnPartsSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.Controls.Add(this.btnProductsDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnProductsEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnProductsAdd);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewProducts);
            this.splitContainer1.Panel2.Controls.Add(this.btnProductsSearch);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1348, 622);
            this.splitContainer1.SplitterDistance = 670;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(293, 23);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(241, 44);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // btnPartsDelete
            // 
            this.btnPartsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartsDelete.Location = new System.Drawing.Point(535, 488);
            this.btnPartsDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsDelete.Name = "btnPartsDelete";
            this.btnPartsDelete.Size = new System.Drawing.Size(112, 46);
            this.btnPartsDelete.TabIndex = 6;
            this.btnPartsDelete.Text = "Delete";
            this.btnPartsDelete.UseVisualStyleBackColor = true;
            this.btnPartsDelete.Click += new System.EventHandler(this.btnPartsDelete_Click);
            // 
            // btnPartsEdit
            // 
            this.btnPartsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartsEdit.Location = new System.Drawing.Point(413, 488);
            this.btnPartsEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsEdit.Name = "btnPartsEdit";
            this.btnPartsEdit.Size = new System.Drawing.Size(112, 46);
            this.btnPartsEdit.TabIndex = 5;
            this.btnPartsEdit.Text = "Modify";
            this.btnPartsEdit.UseVisualStyleBackColor = true;
            this.btnPartsEdit.Click += new System.EventHandler(this.btnPartsEdit_Click);
            // 
            // btnPartsAdd
            // 
            this.btnPartsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartsAdd.Location = new System.Drawing.Point(292, 488);
            this.btnPartsAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsAdd.Name = "btnPartsAdd";
            this.btnPartsAdd.Size = new System.Drawing.Size(110, 46);
            this.btnPartsAdd.TabIndex = 4;
            this.btnPartsAdd.Text = "Add";
            this.btnPartsAdd.UseVisualStyleBackColor = true;
            this.btnPartsAdd.Click += new System.EventHandler(this.btnPartsAdd_Click);
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AllowUserToResizeColumns = false;
            this.dataGridViewParts.AllowUserToResizeRows = false;
            this.dataGridViewParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewParts.EnableHeadersVisualStyles = false;
            this.dataGridViewParts.Location = new System.Drawing.Point(28, 94);
            this.dataGridViewParts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewParts.MultiSelect = false;
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParts.RowTemplate.Height = 30;
            this.dataGridViewParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParts.Size = new System.Drawing.Size(622, 361);
            this.dataGridViewParts.TabIndex = 3;
            // 
            // btnPartsSearch
            // 
            this.btnPartsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartsSearch.Location = new System.Drawing.Point(547, 21);
            this.btnPartsSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsSearch.Name = "btnPartsSearch";
            this.btnPartsSearch.Size = new System.Drawing.Size(100, 46);
            this.btnPartsSearch.TabIndex = 1;
            this.btnPartsSearch.Text = "Search";
            this.btnPartsSearch.UseVisualStyleBackColor = true;
            this.btnPartsSearch.Click += new System.EventHandler(this.btnPartsSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parts";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(279, 23);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(241, 44);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(523, 556);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 46);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProductsDelete
            // 
            this.btnProductsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductsDelete.Location = new System.Drawing.Point(523, 488);
            this.btnProductsDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsDelete.Name = "btnProductsDelete";
            this.btnProductsDelete.Size = new System.Drawing.Size(112, 46);
            this.btnProductsDelete.TabIndex = 9;
            this.btnProductsDelete.Text = "Delete";
            this.btnProductsDelete.UseVisualStyleBackColor = true;
            this.btnProductsDelete.Click += new System.EventHandler(this.btnProductsDelete_Click);
            // 
            // btnProductsEdit
            // 
            this.btnProductsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductsEdit.Location = new System.Drawing.Point(401, 488);
            this.btnProductsEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsEdit.Name = "btnProductsEdit";
            this.btnProductsEdit.Size = new System.Drawing.Size(112, 46);
            this.btnProductsEdit.TabIndex = 8;
            this.btnProductsEdit.Text = "Modify";
            this.btnProductsEdit.UseVisualStyleBackColor = true;
            this.btnProductsEdit.Click += new System.EventHandler(this.btnProductsEdit_Click);
            // 
            // btnProductsAdd
            // 
            this.btnProductsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductsAdd.Location = new System.Drawing.Point(279, 488);
            this.btnProductsAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsAdd.Name = "btnProductsAdd";
            this.btnProductsAdd.Size = new System.Drawing.Size(110, 46);
            this.btnProductsAdd.TabIndex = 7;
            this.btnProductsAdd.Text = "Add";
            this.btnProductsAdd.UseVisualStyleBackColor = true;
            this.btnProductsAdd.Click += new System.EventHandler(this.btnProductsAdd_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(27, 94);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(608, 361);
            this.dataGridViewProducts.TabIndex = 5;
            // 
            // btnProductsSearch
            // 
            this.btnProductsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductsSearch.Location = new System.Drawing.Point(533, 21);
            this.btnProductsSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsSearch.Name = "btnProductsSearch";
            this.btnProductsSearch.Size = new System.Drawing.Size(100, 46);
            this.btnProductsSearch.TabIndex = 3;
            this.btnProductsSearch.Text = "Search";
            this.btnProductsSearch.UseVisualStyleBackColor = true;
            this.btnProductsSearch.Click += new System.EventHandler(this.btnProductsSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Products";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeScreen";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPartsSearch;
        private System.Windows.Forms.Button btnProductsSearch;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnPartsDelete;
        private System.Windows.Forms.Button btnPartsEdit;
        private System.Windows.Forms.Button btnPartsAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProductsDelete;
        private System.Windows.Forms.Button btnProductsEdit;
        private System.Windows.Forms.Button btnProductsAdd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

