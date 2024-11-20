namespace BT_20_11_NET
{
    partial class DonHang
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
            dtgvDonHang = new DataGridView();
            tbSearch = new TextBox();
            btnSearch = new Button();
            tbIDKH = new TextBox();
            panel1 = new Panel();
            tbIDDH = new TextBox();
            label5 = new Label();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            tbSL = new TextBox();
            tbIDSP = new TextBox();
            btAdd = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDonHang).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvDonHang
            // 
            dtgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDonHang.Location = new Point(12, 12);
            dtgvDonHang.Name = "dtgvDonHang";
            dtgvDonHang.RowHeadersWidth = 51;
            dtgvDonHang.Size = new Size(776, 214);
            dtgvDonHang.TabIndex = 0;
            dtgvDonHang.CellClick += dtgvDonHang_CellClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(12, 243);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(209, 27);
            tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 288);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbIDKH
            // 
            tbIDKH.Location = new Point(90, 68);
            tbIDKH.Name = "tbIDKH";
            tbIDKH.Size = new Size(262, 27);
            tbIDKH.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(tbIDDH);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(tbSL);
            panel1.Controls.Add(tbIDSP);
            panel1.Controls.Add(btAdd);
            panel1.Controls.Add(tbIDKH);
            panel1.Location = new Point(307, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 247);
            panel1.TabIndex = 4;
            // 
            // tbIDDH
            // 
            tbIDDH.Location = new Point(90, 23);
            tbIDDH.Name = "tbIDDH";
            tbIDDH.Size = new Size(262, 27);
            tbIDDH.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 26);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 17;
            label5.Text = "ID DH";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(90, 202);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(262, 27);
            dtpDate.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 204);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 15;
            label4.Text = "DATE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 158);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 14;
            label3.Text = "SL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 114);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 13;
            label2.Text = "ID SP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 72);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 12;
            label1.Text = "ID KH";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(384, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(384, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(384, 68);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tbSL
            // 
            tbSL.Location = new Point(90, 155);
            tbSL.Name = "tbSL";
            tbSL.Size = new Size(262, 27);
            tbSL.TabIndex = 7;
            // 
            // tbIDSP
            // 
            tbIDSP.Location = new Point(90, 111);
            tbIDSP.Name = "tbIDSP";
            tbIDSP.Size = new Size(262, 27);
            tbIDSP.TabIndex = 6;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(384, 23);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 5;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(384, 200);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // DonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(dtgvDonHang);
            Name = "DonHang";
            Text = "DonHang";
            ((System.ComponentModel.ISupportInitialize)dtgvDonHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvDonHang;
        private TextBox tbSearch;
        private Button btnSearch;
        private TextBox tbIDKH;
        private Panel panel1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox tbSL;
        private TextBox tbIDSP;
        private Button btAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDate;
        private TextBox tbIDDH;
        private Label label5;
        private Button btnClear;
    }
}