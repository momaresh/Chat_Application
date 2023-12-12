namespace ChatApp
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this._msmpanel = new Guna.UI.WinForms.GunaPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_chat = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.users_panel = new System.Windows.Forms.Panel();
            this.setting_panel = new System.Windows.Forms.Panel();
            this.save_about = new Guna.UI.WinForms.GunaAdvenceButton();
            this.save_user_name = new Guna.UI.WinForms.GunaAdvenceButton();
            this.setting_phone_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_about = new Guna.UI.WinForms.GunaAdvenceButton();
            this.setting_about = new System.Windows.Forms.TextBox();
            this.edit_user_name = new Guna.UI.WinForms.GunaAdvenceButton();
            this.setting_user_name = new System.Windows.Forms.TextBox();
            this.setting_user_image = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.copy_panel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.copy_counter_btn = new Guna.UI.WinForms.GunaCircleButton();
            this.copy_picture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.copy_time_label = new Guna.UI.WinForms.GunaLabel();
            this.copy_user_name_label = new Guna.UI.WinForms.GunaLabel();
            this.type_of_chat_panel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.setting_check_box = new Guna.UI.WinForms.GunaImageCheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.online_chat = new Guna.UI.WinForms.GunaImageRadioButton();
            this.simple_chat = new Guna.UI.WinForms.GunaImageRadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chat_header_panel = new Guna.UI.WinForms.GunaPanel();
            this.last_appear = new Guna.UI.WinForms.GunaLabel();
            this.header_user_name = new Guna.UI.WinForms.GunaLabel();
            this.header_image = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.message_send_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.message_text_txt = new Guna.UI.WinForms.GunaTextBox();
            this.messages_panel = new System.Windows.Forms.Panel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.message_panel_in_chat = new Guna.UI.WinForms.GunaGradient2Panel();
            this.message_status_in_chat = new Guna.UI.WinForms.GunaLabel();
            this.message_txt_in_chat = new Guna.UI.WinForms.GunaLabel();
            this.message_time_in_chat = new Guna.UI.WinForms.GunaLabel();
            this.message_user_image_in_chat = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.chat_panel = new Guna.UI.WinForms.GunaPanel();
            this.add_new_chat_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this._msmpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.users_panel.SuspendLayout();
            this.setting_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_user_image)).BeginInit();
            this.copy_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copy_picture)).BeginInit();
            this.type_of_chat_panel.SuspendLayout();
            this.chat_header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header_image)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            this.messages_panel.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.message_panel_in_chat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.message_user_image_in_chat)).BeginInit();
            this.chat_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _msmpanel
            // 
            this._msmpanel.AutoScroll = true;
            this._msmpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this._msmpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._msmpanel.Controls.Add(this.panel1);
            this._msmpanel.Controls.Add(this.users_panel);
            this._msmpanel.Controls.Add(this.type_of_chat_panel);
            this._msmpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._msmpanel.Location = new System.Drawing.Point(0, 0);
            this._msmpanel.Name = "_msmpanel";
            this._msmpanel.Size = new System.Drawing.Size(437, 712);
            this._msmpanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_new_chat_btn);
            this.panel1.Controls.Add(this.search_chat);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(43, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 113);
            this.panel1.TabIndex = 6;
            // 
            // search_chat
            // 
            this.search_chat.BackColor = System.Drawing.Color.Transparent;
            this.search_chat.BaseColor = System.Drawing.Color.SteelBlue;
            this.search_chat.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.search_chat.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_chat.FocusedBaseColor = System.Drawing.Color.Black;
            this.search_chat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.search_chat.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.search_chat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_chat.Location = new System.Drawing.Point(19, 53);
            this.search_chat.Multiline = true;
            this.search_chat.Name = "search_chat";
            this.search_chat.PasswordChar = '\0';
            this.search_chat.Radius = 7;
            this.search_chat.SelectedText = "";
            this.search_chat.Size = new System.Drawing.Size(354, 39);
            this.search_chat.TabIndex = 3;
            this.search_chat.TextOffsetX = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(31, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(73, 31);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Chats";
            // 
            // users_panel
            // 
            this.users_panel.AutoScroll = true;
            this.users_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.users_panel.Controls.Add(this.setting_panel);
            this.users_panel.Controls.Add(this.copy_panel);
            this.users_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_panel.Location = new System.Drawing.Point(43, 0);
            this.users_panel.Name = "users_panel";
            this.users_panel.Size = new System.Drawing.Size(392, 710);
            this.users_panel.TabIndex = 5;
            // 
            // setting_panel
            // 
            this.setting_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setting_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.setting_panel.Controls.Add(this.save_about);
            this.setting_panel.Controls.Add(this.save_user_name);
            this.setting_panel.Controls.Add(this.setting_phone_number);
            this.setting_panel.Controls.Add(this.label2);
            this.setting_panel.Controls.Add(this.label1);
            this.setting_panel.Controls.Add(this.edit_about);
            this.setting_panel.Controls.Add(this.setting_about);
            this.setting_panel.Controls.Add(this.edit_user_name);
            this.setting_panel.Controls.Add(this.setting_user_name);
            this.setting_panel.Controls.Add(this.setting_user_image);
            this.setting_panel.Location = new System.Drawing.Point(0, 294);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.Size = new System.Drawing.Size(340, 437);
            this.setting_panel.TabIndex = 6;
            this.setting_panel.Visible = false;
            // 
            // save_about
            // 
            this.save_about.AnimationHoverSpeed = 0.07F;
            this.save_about.AnimationSpeed = 0.03F;
            this.save_about.BackColor = System.Drawing.Color.Transparent;
            this.save_about.BaseColor = System.Drawing.Color.Transparent;
            this.save_about.BorderColor = System.Drawing.Color.Black;
            this.save_about.CheckedBaseColor = System.Drawing.Color.Gray;
            this.save_about.CheckedBorderColor = System.Drawing.Color.Black;
            this.save_about.CheckedForeColor = System.Drawing.Color.White;
            this.save_about.CheckedImage = ((System.Drawing.Image)(resources.GetObject("save_about.CheckedImage")));
            this.save_about.CheckedLineColor = System.Drawing.Color.DimGray;
            this.save_about.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_about.FocusedColor = System.Drawing.Color.Empty;
            this.save_about.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_about.ForeColor = System.Drawing.Color.White;
            this.save_about.Image = ((System.Drawing.Image)(resources.GetObject("save_about.Image")));
            this.save_about.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_about.ImageSize = new System.Drawing.Size(20, 20);
            this.save_about.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.save_about.Location = new System.Drawing.Point(284, 231);
            this.save_about.Name = "save_about";
            this.save_about.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.save_about.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_about.OnHoverForeColor = System.Drawing.Color.White;
            this.save_about.OnHoverImage = null;
            this.save_about.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.save_about.OnPressedColor = System.Drawing.Color.Black;
            this.save_about.Radius = 7;
            this.save_about.Size = new System.Drawing.Size(34, 35);
            this.save_about.TabIndex = 11;
            this.save_about.Visible = false;
            this.save_about.Click += new System.EventHandler(this.save_about_Click);
            // 
            // save_user_name
            // 
            this.save_user_name.AnimationHoverSpeed = 0.07F;
            this.save_user_name.AnimationSpeed = 0.03F;
            this.save_user_name.BackColor = System.Drawing.Color.Transparent;
            this.save_user_name.BaseColor = System.Drawing.Color.Transparent;
            this.save_user_name.BorderColor = System.Drawing.Color.Black;
            this.save_user_name.CheckedBaseColor = System.Drawing.Color.Gray;
            this.save_user_name.CheckedBorderColor = System.Drawing.Color.Black;
            this.save_user_name.CheckedForeColor = System.Drawing.Color.White;
            this.save_user_name.CheckedImage = ((System.Drawing.Image)(resources.GetObject("save_user_name.CheckedImage")));
            this.save_user_name.CheckedLineColor = System.Drawing.Color.DimGray;
            this.save_user_name.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_user_name.FocusedColor = System.Drawing.Color.Empty;
            this.save_user_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_user_name.ForeColor = System.Drawing.Color.White;
            this.save_user_name.Image = ((System.Drawing.Image)(resources.GetObject("save_user_name.Image")));
            this.save_user_name.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save_user_name.ImageSize = new System.Drawing.Size(20, 20);
            this.save_user_name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.save_user_name.Location = new System.Drawing.Point(284, 142);
            this.save_user_name.Name = "save_user_name";
            this.save_user_name.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.save_user_name.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_user_name.OnHoverForeColor = System.Drawing.Color.White;
            this.save_user_name.OnHoverImage = null;
            this.save_user_name.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.save_user_name.OnPressedColor = System.Drawing.Color.Black;
            this.save_user_name.Radius = 7;
            this.save_user_name.Size = new System.Drawing.Size(34, 35);
            this.save_user_name.TabIndex = 10;
            this.save_user_name.Visible = false;
            this.save_user_name.Click += new System.EventHandler(this.save_user_name_Click);
            // 
            // setting_phone_number
            // 
            this.setting_phone_number.AutoSize = true;
            this.setting_phone_number.Font = new System.Drawing.Font("Tahoma", 14F);
            this.setting_phone_number.ForeColor = System.Drawing.SystemColors.Control;
            this.setting_phone_number.Location = new System.Drawing.Point(37, 311);
            this.setting_phone_number.Name = "setting_phone_number";
            this.setting_phone_number.Size = new System.Drawing.Size(92, 29);
            this.setting_phone_number.TabIndex = 9;
            this.setting_phone_number.Text = "phone..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(33, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(37, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "About";
            // 
            // edit_about
            // 
            this.edit_about.AnimationHoverSpeed = 0.07F;
            this.edit_about.AnimationSpeed = 0.03F;
            this.edit_about.BackColor = System.Drawing.Color.Transparent;
            this.edit_about.BaseColor = System.Drawing.Color.Transparent;
            this.edit_about.BorderColor = System.Drawing.Color.Black;
            this.edit_about.CheckedBaseColor = System.Drawing.Color.Gray;
            this.edit_about.CheckedBorderColor = System.Drawing.Color.Black;
            this.edit_about.CheckedForeColor = System.Drawing.Color.White;
            this.edit_about.CheckedImage = ((System.Drawing.Image)(resources.GetObject("edit_about.CheckedImage")));
            this.edit_about.CheckedLineColor = System.Drawing.Color.DimGray;
            this.edit_about.DialogResult = System.Windows.Forms.DialogResult.None;
            this.edit_about.FocusedColor = System.Drawing.Color.Empty;
            this.edit_about.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edit_about.ForeColor = System.Drawing.Color.White;
            this.edit_about.Image = ((System.Drawing.Image)(resources.GetObject("edit_about.Image")));
            this.edit_about.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit_about.ImageSize = new System.Drawing.Size(20, 20);
            this.edit_about.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_about.Location = new System.Drawing.Point(284, 230);
            this.edit_about.Name = "edit_about";
            this.edit_about.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.edit_about.OnHoverBorderColor = System.Drawing.Color.Black;
            this.edit_about.OnHoverForeColor = System.Drawing.Color.White;
            this.edit_about.OnHoverImage = null;
            this.edit_about.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_about.OnPressedColor = System.Drawing.Color.Black;
            this.edit_about.Radius = 7;
            this.edit_about.Size = new System.Drawing.Size(34, 35);
            this.edit_about.TabIndex = 4;
            this.edit_about.Click += new System.EventHandler(this.edit_about_Click);
            // 
            // setting_about
            // 
            this.setting_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.setting_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setting_about.Font = new System.Drawing.Font("Tahoma", 14F);
            this.setting_about.ForeColor = System.Drawing.SystemColors.Window;
            this.setting_about.Location = new System.Drawing.Point(37, 231);
            this.setting_about.Multiline = true;
            this.setting_about.Name = "setting_about";
            this.setting_about.ReadOnly = true;
            this.setting_about.Size = new System.Drawing.Size(230, 34);
            this.setting_about.TabIndex = 3;
            // 
            // edit_user_name
            // 
            this.edit_user_name.AnimationHoverSpeed = 0.07F;
            this.edit_user_name.AnimationSpeed = 0.03F;
            this.edit_user_name.BackColor = System.Drawing.Color.Transparent;
            this.edit_user_name.BaseColor = System.Drawing.Color.Transparent;
            this.edit_user_name.BorderColor = System.Drawing.Color.Black;
            this.edit_user_name.CheckedBaseColor = System.Drawing.Color.Gray;
            this.edit_user_name.CheckedBorderColor = System.Drawing.Color.Black;
            this.edit_user_name.CheckedForeColor = System.Drawing.Color.White;
            this.edit_user_name.CheckedImage = ((System.Drawing.Image)(resources.GetObject("edit_user_name.CheckedImage")));
            this.edit_user_name.CheckedLineColor = System.Drawing.Color.DimGray;
            this.edit_user_name.DialogResult = System.Windows.Forms.DialogResult.None;
            this.edit_user_name.FocusedColor = System.Drawing.Color.Empty;
            this.edit_user_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edit_user_name.ForeColor = System.Drawing.Color.White;
            this.edit_user_name.Image = ((System.Drawing.Image)(resources.GetObject("edit_user_name.Image")));
            this.edit_user_name.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit_user_name.ImageSize = new System.Drawing.Size(20, 20);
            this.edit_user_name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_user_name.Location = new System.Drawing.Point(284, 140);
            this.edit_user_name.Name = "edit_user_name";
            this.edit_user_name.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.edit_user_name.OnHoverBorderColor = System.Drawing.Color.Black;
            this.edit_user_name.OnHoverForeColor = System.Drawing.Color.White;
            this.edit_user_name.OnHoverImage = null;
            this.edit_user_name.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_user_name.OnPressedColor = System.Drawing.Color.Black;
            this.edit_user_name.Radius = 7;
            this.edit_user_name.Size = new System.Drawing.Size(34, 35);
            this.edit_user_name.TabIndex = 2;
            this.edit_user_name.Click += new System.EventHandler(this.edit_user_name_Click);
            // 
            // setting_user_name
            // 
            this.setting_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.setting_user_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setting_user_name.Font = new System.Drawing.Font("Tahoma", 18F);
            this.setting_user_name.ForeColor = System.Drawing.SystemColors.Window;
            this.setting_user_name.Location = new System.Drawing.Point(37, 140);
            this.setting_user_name.Name = "setting_user_name";
            this.setting_user_name.ReadOnly = true;
            this.setting_user_name.Size = new System.Drawing.Size(230, 37);
            this.setting_user_name.TabIndex = 1;
            this.setting_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setting_user_image
            // 
            this.setting_user_image.BaseColor = System.Drawing.Color.White;
            this.setting_user_image.Location = new System.Drawing.Point(90, 3);
            this.setting_user_image.Name = "setting_user_image";
            this.setting_user_image.Size = new System.Drawing.Size(113, 113);
            this.setting_user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setting_user_image.TabIndex = 0;
            this.setting_user_image.TabStop = false;
            this.setting_user_image.UseTransfarantBackground = false;
            // 
            // copy_panel
            // 
            this.copy_panel.BackColor = System.Drawing.Color.Transparent;
            this.copy_panel.Controls.Add(this.copy_counter_btn);
            this.copy_panel.Controls.Add(this.copy_picture);
            this.copy_panel.Controls.Add(this.copy_time_label);
            this.copy_panel.Controls.Add(this.copy_user_name_label);
            this.copy_panel.GradientColor1 = System.Drawing.Color.White;
            this.copy_panel.GradientColor2 = System.Drawing.Color.White;
            this.copy_panel.Location = new System.Drawing.Point(20, 122);
            this.copy_panel.Name = "copy_panel";
            this.copy_panel.Radius = 30;
            this.copy_panel.Size = new System.Drawing.Size(353, 86);
            this.copy_panel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.copy_panel, "hi");
            this.copy_panel.Visible = false;
            // 
            // copy_counter_btn
            // 
            this.copy_counter_btn.AnimationHoverSpeed = 0.07F;
            this.copy_counter_btn.AnimationSpeed = 0.03F;
            this.copy_counter_btn.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.copy_counter_btn.BorderColor = System.Drawing.Color.Black;
            this.copy_counter_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.copy_counter_btn.Enabled = false;
            this.copy_counter_btn.FocusedColor = System.Drawing.Color.Empty;
            this.copy_counter_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.copy_counter_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.copy_counter_btn.Image = null;
            this.copy_counter_btn.ImageSize = new System.Drawing.Size(52, 52);
            this.copy_counter_btn.Location = new System.Drawing.Point(322, 30);
            this.copy_counter_btn.Name = "copy_counter_btn";
            this.copy_counter_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.copy_counter_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.copy_counter_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.copy_counter_btn.OnHoverImage = null;
            this.copy_counter_btn.OnPressedColor = System.Drawing.Color.Black;
            this.copy_counter_btn.Size = new System.Drawing.Size(26, 28);
            this.copy_counter_btn.TabIndex = 3;
            this.copy_counter_btn.Visible = false;
            // 
            // copy_picture
            // 
            this.copy_picture.BaseColor = System.Drawing.Color.White;
            this.copy_picture.Image = ((System.Drawing.Image)(resources.GetObject("copy_picture.Image")));
            this.copy_picture.Location = new System.Drawing.Point(6, 8);
            this.copy_picture.Name = "copy_picture";
            this.copy_picture.Size = new System.Drawing.Size(69, 69);
            this.copy_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copy_picture.TabIndex = 0;
            this.copy_picture.TabStop = false;
            this.copy_picture.UseTransfarantBackground = false;
            // 
            // copy_time_label
            // 
            this.copy_time_label.AutoSize = true;
            this.copy_time_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.copy_time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.copy_time_label.Location = new System.Drawing.Point(262, 4);
            this.copy_time_label.Name = "copy_time_label";
            this.copy_time_label.Size = new System.Drawing.Size(76, 20);
            this.copy_time_label.TabIndex = 4;
            this.copy_time_label.Text = "10:24 PM";
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
            // type_of_chat_panel
            // 
            this.type_of_chat_panel.BackColor = System.Drawing.Color.Transparent;
            this.type_of_chat_panel.Controls.Add(this.setting_check_box);
            this.type_of_chat_panel.Controls.Add(this.flowLayoutPanel1);
            this.type_of_chat_panel.Controls.Add(this.online_chat);
            this.type_of_chat_panel.Controls.Add(this.simple_chat);
            this.type_of_chat_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.type_of_chat_panel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.type_of_chat_panel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.type_of_chat_panel.Location = new System.Drawing.Point(0, 0);
            this.type_of_chat_panel.Name = "type_of_chat_panel";
            this.type_of_chat_panel.Size = new System.Drawing.Size(43, 710);
            this.type_of_chat_panel.TabIndex = 4;
            // 
            // setting_check_box
            // 
            this.setting_check_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_check_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setting_check_box.ImageCheckedOff = null;
            this.setting_check_box.ImageCheckedOn = null;
            this.setting_check_box.ImageSize = new System.Drawing.Size(20, 20);
            this.setting_check_box.Location = new System.Drawing.Point(-1, 664);
            this.setting_check_box.Name = "setting_check_box";
            this.setting_check_box.Size = new System.Drawing.Size(41, 42);
            this.setting_check_box.TabIndex = 7;
            this.setting_check_box.CheckedChanged += new System.EventHandler(this.setting_check_box_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 434);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // online_chat
            // 
            this.online_chat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("online_chat.BackgroundImage")));
            this.online_chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.online_chat.ImageCheckedOff = null;
            this.online_chat.ImageCheckedOn = null;
            this.online_chat.ImageSize = new System.Drawing.Size(20, 20);
            this.online_chat.Location = new System.Drawing.Point(7, 95);
            this.online_chat.Name = "online_chat";
            this.online_chat.Size = new System.Drawing.Size(29, 26);
            this.online_chat.TabIndex = 0;
            this.online_chat.CheckedChanged += new System.EventHandler(this.online_chat_CheckedChanged);
            // 
            // simple_chat
            // 
            this.simple_chat.BackColor = System.Drawing.Color.SteelBlue;
            this.simple_chat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simple_chat.BackgroundImage")));
            this.simple_chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simple_chat.Checked = true;
            this.simple_chat.ImageCheckedOff = null;
            this.simple_chat.ImageCheckedOn = null;
            this.simple_chat.ImageSize = new System.Drawing.Size(20, 20);
            this.simple_chat.Location = new System.Drawing.Point(7, 52);
            this.simple_chat.Name = "simple_chat";
            this.simple_chat.Size = new System.Drawing.Size(29, 26);
            this.simple_chat.TabIndex = 0;
            this.simple_chat.CheckedChanged += new System.EventHandler(this.simple_chat_CheckedChanged);
            // 
            // chat_header_panel
            // 
            this.chat_header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.chat_header_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chat_header_panel.Controls.Add(this.last_appear);
            this.chat_header_panel.Controls.Add(this.header_user_name);
            this.chat_header_panel.Controls.Add(this.header_image);
            this.chat_header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chat_header_panel.Location = new System.Drawing.Point(0, 0);
            this.chat_header_panel.Name = "chat_header_panel";
            this.chat_header_panel.Size = new System.Drawing.Size(952, 66);
            this.chat_header_panel.TabIndex = 0;
            // 
            // last_appear
            // 
            this.last_appear.AutoEllipsis = true;
            this.last_appear.AutoSize = true;
            this.last_appear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.last_appear.ForeColor = System.Drawing.Color.Brown;
            this.last_appear.Location = new System.Drawing.Point(121, 41);
            this.last_appear.Name = "last_appear";
            this.last_appear.Size = new System.Drawing.Size(115, 19);
            this.last_appear.TabIndex = 8;
            this.last_appear.Text = "last appearence";
            // 
            // header_user_name
            // 
            this.header_user_name.AutoSize = true;
            this.header_user_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.header_user_name.ForeColor = System.Drawing.SystemColors.Control;
            this.header_user_name.Location = new System.Drawing.Point(122, 6);
            this.header_user_name.Name = "header_user_name";
            this.header_user_name.Size = new System.Drawing.Size(104, 25);
            this.header_user_name.TabIndex = 5;
            this.header_user_name.Text = "محمد مارش";
            // 
            // header_image
            // 
            this.header_image.BaseColor = System.Drawing.Color.White;
            this.header_image.Image = ((System.Drawing.Image)(resources.GetObject("header_image.Image")));
            this.header_image.Location = new System.Drawing.Point(35, 3);
            this.header_image.Name = "header_image";
            this.header_image.Size = new System.Drawing.Size(62, 55);
            this.header_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.header_image.TabIndex = 5;
            this.header_image.TabStop = false;
            this.header_image.UseTransfarantBackground = false;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.gunaPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel4.Controls.Add(this.message_send_btn);
            this.gunaPanel4.Controls.Add(this.message_text_txt);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 639);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(952, 71);
            this.gunaPanel4.TabIndex = 1;
            // 
            // message_send_btn
            // 
            this.message_send_btn.AnimationHoverSpeed = 0.07F;
            this.message_send_btn.AnimationSpeed = 0.03F;
            this.message_send_btn.BackColor = System.Drawing.Color.Transparent;
            this.message_send_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.message_send_btn.BorderColor = System.Drawing.Color.Black;
            this.message_send_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.message_send_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.message_send_btn.CheckedForeColor = System.Drawing.Color.White;
            this.message_send_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("message_send_btn.CheckedImage")));
            this.message_send_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.message_send_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.message_send_btn.FocusedColor = System.Drawing.Color.Empty;
            this.message_send_btn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_send_btn.ForeColor = System.Drawing.Color.White;
            this.message_send_btn.Image = null;
            this.message_send_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.message_send_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.message_send_btn.Location = new System.Drawing.Point(713, 14);
            this.message_send_btn.Name = "message_send_btn";
            this.message_send_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.message_send_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.message_send_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.message_send_btn.OnHoverImage = null;
            this.message_send_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.message_send_btn.OnPressedColor = System.Drawing.Color.Black;
            this.message_send_btn.Radius = 15;
            this.message_send_btn.Size = new System.Drawing.Size(139, 42);
            this.message_send_btn.TabIndex = 4;
            this.message_send_btn.Text = "Send";
            this.message_send_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.message_send_btn.Click += new System.EventHandler(this.message_send_btn_Click);
            // 
            // message_text_txt
            // 
            this.message_text_txt.AcceptsReturn = true;
            this.message_text_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.message_text_txt.BackColor = System.Drawing.Color.Transparent;
            this.message_text_txt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.message_text_txt.BorderColor = System.Drawing.Color.Silver;
            this.message_text_txt.BorderSize = 0;
            this.message_text_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.message_text_txt.Dock = System.Windows.Forms.DockStyle.Left;
            this.message_text_txt.FocusedBaseColor = System.Drawing.Color.Black;
            this.message_text_txt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.message_text_txt.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.message_text_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_text_txt.Location = new System.Drawing.Point(0, 0);
            this.message_text_txt.Name = "message_text_txt";
            this.message_text_txt.PasswordChar = '\0';
            this.message_text_txt.Radius = 7;
            this.message_text_txt.SelectedText = "";
            this.message_text_txt.Size = new System.Drawing.Size(707, 69);
            this.message_text_txt.TabIndex = 3;
            this.message_text_txt.TextOffsetX = 5;
            this.message_text_txt.TextChanged += new System.EventHandler(this.message_text_txt_TextChanged);
            // 
            // messages_panel
            // 
            this.messages_panel.AutoScroll = true;
            this.messages_panel.AutoSize = true;
            this.messages_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.messages_panel.Controls.Add(this.gunaGradient2Panel1);
            this.messages_panel.Controls.Add(this.message_panel_in_chat);
            this.messages_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messages_panel.Location = new System.Drawing.Point(0, 66);
            this.messages_panel.Name = "messages_panel";
            this.messages_panel.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.messages_panel.Size = new System.Drawing.Size(952, 573);
            this.messages_panel.TabIndex = 4;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel5);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel4);
            this.gunaGradient2Panel1.Controls.Add(this.gunaCirclePictureBox2);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.SteelBlue;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.SteelBlue;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(563, 174);
            this.gunaGradient2Panel1.MaximumSize = new System.Drawing.Size(300, 0);
            this.gunaGradient2Panel1.MinimumSize = new System.Drawing.Size(300, 82);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 25;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(300, 82);
            this.gunaGradient2Panel1.TabIndex = 6;
            this.gunaGradient2Panel1.Visible = false;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(267, 58);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(16, 20);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "s";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(267, 533);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(16, 20);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "s";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoEllipsis = true;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(69, 15);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(29, 20);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "txt";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(193, 60);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaLabel4.Size = new System.Drawing.Size(76, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "10:24 PM";
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(54, 51);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 0;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // message_panel_in_chat
            // 
            this.message_panel_in_chat.AutoSize = true;
            this.message_panel_in_chat.BackColor = System.Drawing.Color.Transparent;
            this.message_panel_in_chat.Controls.Add(this.message_status_in_chat);
            this.message_panel_in_chat.Controls.Add(this.message_txt_in_chat);
            this.message_panel_in_chat.Controls.Add(this.message_time_in_chat);
            this.message_panel_in_chat.Controls.Add(this.message_user_image_in_chat);
            this.message_panel_in_chat.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.message_panel_in_chat.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.message_panel_in_chat.Location = new System.Drawing.Point(9, 62);
            this.message_panel_in_chat.MaximumSize = new System.Drawing.Size(300, 0);
            this.message_panel_in_chat.MinimumSize = new System.Drawing.Size(300, 82);
            this.message_panel_in_chat.Name = "message_panel_in_chat";
            this.message_panel_in_chat.Radius = 25;
            this.message_panel_in_chat.Size = new System.Drawing.Size(300, 82);
            this.message_panel_in_chat.TabIndex = 6;
            this.message_panel_in_chat.Visible = false;
            // 
            // message_status_in_chat
            // 
            this.message_status_in_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.message_status_in_chat.AutoSize = true;
            this.message_status_in_chat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.message_status_in_chat.ForeColor = System.Drawing.Color.White;
            this.message_status_in_chat.Location = new System.Drawing.Point(267, 60);
            this.message_status_in_chat.Name = "message_status_in_chat";
            this.message_status_in_chat.Size = new System.Drawing.Size(16, 20);
            this.message_status_in_chat.TabIndex = 7;
            this.message_status_in_chat.Text = "s";
            // 
            // message_txt_in_chat
            // 
            this.message_txt_in_chat.AutoEllipsis = true;
            this.message_txt_in_chat.AutoSize = true;
            this.message_txt_in_chat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.message_txt_in_chat.ForeColor = System.Drawing.Color.White;
            this.message_txt_in_chat.Location = new System.Drawing.Point(69, 15);
            this.message_txt_in_chat.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.message_txt_in_chat.Name = "message_txt_in_chat";
            this.message_txt_in_chat.Size = new System.Drawing.Size(29, 20);
            this.message_txt_in_chat.TabIndex = 5;
            this.message_txt_in_chat.Text = "txt";
            // 
            // message_time_in_chat
            // 
            this.message_time_in_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.message_time_in_chat.AutoSize = true;
            this.message_time_in_chat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.message_time_in_chat.ForeColor = System.Drawing.Color.White;
            this.message_time_in_chat.Location = new System.Drawing.Point(192, 61);
            this.message_time_in_chat.Name = "message_time_in_chat";
            this.message_time_in_chat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.message_time_in_chat.Size = new System.Drawing.Size(76, 20);
            this.message_time_in_chat.TabIndex = 4;
            this.message_time_in_chat.Text = "10:24 PM";
            // 
            // message_user_image_in_chat
            // 
            this.message_user_image_in_chat.BaseColor = System.Drawing.Color.White;
            this.message_user_image_in_chat.Image = ((System.Drawing.Image)(resources.GetObject("message_user_image_in_chat.Image")));
            this.message_user_image_in_chat.Location = new System.Drawing.Point(-3, -1);
            this.message_user_image_in_chat.Name = "message_user_image_in_chat";
            this.message_user_image_in_chat.Size = new System.Drawing.Size(45, 42);
            this.message_user_image_in_chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.message_user_image_in_chat.TabIndex = 0;
            this.message_user_image_in_chat.TabStop = false;
            this.message_user_image_in_chat.UseTransfarantBackground = false;
            // 
            // chat_panel
            // 
            this.chat_panel.AutoScroll = true;
            this.chat_panel.BackColor = System.Drawing.Color.Gray;
            this.chat_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chat_panel.Controls.Add(this.messages_panel);
            this.chat_panel.Controls.Add(this.gunaPanel4);
            this.chat_panel.Controls.Add(this.chat_header_panel);
            this.chat_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat_panel.Location = new System.Drawing.Point(437, 0);
            this.chat_panel.Name = "chat_panel";
            this.chat_panel.Size = new System.Drawing.Size(954, 712);
            this.chat_panel.TabIndex = 1;
            this.chat_panel.Visible = false;
            // 
            // add_new_chat_btn
            // 
            this.add_new_chat_btn.AnimationHoverSpeed = 0.07F;
            this.add_new_chat_btn.AnimationSpeed = 0.03F;
            this.add_new_chat_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_new_chat_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.add_new_chat_btn.BorderColor = System.Drawing.Color.Black;
            this.add_new_chat_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.add_new_chat_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.add_new_chat_btn.CheckedForeColor = System.Drawing.Color.White;
            this.add_new_chat_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("add_new_chat_btn.CheckedImage")));
            this.add_new_chat_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.add_new_chat_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_new_chat_btn.FocusedColor = System.Drawing.Color.Empty;
            this.add_new_chat_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_new_chat_btn.ForeColor = System.Drawing.Color.White;
            this.add_new_chat_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_new_chat_btn.Image")));
            this.add_new_chat_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.add_new_chat_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.add_new_chat_btn.Location = new System.Drawing.Point(320, 7);
            this.add_new_chat_btn.Name = "add_new_chat_btn";
            this.add_new_chat_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.add_new_chat_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_new_chat_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_new_chat_btn.OnHoverImage = null;
            this.add_new_chat_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.add_new_chat_btn.OnPressedColor = System.Drawing.Color.Black;
            this.add_new_chat_btn.Radius = 10;
            this.add_new_chat_btn.Size = new System.Drawing.Size(38, 40);
            this.add_new_chat_btn.TabIndex = 4;
            this.add_new_chat_btn.Click += new System.EventHandler(this.add_new_chat_btn_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 712);
            this.Controls.Add(this.chat_panel);
            this.Controls.Add(this._msmpanel);
            this.Name = "ChatForm";
            this.Text = "WhatsApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.Shown += new System.EventHandler(this.ChatForm_Shown);
            this._msmpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.users_panel.ResumeLayout(false);
            this.setting_panel.ResumeLayout(false);
            this.setting_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_user_image)).EndInit();
            this.copy_panel.ResumeLayout(false);
            this.copy_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copy_picture)).EndInit();
            this.type_of_chat_panel.ResumeLayout(false);
            this.chat_header_panel.ResumeLayout(false);
            this.chat_header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header_image)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.messages_panel.ResumeLayout(false);
            this.messages_panel.PerformLayout();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.message_panel_in_chat.ResumeLayout(false);
            this.message_panel_in_chat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.message_user_image_in_chat)).EndInit();
            this.chat_panel.ResumeLayout(false);
            this.chat_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel _msmpanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaGradient2Panel type_of_chat_panel;
        private Guna.UI.WinForms.GunaPanel chat_header_panel;
        private Guna.UI.WinForms.GunaLabel last_appear;
        private Guna.UI.WinForms.GunaLabel header_user_name;
        private Guna.UI.WinForms.GunaCirclePictureBox header_image;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaAdvenceButton message_send_btn;
        private Guna.UI.WinForms.GunaTextBox message_text_txt;
        private System.Windows.Forms.Panel messages_panel;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaGradient2Panel message_panel_in_chat;
        private Guna.UI.WinForms.GunaLabel message_status_in_chat;
        private Guna.UI.WinForms.GunaLabel message_txt_in_chat;
        private Guna.UI.WinForms.GunaLabel message_time_in_chat;
        private Guna.UI.WinForms.GunaCirclePictureBox message_user_image_in_chat;
        private Guna.UI.WinForms.GunaPanel chat_panel;
        private Guna.UI.WinForms.GunaImageRadioButton online_chat;
        private Guna.UI.WinForms.GunaImageRadioButton simple_chat;
        private System.Windows.Forms.Panel users_panel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox search_chat;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradient2Panel copy_panel;
        private Guna.UI.WinForms.GunaCircleButton copy_counter_btn;
        private Guna.UI.WinForms.GunaCirclePictureBox copy_picture;
        private Guna.UI.WinForms.GunaLabel copy_time_label;
        private Guna.UI.WinForms.GunaLabel copy_user_name_label;
        private System.Windows.Forms.Panel setting_panel;
        private System.Windows.Forms.Label setting_phone_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton edit_about;
        private System.Windows.Forms.TextBox setting_about;
        private Guna.UI.WinForms.GunaAdvenceButton edit_user_name;
        private System.Windows.Forms.TextBox setting_user_name;
        private Guna.UI.WinForms.GunaCirclePictureBox setting_user_image;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaImageCheckBox setting_check_box;
        private Guna.UI.WinForms.GunaAdvenceButton save_about;
        private Guna.UI.WinForms.GunaAdvenceButton save_user_name;
        private Guna.UI.WinForms.GunaAdvenceButton add_new_chat_btn;
    }
}

