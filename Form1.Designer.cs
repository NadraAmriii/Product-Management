
namespace RevisionExamen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsTest = new System.Windows.Forms.ComboBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.dgTest = new System.Windows.Forms.DataGridView();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIND";
            // 
            // lsTest
            // 
            this.lsTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lsTest.FormattingEnabled = true;
            this.lsTest.Location = new System.Drawing.Point(145, 21);
            this.lsTest.Name = "lsTest";
            this.lsTest.Size = new System.Drawing.Size(178, 24);
            this.lsTest.TabIndex = 1;
            this.lsTest.SelectedIndexChanged += new System.EventHandler(this.lsTest_SelectedIndexChanged);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(391, 23);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(146, 22);
            this.txtTest.TabIndex = 2;
            this.txtTest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(553, 24);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(106, 17);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "Lignes Trouvés";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(703, 23);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "OK";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dgTest
            // 
            this.dgTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTest.Location = new System.Drawing.Point(12, 71);
            this.dgTest.MultiSelect = false;
            this.dgTest.Name = "dgTest";
            this.dgTest.ReadOnly = true;
            this.dgTest.RowHeadersWidth = 51;
            this.dgTest.RowTemplate.Height = 24;
            this.dgTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTest.Size = new System.Drawing.Size(776, 292);
            this.dgTest.TabIndex = 5;
            this.dgTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTest_RowEnter);
            this.dgTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTest_CellContentClick);
            this.dgTest.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTest_RowEnter);
            // 
            // txt2
            // 
            this.txt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt2.Location = new System.Drawing.Point(12, 408);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(257, 22);
            this.txt2.TabIndex = 6;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(426, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.Location = new System.Drawing.Point(556, 408);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(690, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.dgTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lsTest);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lsTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dgTest;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}

