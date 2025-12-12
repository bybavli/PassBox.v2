namespace PassBox.v2
{
    partial class UC_Sifrelerim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            txtArama = new Guna.UI2.WinForms.Guna2TextBox();
            btnYeniEkle = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gridSifreler = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            şİFREYİKOPYALAToolStripMenuItem = new ToolStripMenuItem();
            kULLANICIADINIKOPYALAToolStripMenuItem = new ToolStripMenuItem();
            vERİYİSİLToolStripMenuItem = new ToolStripMenuItem();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSifreler).BeginInit();
            cmsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(txtArama);
            guna2Panel1.Controls.Add(btnYeniEkle);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(980, 60);
            guna2Panel1.TabIndex = 0;
            // 
            // txtArama
            // 
            txtArama.BorderRadius = 20;
            txtArama.CustomizableEdges = customizableEdges1;
            txtArama.DefaultText = "";
            txtArama.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtArama.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtArama.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtArama.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtArama.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtArama.Font = new Font("Segoe UI", 9F);
            txtArama.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtArama.Location = new Point(303, 6);
            txtArama.Margin = new Padding(5, 6, 5, 6);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Platform veya Kullanıcı Ara";
            txtArama.SelectedText = "";
            txtArama.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtArama.Size = new Size(392, 51);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.BorderRadius = 20;
            btnYeniEkle.CustomizableEdges = customizableEdges3;
            btnYeniEkle.DisabledState.BorderColor = Color.DarkGray;
            btnYeniEkle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnYeniEkle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnYeniEkle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnYeniEkle.FillColor = Color.FromArgb(0, 200, 83);
            btnYeniEkle.Font = new Font("Segoe UI", 9F);
            btnYeniEkle.ForeColor = Color.White;
            btnYeniEkle.Location = new Point(768, 0);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnYeniEkle.Size = new Size(209, 60);
            btnYeniEkle.TabIndex = 1;
            btnYeniEkle.Text = "YENİ ŞİFRE EKLE";
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonFace;
            guna2HtmlLabel1.Location = new Point(3, 5);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(193, 52);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "ŞİFRELERİM";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // gridSifreler
            // 
            gridSifreler.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 48, 52);
            gridSifreler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridSifreler.BackgroundColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 16, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridSifreler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridSifreler.ColumnHeadersHeight = 4;
            gridSifreler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridSifreler.ContextMenuStrip = cmsMenu;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(114, 117, 119);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridSifreler.DefaultCellStyle = dataGridViewCellStyle3;
            gridSifreler.Dock = DockStyle.Fill;
            gridSifreler.GridColor = Color.FromArgb(50, 56, 62);
            gridSifreler.Location = new Point(0, 60);
            gridSifreler.Name = "gridSifreler";
            gridSifreler.ReadOnly = true;
            gridSifreler.RowHeadersVisible = false;
            gridSifreler.RowHeadersWidth = 72;
            gridSifreler.Size = new Size(980, 690);
            gridSifreler.TabIndex = 1;
            gridSifreler.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            gridSifreler.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(44, 48, 52);
            gridSifreler.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridSifreler.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridSifreler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridSifreler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridSifreler.ThemeStyle.BackColor = Color.FromArgb(35, 35, 35);
            gridSifreler.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            gridSifreler.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(15, 16, 18);
            gridSifreler.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridSifreler.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridSifreler.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridSifreler.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridSifreler.ThemeStyle.HeaderStyle.Height = 4;
            gridSifreler.ThemeStyle.ReadOnly = true;
            gridSifreler.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(33, 37, 41);
            gridSifreler.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridSifreler.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridSifreler.ThemeStyle.RowsStyle.ForeColor = Color.White;
            gridSifreler.ThemeStyle.RowsStyle.Height = 37;
            gridSifreler.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(114, 117, 119);
            gridSifreler.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // cmsMenu
            // 
            cmsMenu.ImageScalingSize = new Size(28, 28);
            cmsMenu.Items.AddRange(new ToolStripItem[] { şİFREYİKOPYALAToolStripMenuItem, kULLANICIADINIKOPYALAToolStripMenuItem, vERİYİSİLToolStripMenuItem });
            cmsMenu.Name = "guna2ContextMenuStrip1";
            cmsMenu.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cmsMenu.RenderStyle.BorderColor = Color.Gainsboro;
            cmsMenu.RenderStyle.ColorTable = null;
            cmsMenu.RenderStyle.RoundedEdges = true;
            cmsMenu.RenderStyle.SelectionArrowColor = Color.White;
            cmsMenu.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cmsMenu.RenderStyle.SelectionForeColor = Color.White;
            cmsMenu.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsMenu.Size = new Size(346, 112);
            // 
            // şİFREYİKOPYALAToolStripMenuItem
            // 
            şİFREYİKOPYALAToolStripMenuItem.Name = "şİFREYİKOPYALAToolStripMenuItem";
            şİFREYİKOPYALAToolStripMenuItem.Size = new Size(345, 36);
            şİFREYİKOPYALAToolStripMenuItem.Text = "ŞİFREYİ KOPYALA";
            şİFREYİKOPYALAToolStripMenuItem.Click += şİFREYİKOPYALAToolStripMenuItem_Click;
            // 
            // kULLANICIADINIKOPYALAToolStripMenuItem
            // 
            kULLANICIADINIKOPYALAToolStripMenuItem.Name = "kULLANICIADINIKOPYALAToolStripMenuItem";
            kULLANICIADINIKOPYALAToolStripMenuItem.Size = new Size(345, 36);
            kULLANICIADINIKOPYALAToolStripMenuItem.Text = "KULLANICI ADINI KOPYALA";
            kULLANICIADINIKOPYALAToolStripMenuItem.Click += kULLANICIADINIKOPYALAToolStripMenuItem_Click;
            // 
            // vERİYİSİLToolStripMenuItem
            // 
            vERİYİSİLToolStripMenuItem.Name = "vERİYİSİLToolStripMenuItem";
            vERİYİSİLToolStripMenuItem.Size = new Size(345, 36);
            vERİYİSİLToolStripMenuItem.Text = "VERİYİ SİL";
            vERİYİSİLToolStripMenuItem.Click += vERİYİSİLToolStripMenuItem_Click;
            // 
            // UC_Sifrelerim
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            Controls.Add(gridSifreler);
            Controls.Add(guna2Panel1);
            Name = "UC_Sifrelerim";
            Size = new Size(980, 750);
            Load += UC_Sifrelerim_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridSifreler).EndInit();
            cmsMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnYeniEkle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtArama;
        private Guna.UI2.WinForms.Guna2DataGridView gridSifreler;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMenu;
        private ToolStripMenuItem şİFREYİKOPYALAToolStripMenuItem;
        private ToolStripMenuItem kULLANICIADINIKOPYALAToolStripMenuItem;
        private ToolStripMenuItem vERİYİSİLToolStripMenuItem;
    }
}
