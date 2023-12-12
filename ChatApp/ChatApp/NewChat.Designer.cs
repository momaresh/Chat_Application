namespace ChatApp
{
    partial class NewChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewChat));
            this.all_users_panel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.copy_panel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.copy_picture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.copy_about_label = new Guna.UI.WinForms.GunaLabel();
            this.copy_user_name_label = new Guna.UI.WinForms.GunaLabel();
            this.all_users_panel.SuspendLayout();
            this.copy_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copy_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // all_users_panel
            // 
            this.all_users_panel.AutoScroll = true;
            this.all_users_panel.BackColor = System.Drawing.Color.Transparent;
            this.all_users_panel.Controls.Add(this.copy_panel);
            this.all_users_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all_users_panel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.all_users_panel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.all_users_panel.Location = new System.Drawing.Point(0, 0);
            this.all_users_panel.MaximumSize = new System.Drawing.Size(393, 748);
            this.all_users_panel.Name = "all_users_panel";
            this.all_users_panel.Size = new System.Drawing.Size(354, 748);
            this.all_users_panel.TabIndex = 0;
            // 
            // copy_panel
            // 
            this.copy_panel.BackColor = System.Drawing.Color.Transparent;
            this.copy_panel.Controls.Add(this.copy_picture);
            this.copy_panel.Controls.Add(this.copy_about_label);
            this.copy_panel.Controls.Add(this.copy_user_name_label);
            this.copy_panel.GradientColor1 = System.Drawing.Color.White;
            this.copy_panel.GradientColor2 = System.Drawing.Color.White;
            this.copy_panel.Location = new System.Drawing.Point(17, 28);
            this.copy_panel.Name = "copy_panel";
            this.copy_panel.Radius = 25;
            this.copy_panel.Size = new System.Drawing.Size(319, 68);
            this.copy_panel.TabIndex = 6;
            this.copy_panel.Visible = false;
            // 
            // copy_picture
            // 
            this.copy_picture.BaseColor = System.Drawing.Color.White;
            this.copy_picture.Image = ((System.Drawing.Image)(resources.GetObject("copy_picture.Image")));
            this.copy_picture.Location = new System.Drawing.Point(5, 4);
            this.copy_picture.Name = "copy_picture";
            this.copy_picture.Size = new System.Drawing.Size(68, 60);
            this.copy_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copy_picture.TabIndex = 0;
            this.copy_picture.TabStop = false;
            this.copy_picture.UseTransfarantBackground = false;
            // 
            // copy_about_label
            // 
            this.copy_about_label.AutoSize = true;
            this.copy_about_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.copy_about_label.ForeColor = System.Drawing.Color.DimGray;
            this.copy_about_label.Location = new System.Drawing.Point(81, 41);
            this.copy_about_label.Name = "copy_about_label";
            this.copy_about_label.Size = new System.Drawing.Size(50, 20);
            this.copy_about_label.TabIndex = 4;
            this.copy_about_label.Text = "about";
            // 
            // copy_user_name_label
            // 
            this.copy_user_name_label.AutoSize = true;
            this.copy_user_name_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.copy_user_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.copy_user_name_label.Location = new System.Drawing.Point(80, 5);
            this.copy_user_name_label.Name = "copy_user_name_label";
            this.copy_user_name_label.Size = new System.Drawing.Size(104, 25);
            this.copy_user_name_label.TabIndex = 3;
            this.copy_user_name_label.Text = "محمد مارش";
            // 
            // NewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 748);
            this.Controls.Add(this.all_users_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewChat";
            this.Load += new System.EventHandler(this.NewChat_Load);
            this.all_users_panel.ResumeLayout(false);
            this.copy_panel.ResumeLayout(false);
            this.copy_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copy_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel all_users_panel;
        private Guna.UI.WinForms.GunaGradient2Panel copy_panel;
        private Guna.UI.WinForms.GunaCirclePictureBox copy_picture;
        private Guna.UI.WinForms.GunaLabel copy_about_label;
        private Guna.UI.WinForms.GunaLabel copy_user_name_label;
    }
}