using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace ChatApp
{
    public partial class NewChat : Form
    {
        Connect.WebService1SoapClient conn;
        public int User_id { set; get; }
        public string User_name { set; get; }
        public string User_About { set; get; }
        public string Image_name { set; get; }
        public string User_phone { set; get; }

        string image_url = @"E:\Mohammed Maresh 22160052\Integrative Programming\user_images\";


        int users_panels_height;

        public NewChat()
        {
            InitializeComponent();
            conn = new Connect.WebService1SoapClient();
        }

        void add_user_panel(string user_id, string image, string user_name, string user_about)
        {
            GunaGradient2Panel panel = new GunaGradient2Panel();
            panel.Name = user_id;
            panel.Size = copy_panel.Size;
            panel.GradientColor1 = copy_panel.GradientColor1;
            panel.GradientColor2 = copy_panel.GradientColor2;
            panel.Radius = copy_panel.Radius;
            panel.Location = new Point(copy_panel.Location.X, users_panels_height);
            panel.MouseEnter += user_panel_MouseEnter;
            panel.MouseLeave += user_panel_MouseLeave;
            panel.Click += user_panel_Click;
            all_users_panel.Controls.Add(panel);
            GunaCirclePictureBox pictureBox = new GunaCirclePictureBox();
            pictureBox.Image = new Bitmap(image_url + (image == null || image.ToString() == "" ? "1111" : image) + ".jpg");
            pictureBox.Name = "user_image";
            pictureBox.Size = copy_picture.Size;
            pictureBox.SizeMode = copy_picture.SizeMode;
            pictureBox.Location = copy_picture.Location;
            panel.Controls.Add(pictureBox);
            Label name_label = new Label();
            name_label.Text = user_name;
            name_label.Name = "user_user_name";
            name_label.AutoSize = true;
            name_label.Font = copy_user_name_label.Font;
            name_label.ForeColor = copy_user_name_label.ForeColor;
            name_label.Location = copy_user_name_label.Location;
            panel.Controls.Add(name_label);
            Label about_label = new Label();
            about_label.Text = user_about;
            about_label.Name = "user_last_message_time";
            about_label.AutoSize = true;
            about_label.Font = copy_about_label.Font;
            about_label.ForeColor = copy_about_label.ForeColor;
            about_label.Location = copy_about_label.Location;
            panel.Controls.Add(about_label);

            users_panels_height += panel.Height + 5;
        }


        private void NewChat_Load(object sender, EventArgs e)
        {
            all_users_panel.Controls.Clear();
            users_panels_height = 20;
            add_user_panel(User_id.ToString(), Image_name, User_name, User_About);
            foreach (DataRow row in conn.GetAllOtherUser(User_id).Tables["Table"].Rows)
            {
                add_user_panel(row["user_id"].ToString(), row["image"].ToString(), row["user_name"].ToString(), row["about"].ToString());
            }
        }

        private void user_panel_MouseEnter(object sender, EventArgs e)
        {
            GunaGradient2Panel panel = sender as GunaGradient2Panel;
            panel.GradientColor1 = Color.FromArgb(2, 99, 178);
        }

        private void user_panel_MouseLeave(object sender, EventArgs e)
        {
            GunaGradient2Panel panel = sender as GunaGradient2Panel;
            panel.GradientColor1 = copy_panel.GradientColor1;
        }

        private void user_panel_Click(object sender, EventArgs e)
        {
            try
            {
                Panel panel = sender as Panel;
                this.DialogResult = DialogResult.OK;
                this.User_id = int.Parse(panel.Name.ToString());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
