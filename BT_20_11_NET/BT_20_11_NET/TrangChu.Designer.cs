namespace BT_20_11_NET
{
    partial class TrangChu
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnstrSP = new ToolStripMenuItem();
            mnstrKH = new ToolStripMenuItem();
            mnstrDH = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 200);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnstrSP, mnstrKH, mnstrDH });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnstrSP
            // 
            mnstrSP.Name = "mnstrSP";
            mnstrSP.Size = new Size(158, 24);
            mnstrSP.Text = "Danh mục sản phẩm";
            mnstrSP.Click += mnstrSP_Click;
            // 
            // mnstrKH
            // 
            mnstrKH.Name = "mnstrKH";
            mnstrKH.Size = new Size(169, 24);
            mnstrKH.Text = "Danh mục khách hàng";
            mnstrKH.Click += mnstrKH_Click;
            // 
            // mnstrDH
            // 
            mnstrDH.Name = "mnstrDH";
            mnstrDH.Size = new Size(88, 24);
            mnstrDH.Text = "Đơn hàng";
            mnstrDH.Click += mnstrDH_Click;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TrangChu";
            Text = "TrangChu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnstrSP;
        private ToolStripMenuItem mnstrKH;
        private ToolStripMenuItem mnstrDH;
    }
}