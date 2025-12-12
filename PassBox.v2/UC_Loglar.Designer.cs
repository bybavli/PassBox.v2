namespace PassBox.v2
{
    partial class UC_Loglar
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gridLoglar = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLoglar).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnTemizle);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(980, 63);
            guna2Panel1.TabIndex = 0;
            // 
            // btnTemizle
            // 
            btnTemizle.BorderRadius = 20;
            btnTemizle.CustomizableEdges = customizableEdges1;
            btnTemizle.DisabledState.BorderColor = Color.DarkGray;
            btnTemizle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTemizle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTemizle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTemizle.FillColor = Color.FromArgb(0, 200, 83);
            btnTemizle.Font = new Font("Segoe UI", 9F);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(670, 0);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnTemizle.Size = new Size(307, 60);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "ESKİ LOGLARI TEMİZLE";
            btnTemizle.Click += btnTemizle_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.ForeColor = SystemColors.ActiveBorder;
            guna2HtmlLabel1.Location = new Point(3, 8);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(382, 52);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "GÜVENLİK KAYITLARI";
            // 
            // gridLoglar
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 48, 52);
            gridLoglar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridLoglar.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 16, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridLoglar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridLoglar.ColumnHeadersHeight = 4;
            gridLoglar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(114, 117, 119);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridLoglar.DefaultCellStyle = dataGridViewCellStyle3;
            gridLoglar.GridColor = Color.FromArgb(50, 56, 62);
            gridLoglar.Location = new Point(0, 60);
            gridLoglar.Name = "gridLoglar";
            gridLoglar.RowHeadersVisible = false;
            gridLoglar.RowHeadersWidth = 72;
            gridLoglar.Size = new Size(977, 687);
            gridLoglar.TabIndex = 1;
            gridLoglar.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            gridLoglar.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(44, 48, 52);
            gridLoglar.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridLoglar.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridLoglar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridLoglar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridLoglar.ThemeStyle.BackColor = Color.FromArgb(30, 30, 30);
            gridLoglar.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            gridLoglar.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(15, 16, 18);
            gridLoglar.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridLoglar.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridLoglar.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridLoglar.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridLoglar.ThemeStyle.HeaderStyle.Height = 4;
            gridLoglar.ThemeStyle.ReadOnly = false;
            gridLoglar.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(33, 37, 41);
            gridLoglar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridLoglar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridLoglar.ThemeStyle.RowsStyle.ForeColor = Color.White;
            gridLoglar.ThemeStyle.RowsStyle.Height = 37;
            gridLoglar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(114, 117, 119);
            gridLoglar.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // UC_Loglar
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            Controls.Add(gridLoglar);
            Controls.Add(guna2Panel1);
            Name = "UC_Loglar";
            Size = new Size(980, 750);
            Load += UC_Loglar_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridLoglar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView gridLoglar;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
    }
}
