namespace PassBox.v2
{
    partial class UC_Ayarlar
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSifirla = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 27.8571434F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.ForeColor = SystemColors.ActiveBorder;
            guna2HtmlLabel1.Location = new Point(3, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(565, 89);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "SİSTEM YÖNETİMİ";
            // 
            // btnSifirla
            // 
            btnSifirla.BorderRadius = 50;
            btnSifirla.CustomizableEdges = customizableEdges1;
            btnSifirla.DisabledState.BorderColor = Color.DarkGray;
            btnSifirla.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSifirla.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSifirla.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSifirla.FillColor = Color.FromArgb(64, 0, 0);
            btnSifirla.Font = new Font("Segoe UI", 9F);
            btnSifirla.ForeColor = Color.White;
            btnSifirla.Location = new Point(252, 273);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSifirla.Size = new Size(409, 141);
            btnSifirla.TabIndex = 1;
            btnSifirla.Text = "SİSTEMİ SIFIRLA(TOPLU SİLME)";
            btnSifirla.Click += btnSifirla_Click;
            // 
            // UC_Ayarlar
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(btnSifirla);
            Controls.Add(guna2HtmlLabel1);
            Name = "UC_Ayarlar";
            Size = new Size(980, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnSifirla;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
