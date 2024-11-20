namespace BT_20_11_NET
{
    partial class ThongKe
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
            dtgvThongKe = new DataGridView();
            cbMonthlyStatistics = new ComboBox();
            label1 = new Label();
            btnShowStatistics = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // dtgvThongKe
            // 
            dtgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThongKe.Location = new Point(12, 12);
            dtgvThongKe.Name = "dtgvThongKe";
            dtgvThongKe.RowHeadersWidth = 51;
            dtgvThongKe.Size = new Size(776, 249);
            dtgvThongKe.TabIndex = 0;
            // 
            // cbMonthlyStatistics
            // 
            cbMonthlyStatistics.FormattingEnabled = true;
            cbMonthlyStatistics.Location = new Point(158, 284);
            cbMonthlyStatistics.Name = "cbMonthlyStatistics";
            cbMonthlyStatistics.Size = new Size(245, 28);
            cbMonthlyStatistics.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 287);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 2;
            label1.Text = "Monthly statistics";
            // 
            // btnShowStatistics
            // 
            btnShowStatistics.Location = new Point(264, 361);
            btnShowStatistics.Name = "btnShowStatistics";
            btnShowStatistics.Size = new Size(268, 40);
            btnShowStatistics.TabIndex = 3;
            btnShowStatistics.Text = "Show Statistics";
            btnShowStatistics.UseVisualStyleBackColor = true;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowStatistics);
            Controls.Add(label1);
            Controls.Add(cbMonthlyStatistics);
            Controls.Add(dtgvThongKe);
            Name = "ThongKe";
            Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)dtgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvThongKe;
        private ComboBox cbMonthlyStatistics;
        private Label label1;
        private Button btnShowStatistics;
    }
}