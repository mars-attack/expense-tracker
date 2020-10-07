namespace ExpenseTracker
{
    partial class ExpenseTrackerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseTrackerMain));
            this.AddBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.BudgetBox = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.ExpenseTypeBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.Thistle;
            this.AddBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.ForeColor = System.Drawing.Color.Black;
            this.AddBTN.Location = new System.Drawing.Point(139, 191);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(131, 41);
            this.AddBTN.TabIndex = 6;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.Color.Thistle;
            this.UpdateBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBTN.ForeColor = System.Drawing.Color.Black;
            this.UpdateBTN.Location = new System.Drawing.Point(139, 238);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(131, 45);
            this.UpdateBTN.TabIndex = 8;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // AmountBox
            // 
            this.AmountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountBox.Location = new System.Drawing.Point(139, 103);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(131, 29);
            this.AmountBox.TabIndex = 3;
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemNameBox.Location = new System.Drawing.Point(139, 56);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(131, 29);
            this.ItemNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ClearBTN, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ItemNameBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BudgetBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AmountBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteBTN, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BudgetLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateBTN, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ExpenseTypeBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddBTN, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TypeLabel, 0, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 286);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ClearBTN
            // 
            this.ClearBTN.BackColor = System.Drawing.Color.Thistle;
            this.ClearBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBTN.ForeColor = System.Drawing.Color.Black;
            this.ClearBTN.Location = new System.Drawing.Point(3, 191);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(130, 41);
            this.ClearBTN.TabIndex = 5;
            this.ClearBTN.Text = "Clear Form";
            this.ClearBTN.UseVisualStyleBackColor = false;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // BudgetBox
            // 
            this.BudgetBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BudgetBox.Location = new System.Drawing.Point(139, 9);
            this.BudgetBox.Name = "BudgetBox";
            this.BudgetBox.Size = new System.Drawing.Size(131, 29);
            this.BudgetBox.TabIndex = 1;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.Thistle;
            this.DeleteBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.Color.Black;
            this.DeleteBTN.Location = new System.Drawing.Point(3, 238);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(130, 45);
            this.DeleteBTN.TabIndex = 7;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetLabel.Location = new System.Drawing.Point(35, 12);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(65, 23);
            this.BudgetLabel.TabIndex = 8;
            this.BudgetLabel.Text = "Budget";
            // 
            // ExpenseTypeBox
            // 
            this.ExpenseTypeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpenseTypeBox.FormattingEnabled = true;
            this.ExpenseTypeBox.Location = new System.Drawing.Point(139, 154);
            this.ExpenseTypeBox.Name = "ExpenseTypeBox";
            this.ExpenseTypeBox.Size = new System.Drawing.Size(131, 30);
            this.ExpenseTypeBox.TabIndex = 4;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(44, 153);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(48, 23);
            this.TypeLabel.TabIndex = 13;
            this.TypeLabel.Text = "Type";
            // 
            // summaryBox
            // 
            this.summaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBox.Location = new System.Drawing.Point(41, 381);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.ReadOnly = true;
            this.summaryBox.Size = new System.Drawing.Size(273, 70);
            this.summaryBox.TabIndex = 9;
            this.summaryBox.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 392);
            this.dataGridView1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.Thistle;
            this.SaveBTN.Location = new System.Drawing.Point(118, 404);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(142, 37);
            this.SaveBTN.TabIndex = 12;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(93, 17);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(281, 39);
            this.Header.TabIndex = 13;
            this.Header.Text = "Expense Tracker";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 493);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Header);
            this.tabPage1.Controls.Add(this.summaryBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tracker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.SaveBTN);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExpenseTrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(411, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExpenseTrackerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.TextBox BudgetBox;
        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.RichTextBox summaryBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ExpenseTypeBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

