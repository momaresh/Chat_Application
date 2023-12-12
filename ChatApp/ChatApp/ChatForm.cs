using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatApp
{
    public partial class ChatForm : Form
    {
        Connect.WebService1SoapClient conn;
        public int User_id { set; get; }
        public string User_name { set; get; }
        public string User_About { set; get; }
        public string Image_name { set; get; }
        public string User_phone { set; get; }

        string image_url = @"E:\Mohammed Maresh 22160052\Integrative Programming\user_images\";
        

        int user_chating_id;
        int last_meesage_loaded_id = 0;
        int height = 5;
        int users_panels_height;
        GunaGradient2Panel panel_for_user = null;
        Thread thread = null;
        Thread append_new_messages = null;
        Thread check_online_thread = null;
        Thread check_status_thread = null;
        Thread listen_thread = null;
        bool is_simple_chat = true;
        GunaGradient2Panel prev_panel_clicked = null;
        string received_data = "";
        string send_data = "";
        int online_chat_panel_height = 5;
        TcpListener tcpClient = null;
        ThreadAbortException threadAbortException = null;

        // this array will contain the user that i already contact with them
        ArrayList chatting_users_array_list;


        /// <summary>
        ///  Decrator
        /// </summary>

        public ChatForm()
        {
            InitializeComponent();
            conn = new Connect.WebService1SoapClient();
            chatting_users_array_list = new ArrayList();
        }


        void add_user_panel(string user_id, string image, string user_name)
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
            users_panel.Controls.Add(panel);
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
            Label time_label = new Label();
            time_label.Text = "";
            time_label.Name = "user_last_message_time";
            time_label.AutoSize = true;
            time_label.Font = copy_time_label.Font;
            time_label.ForeColor = Color.Red;
            time_label.Location = copy_time_label.Location;
            panel.Controls.Add(time_label);

            GunaCircleButton counter_btn = new GunaCircleButton();
            counter_btn.Text = "";
            counter_btn.Name = "user_message_count";
            counter_btn.Enabled = copy_counter_btn.Enabled;
            counter_btn.Visible = false;
            counter_btn.Font = copy_counter_btn.Font;
            counter_btn.ForeColor = copy_counter_btn.ForeColor;
            counter_btn.BaseColor = copy_counter_btn.BaseColor;
            counter_btn.Size = copy_counter_btn.Size;
            counter_btn.Location = copy_counter_btn.Location;
            panel.Controls.Add(counter_btn);
            users_panels_height += panel.Height + 5;
            chatting_users_array_list.Add(user_id);
        }

        void get_chating_user()
        {
            users_panel.Controls.Clear();
            chatting_users_array_list.Clear();
            users_panels_height = panel1.Height + 5;
            foreach (DataRow row in conn.GetAllOtherUser(User_id).Tables["Table"].Rows)
            {
                if (int.Parse(conn.CheckIfThereIsContactBetweenThisUsers(User_id, int.Parse(row[0].ToString())).Tables["Table"].Rows[0][0].ToString()) > 0)
                {
                    add_user_panel(row["user_id"].ToString(), row["image"].ToString(), row["user_name"].ToString());
                }
            }
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Welcome, " + User_name;
            get_chating_user();

            thread = new Thread(new ThreadStart(CheckNewMessages));
            thread.Start();
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
                if (chat_panel.Visible == false)
                    chat_panel.Visible = true;

                panel_for_user = sender as GunaGradient2Panel;
                user_chating_id = int.Parse(panel_for_user.Name);

                if (prev_panel_clicked != null && prev_panel_clicked.Name != user_chating_id.ToString())
                {
                    prev_panel_clicked.GradientColor2 = Color.White;

                    if (!is_simple_chat)
                    {
                        online_chat_panel_height = 5;
                        messages_panel.Controls.Clear();
                    }
                }

                panel_for_user.GradientColor2 = Color.SteelBlue;


                header_user_name.Text = panel_for_user.GetChildAtPoint(copy_user_name_label.Location).Text;
                PictureBox p = (PictureBox)panel_for_user.GetChildAtPoint(copy_picture.Location);
                header_image.Image = p.Image;

                if (is_simple_chat)
                {
                    if (prev_panel_clicked == null || prev_panel_clicked.Name != user_chating_id.ToString())
                        reload_chat_messages(panel_for_user);

                    Control l = panel_for_user.Controls.Find("user_message_count", true)[0];
                    l.Text = "";
                    l.Visible = false;

                    if (append_new_messages == null)
                    {
                        append_new_messages = new Thread(new ThreadStart(append_new_messages_for_user_thread));
                        append_new_messages.Start();
                    }

                    if (check_online_thread == null)
                    {
                        check_online_thread = new Thread(new ThreadStart(check_online_thread_func));
                        check_online_thread.Start();
                    }

                    if (check_status_thread == null)
                    {
                        check_status_thread = new Thread(new ThreadStart(check_status_thread_func));
                        check_status_thread.Start();
                    }
                }

                prev_panel_clicked = panel_for_user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reload_chat_messages(GunaGradient2Panel user_panel_loc)
        {
            try
            {
                height = 5;
                messages_panel.Controls.Clear();

                GunaGradient2Panel panel = null;
                foreach (DataRow row in conn.GetMessageForUser(user_chating_id, User_id).Tables["Table"].Rows)
                {
                    DateTime time = (DateTime)row["message_date"];
                    panel = new GunaGradient2Panel();
                    last_meesage_loaded_id = int.Parse(row[0].ToString());
                    panel.Name = row[0].ToString();
                    panel.Size = message_panel_in_chat.Size;
                    panel.AutoSize = message_panel_in_chat.AutoSize;
                    panel.MaximumSize = message_panel_in_chat.MaximumSize;
                    panel.MinimumSize = message_panel_in_chat.Size;
                    panel.GradientColor1 = message_panel_in_chat.GradientColor1;
                    panel.GradientColor2 = message_panel_in_chat.GradientColor2;
                    panel.Radius = message_panel_in_chat.Radius;

                    GunaCirclePictureBox pictureBox = new GunaCirclePictureBox();

                    if (row["send_from_user_id"].ToString() == user_chating_id.ToString())
                    {
                        panel.Location = new Point(10, height);
                        pictureBox.Image = new Bitmap(image_url + row["from_image"] + ".jpg");
                    }
                    else if (row["send_from_user_id"].ToString() == User_id.ToString())
                    {
                        panel.Location = new Point(688, height);
                        pictureBox.Image = new Bitmap(image_url + Image_name + ".jpg");
                    }


                    Label message_text_label = new Label();
                    message_text_label.Text = row["message_text"].ToString();
                    message_text_label.AutoEllipsis = true;
                    message_text_label.AutoSize = true;
                    message_text_label.Font = message_txt_in_chat.Font;
                    message_text_label.ForeColor = message_txt_in_chat.ForeColor;
                    message_text_label.Margin = message_txt_in_chat.Margin;
                    message_text_label.Location = message_txt_in_chat.Location;
                    panel.Controls.Add(message_text_label);

                    pictureBox.Size = message_user_image_in_chat.Size;
                    pictureBox.Location = message_user_image_in_chat.Location;
                    panel.Controls.Add(pictureBox);

                    Label time_label = new Label();
                    time_label.Text = time.ToShortTimeString().ToString();
                    time_label.AutoSize = true;
                    time_label.Font = message_time_in_chat.Font;
                    time_label.ForeColor = message_time_in_chat.ForeColor;
                    time_label.Anchor = message_time_in_chat.Anchor;
                    time_label.Location = message_time_in_chat.Location;
                    panel.Controls.Add(time_label);

                    if (row["send_from_user_id"].ToString() == User_id.ToString())
                    {
                        Label status_label = new Label();
                        if (row["status"].ToString() == "1")
                        {
                            status_label.Text = "\u221A";
                            status_label.ForeColor = Color.White;
                        }
                        else if (row["status"].ToString() == "2")
                        {
                            status_label.Text = "\u221A\u221A";
                            status_label.ForeColor = Color.White;
                        }
                        else if (row["status"].ToString() == "3")
                        {
                            status_label.Text = "\u221A\u221A";
                            status_label.ForeColor = Color.Blue;
                        }

                        status_label.AutoSize = true;
                        status_label.Name = "message_status_in_chat";
                        status_label.Font = message_status_in_chat.Font;
                        status_label.Anchor = message_status_in_chat.Anchor;
                        status_label.Location = message_status_in_chat.Location;
                        panel.Controls.Add(status_label);

                        panel.GradientColor1 = Color.SteelBlue;
                        panel.GradientColor2 = Color.SteelBlue;
                    }

                    messages_panel.Controls.Add(panel);

                    height = height + panel.Height + 5;
                }

                messages_panel.ScrollControlIntoView(panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckNewMessages()
        {
            try
            {
                while (true)
                {
                    foreach (DataRow row in conn.CheckNewMessageForUser(User_id).Tables["Table"].Rows)
                    {
                        if (!chatting_users_array_list.Contains(row[0].ToString()))
                        {
                            DataRow row2 = conn.GetUserData(int.Parse(row[0].ToString())).Tables["Table"].Rows[0];
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                add_user_panel(row2["user_id"].ToString(), row2["image"].ToString(), row2["user_name"].ToString());
                            });
                        }

                        Control panel = users_panel.Controls.Find(row[0].ToString(), true)[0];
                        Control btn = panel.Controls.Find("user_message_count", true)[0];

                        if (int.Parse(row[1].ToString()) > 0)
                        {
                            btn.Invoke((MethodInvoker) delegate () {
                                btn.Text = row[1].ToString();
                                btn.Visible = true;
                            });
                        }
                        else
                        {
                            btn.Visible = false;
                        }

                        foreach (DataRow row3 in conn.GetNewMessageForNotif(int.Parse(row[0].ToString()), User_id).Tables["Table"].Rows)
                        {
                            WhatsAppNotification WhatsApp = new WhatsAppNotification();
                            WhatsApp.Title = row3["from_user_name"].ToString();
                            FaceBookNotification face = new FaceBookNotification(WhatsApp);
                            TelegramNotification telegram = new TelegramNotification(face);

                            string path = "file:///" + Path.GetFullPath(@"E:\Mohammed Maresh 22160052\Integrative Programming\user_images\" + row3["from_image"] +".jpg");
                            new ToastContentBuilder()
                            .AddText(telegram.Send())
                            .AddText(row3["message_text"].ToString())
                            .AddAppLogoOverride(new Uri(path), ToastGenericAppLogoCrop.Circle)
                            .Show();
                        }
                    }

                    Thread.Sleep(3000);
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != threadAbortException)
                    MessageBox.Show(ex.Message);
            }
        }

        private void message_send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_simple_chat)
                {
                    conn.SendMessageForUser(message_text_txt.Text, User_id, user_chating_id);
                    append_send_messages_from_user();
                }
                else
                {
                    TcpClient tcpClient = new TcpClient("localhost", 800 + user_chating_id);
                    byte[] data = Encoding.ASCII.GetBytes(User_id.ToString() + " " + message_text_txt.Text);

                    send_data = message_text_txt.Text;
                    received_data = "";
                    GunaGradient2Panel user_online_panel = (GunaGradient2Panel)users_panel.Controls.Find(user_chating_id.ToString(), true)[0];
                    user_online_panel_Click(user_online_panel);

                    NetworkStream networkStream = tcpClient.GetStream();
                    networkStream.Write(data, 0, data.Length);
                    networkStream.Close();
                }

                message_text_txt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void append_send_messages_from_user()
        {
            try
            {
                user_chating_id = int.Parse(panel_for_user.Name);
                GunaGradient2Panel panel = null;
                DateTime time = DateTime.Now;
                panel = new GunaGradient2Panel();
                panel.Name = (last_meesage_loaded_id + 1).ToString();
                last_meesage_loaded_id++;
                panel.Size = message_panel_in_chat.Size;
                panel.AutoSize = message_panel_in_chat.AutoSize;
                panel.MaximumSize = message_panel_in_chat.MaximumSize;
                panel.MinimumSize = message_panel_in_chat.Size;
                panel.GradientColor1 = message_panel_in_chat.GradientColor1;
                panel.GradientColor2 = message_panel_in_chat.GradientColor2;
                panel.Radius = message_panel_in_chat.Radius;
                if (height >= messages_panel.Height)
                    panel.Location = new Point(688, messages_panel.Height + 5);
                else
                {
                    panel.Location = new Point(688, height);
                    height = height + panel.Height + 5;
                }


                Label message_text_label = new Label();
                message_text_label.Text = message_text_txt.Text;
                message_text_label.AutoEllipsis = true;
                message_text_label.AutoSize = true;
                message_text_label.Font = message_txt_in_chat.Font;
                message_text_label.ForeColor = message_txt_in_chat.ForeColor;
                message_text_label.Location = message_txt_in_chat.Location;
                panel.Controls.Add(message_text_label);

                GunaCirclePictureBox pictureBox = new GunaCirclePictureBox();
                pictureBox.Image = new Bitmap(image_url + Image_name + ".jpg");
                pictureBox.Size = message_user_image_in_chat.Size;
                pictureBox.Location = message_user_image_in_chat.Location;
                panel.Controls.Add(pictureBox);

                Label time_label = new Label();
                time_label.Text = time.ToShortTimeString().ToString();
                time_label.AutoSize = true;
                time_label.Font = message_time_in_chat.Font;
                time_label.ForeColor = message_time_in_chat.ForeColor;
                time_label.Anchor = message_time_in_chat.Anchor;
                time_label.Location = message_time_in_chat.Location;
                panel.Controls.Add(time_label);
                Label status_label = new Label();

                status_label.Text = "\u221A";
                status_label.Name = "message_status_in_chat";
                status_label.ForeColor = Color.White;
                status_label.AutoSize = true;
                status_label.Font = message_status_in_chat.Font;
                status_label.Anchor = message_status_in_chat.Anchor;
                status_label.Location = message_status_in_chat.Location;
                panel.Controls.Add(status_label);

                panel.GradientColor1 = Color.SteelBlue;
                panel.GradientColor2 = Color.SteelBlue;

                messages_panel.Controls.Add(panel);

                messages_panel.ScrollControlIntoView(panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void message_text_txt_TextChanged(object sender, EventArgs e)
        {
            if (message_text_txt.Text != "")
            {
                message_send_btn.Enabled = true;
            }
            else
            {
                message_send_btn.Enabled = false;
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.LogOutUser(User_id);
            conn.ExitRemoting(User_id);
           

            if (thread != null)
                thread.Abort();
            if (append_new_messages != null)
            {
                append_new_messages.Abort();
            }
            if (check_online_thread != null)
            {
                check_online_thread.Abort();
            }
            if (check_status_thread != null)
                check_status_thread.Abort();

            if (listen_thread != null)
                listen_thread.Abort();

            if (tcpClient != null)
                tcpClient.Stop();

            Application.Exit();
        }


        private void append_new_messages_for_user_thread()
        {
            try
            {
                while (true)
                {
                    GunaGradient2Panel panel = null;
                    foreach (DataRow row in conn.GetNewMessageForUser(user_chating_id, User_id).Tables["Table"].Rows)
                    {
                        DateTime time = (DateTime)row["message_date"];
                        panel = new GunaGradient2Panel();
                        last_meesage_loaded_id = int.Parse(row[0].ToString());
                        panel.Name = row[0].ToString();
                        panel.Size = message_panel_in_chat.Size;
                        panel.AutoSize = message_panel_in_chat.AutoSize;
                        panel.MaximumSize = message_panel_in_chat.MaximumSize;
                        panel.MinimumSize = message_panel_in_chat.Size;
                        panel.GradientColor1 = message_panel_in_chat.GradientColor1;
                        panel.GradientColor2 = message_panel_in_chat.GradientColor2;
                        panel.Radius = message_panel_in_chat.Radius;

                        if (height >= messages_panel.Height)
                            panel.Location = new Point(10, messages_panel.Height + 5);
                        else
                        {
                            panel.Location = new Point(10, height);
                            height = height + panel.Height + 5;
                        }

                        Label message_text_label = new Label();
                        message_text_label.Text = row["message_text"].ToString();
                        message_text_label.AutoEllipsis = true;
                        message_text_label.AutoSize = true;
                        message_text_label.Font = message_txt_in_chat.Font;
                        message_text_label.ForeColor = message_txt_in_chat.ForeColor;
                        message_text_label.Location = message_txt_in_chat.Location;

                        GunaCirclePictureBox pictureBox = new GunaCirclePictureBox();
                        pictureBox.Image = new Bitmap(image_url + row["from_image"] + ".jpg");
                        pictureBox.Size = message_user_image_in_chat.Size;
                        pictureBox.Location = message_user_image_in_chat.Location;

                        Label time_label = new Label();
                        time_label.Text = time.ToShortTimeString().ToString();
                        time_label.AutoSize = true;
                        time_label.Font = message_time_in_chat.Font;
                        time_label.ForeColor = message_time_in_chat.ForeColor;
                        time_label.Anchor = message_time_in_chat.Anchor;
                        time_label.Location = message_time_in_chat.Location;

                        messages_panel.Invoke(new Action<Panel, Label, GunaCirclePictureBox, Label>(AppendMessagePanel), panel, message_text_label, pictureBox, time_label);
                    }

                    Thread.Sleep(2000);
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != threadAbortException)
                    MessageBox.Show(ex.Message);
            }
        }

        private void AppendMessagePanel(Panel panel, Label message_text_label, GunaCirclePictureBox pictureBox, Label time_label)
        {
            panel.Controls.Add(message_text_label);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(time_label);
            messages_panel.Controls.Add(panel);

            messages_panel.ScrollControlIntoView(panel);
        }

        private void check_online_thread_func()
        {
            try
            {
                while (true)
                {
                    if (last_appear.Visible)
                    {
                        if (conn.CheckOnline(int.Parse(panel_for_user.Name.ToString())).Tables["Table"].Rows[0]["online"].ToString() == "1")
                        {
                            last_appear.Invoke(new Action<string>(UpdatelastAppear), "online");
                        }
                        else
                        {
                            last_appear.Invoke(new Action<string>(UpdatelastAppear), "last appear " + conn.CheckOnline(User_id).Tables["Table"].Rows[0]["last_appear"].ToString());
                        }
                    }

                    Thread.Sleep(3000);
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != threadAbortException)
                    MessageBox.Show(ex.Message);
            }
        }

        private void check_status_thread_func()
        {
            while (true)
            { 
                try
                {
                    foreach (DataRow row in conn.CheckStatus(user_chating_id, User_id).Tables["Table"].Rows)
                    {
                        if (messages_panel.Controls.Find(row[0].ToString(), true)[0] != null)
                        {
                            Control panel = messages_panel.Controls.Find(row[0].ToString(), true)[0];
                            Control label = panel.Controls.Find("message_status_in_chat", true)[0];

                            if (row["status"].ToString() == "2")
                            {
                                label.Invoke(new Action<Label, string, int>(UpdateMessageStatus), label, "\u221A\u221A", 2);
                            }
                            else if (row["status"].ToString() == "3")
                            {
                                label.Invoke(new Action<Label, string, int>(UpdateMessageStatus), label, "\u221A\u221A", 3);
                            }
                        }
                    }            
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != threadAbortException)
                        MessageBox.Show(ex.Message);
                }
                Thread.Sleep(1000);
            }

        }

        private void UpdatelastAppear(string item)
        {
            last_appear.Text = item;
        }

        private void UpdateMessageStatus(Label label, string item, int type)
        {
            label.Text = item;
            if (type == 3)
            {
                label.ForeColor = Color.Blue;
            }
            if (type == 2)
            {
                label.ForeColor = Color.White;
            }
        }

        private void online_chat_CheckedChanged(object sender, EventArgs e)
        {
            if (online_chat.Checked)
            {
                if (is_simple_chat)
                {
                    conn.EnterRemoting(User_id);
                    if (thread != null)
                        thread.Abort();
                    if (append_new_messages != null)
                    {
                        append_new_messages.Abort();
                    }
                    if (check_online_thread != null)
                    {
                        check_online_thread.Abort();
                    }
                    if (check_status_thread != null)
                        check_status_thread.Abort();

                    chat_panel.Visible = false;
                    messages_panel.Controls.Clear();
                    is_simple_chat = false;
                    add_new_chat_btn.Visible = false;


                    // get the online remoting user
                    get_online_remoting_user();

                    listen_thread = new Thread(new ThreadStart(ListenerThread));
                    listen_thread.Start();
                }

                online_chat.BackColor = Color.SteelBlue;
            }
            else
            {
                online_chat.BackColor = Color.Transparent;
            }
        }

        private void simple_chat_CheckedChanged(object sender, EventArgs e)
        {
            if (simple_chat.Checked)
            {
                if (!is_simple_chat)
                {
                    conn.ExitRemoting(User_id);
                    
                    get_chating_user();
                    listen_thread.Abort();
                    tcpClient.Stop();

                    chat_panel.Visible = false;
                    add_new_chat_btn.Visible = false;

                    messages_panel.Controls.Clear();
                    if (panel_for_user != null)
                    {
                        panel_for_user.GradientColor2 = Color.White;
                        panel_for_user = null;
                        prev_panel_clicked = null;
                    }

                    is_simple_chat = true;
                    thread = new Thread(new ThreadStart(CheckNewMessages));
                    thread.Start();
                }
                simple_chat.BackColor = Color.SteelBlue;
            }
            else
            {
                simple_chat.BackColor = Color.Transparent;
            }
        }

        void ListenerThread()
        {
            try
            {
                tcpClient = new TcpListener(IPAddress.Any, 800 + User_id);
                tcpClient.Start();
                while (true)
                {
                    if (!tcpClient.Pending())
                    {
                        Thread.Sleep(500); // choose a number (in milliseconds) that makes sense
                        continue; // skip to next iteration of loop
                    }

                    TcpClient endPoint = tcpClient.AcceptTcpClient();
                    if (endPoint.Connected)
                    {
                        NetworkStream networkStream = endPoint.GetStream();
                        byte[] bytes = new byte[1024];

                        int bytesRead = 0;
                        int space_index = -1;
                        string data = null;

                        while (true)
                        {
                            bytesRead = networkStream.Read(bytes, 0, bytes.Length);
                            if (bytesRead == 0) break;
                            data += Encoding.UTF8.GetString(bytes);
                            if (space_index == -1)
                            {
                                space_index = data.IndexOf(" ");
                            }
                        }

                        user_chating_id = int.Parse(data.Substring(0, space_index));
                        received_data = data.Substring(space_index + 1);
                        send_data = "";

                        if (!chatting_users_array_list.Contains(user_chating_id))
                        {
                            DataRow row = conn.GetUserData(user_chating_id).Tables["Table"].Rows[0];
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                add_user_panel(row["user_id"].ToString(), row["image"].ToString(), row["user_name"].ToString());
                            });
                        }

                        GunaGradient2Panel user_online_panel = (GunaGradient2Panel)users_panel.Controls.Find(user_chating_id.ToString(), true)[0];
                        user_online_panel.Invoke((MethodInvoker)delegate ()
                        {
                            user_online_panel_Click(user_online_panel);
                        });

                        networkStream.Close();
                    }
                }
            }
            catch (Exception ex) 
            {
                if (ex.InnerException != threadAbortException)
                    MessageBox.Show(ex.Message); 
            }
        }

        private void user_online_panel_Click(GunaGradient2Panel user_online_panel)
        {
            try
            {
                if (chat_panel.Visible == false)
                {
                    chat_panel.Visible = true;
                }

                panel_for_user = user_online_panel;
                if (prev_panel_clicked != null && prev_panel_clicked.Name != user_chating_id.ToString())
                {
                    prev_panel_clicked.GradientColor2 = Color.White;

                    online_chat_panel_height = 5;
                    messages_panel.Controls.Clear();
                }
                panel_for_user.GradientColor2 = Color.SteelBlue;


                prev_panel_clicked = panel_for_user;

                user_chating_id = int.Parse(panel_for_user.Name);
                header_user_name.Text = panel_for_user.GetChildAtPoint(copy_user_name_label.Location).Text;
                PictureBox p = (PictureBox)panel_for_user.GetChildAtPoint(copy_picture.Location);
                header_image.Image = p.Image;


                GunaGradient2Panel panel = null;
                DateTime time = DateTime.Now;
                panel = new GunaGradient2Panel();
                panel.Size = message_panel_in_chat.Size;
                panel.AutoSize = message_panel_in_chat.AutoSize;
                panel.MaximumSize = message_panel_in_chat.MaximumSize;
                panel.MinimumSize = message_panel_in_chat.Size;
                panel.GradientColor1 = message_panel_in_chat.GradientColor1;
                panel.GradientColor2 = message_panel_in_chat.GradientColor2;
                panel.Radius = message_panel_in_chat.Radius;

                if (online_chat_panel_height >= messages_panel.Height)
                {
                    if (received_data == "" && send_data != "")
                        panel.Location = new Point(688, messages_panel.Height + 5);
                    else if (received_data != "" && send_data == "")
                        panel.Location = new Point(10, messages_panel.Height + 5);
                }
                else
                {
                    if (received_data == "" && send_data != "")
                        panel.Location = new Point(688, online_chat_panel_height);
                    else if (received_data != "" && send_data == "")
                        panel.Location = new Point(10, online_chat_panel_height);

                    online_chat_panel_height = online_chat_panel_height + panel.Height + 5;
                }


                Label message_text_label = new Label();
                message_text_label.Text = received_data + send_data; // one of them is has data not both
                message_text_label.AutoEllipsis = true;
                message_text_label.AutoSize = true;
                message_text_label.Font = message_txt_in_chat.Font;
                message_text_label.ForeColor = message_txt_in_chat.ForeColor;
                message_text_label.Location = message_txt_in_chat.Location;
                panel.Controls.Add(message_text_label);

                Label time_label = new Label();
                time_label.Text = time.ToShortTimeString().ToString();
                time_label.AutoSize = true;
                time_label.Font = message_time_in_chat.Font;
                time_label.ForeColor = message_time_in_chat.ForeColor;
                time_label.Anchor = message_time_in_chat.Anchor;
                time_label.Location = message_time_in_chat.Location;
                panel.Controls.Add(time_label);
                Label status_label = new Label();

                if (received_data == "" && send_data != "")
                {
                    panel.GradientColor1 = Color.SteelBlue;
                    panel.GradientColor2 = Color.SteelBlue;
                }
                else if (received_data != "" && send_data == "")
                {
                    panel.GradientColor1 = message_panel_in_chat.GradientColor1;
                    panel.GradientColor2 = message_panel_in_chat.GradientColor2;
                }

                messages_panel.Controls.Add(panel);

                messages_panel.ScrollControlIntoView(panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void get_online_remoting_user()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                users_panel.Controls.Clear();
                users_panels_height = panel1.Height;
                chatting_users_array_list.Clear();
            });

            foreach (DataRow row in conn.GetOnlineRemotingUser(User_id).Tables["Table"].Rows)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    add_user_panel(row["user_id"].ToString(), row["image"].ToString(), row["user_name"].ToString());
                });
            }
        }

        private void setting_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if (setting_check_box.Checked)
            {
                setting_panel.Visible = true;
                users_panel.Controls.Add(setting_panel);
                setting_panel.BringToFront();
                setting_user_image.Image = new Bitmap(image_url + Image_name + ".jpg");
                setting_user_name.Text = User_name;
                setting_about.Text = User_About;
                setting_phone_number.Text = User_phone;
            }
            else
            {
                setting_panel.Visible = false;
            }
        }

        private void edit_user_name_Click(object sender, EventArgs e)
        {
            setting_user_name.ReadOnly = false;
            save_user_name.Visible = true;
            edit_user_name.Visible = false;
        }

        private void save_user_name_Click(object sender, EventArgs e)
        {
            try
            {
                conn.EditUserName(User_id, setting_user_name.Text);
                User_name = setting_user_name.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            setting_user_name.ReadOnly = true;
            save_user_name.Visible = false;
            edit_user_name.Visible = true;
        }

        private void save_about_Click(object sender, EventArgs e)
        {
            try
            {
                conn.EditUserAbout(User_id, setting_about.Text);
                User_About = setting_about.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            setting_about.ReadOnly = true;
            save_about.Visible = false;
            edit_about.Visible = true;
        }

        private void edit_about_Click(object sender, EventArgs e)
        {
            setting_about.ReadOnly = false;
            save_about.Visible = true;
            edit_about.Visible = false;
        }

        private void ChatForm_Shown(object sender, EventArgs e)
        {
            if (Image_name == null || Image_name == "")
            {
                Image_name = "1111";
            }
            setting_check_box.BackgroundImage = new Bitmap(image_url + Image_name + ".jpg");
        }

        private void add_new_chat_btn_Click(object sender, EventArgs e)
        {
            NewChat newChat = new NewChat();
            newChat.User_id = User_id;
            newChat.User_name = User_name;
            newChat.User_About = User_About;
            newChat.Image_name = Image_name;
            newChat.Location = new Point(320, 50);
            newChat.ShowDialog();

            if (newChat.DialogResult == DialogResult.OK)
            {
                if (!chatting_users_array_list.Contains(newChat.User_id.ToString()))
                {
                    DataRow row2 = conn.GetUserData(newChat.User_id).Tables["Table"].Rows[0];
                    add_user_panel(row2["user_id"].ToString(), row2["image"].ToString(), row2["user_name"].ToString());
                }

                if (chat_panel.Visible == false)
                    chat_panel.Visible = true;

                panel_for_user = (GunaGradient2Panel)users_panel.Controls.Find(newChat.User_id.ToString(), true)[0];
                user_chating_id = int.Parse(panel_for_user.Name);

                if (prev_panel_clicked != null)
                {
                    prev_panel_clicked.GradientColor2 = Color.White;
                }

                panel_for_user.GradientColor2 = Color.SteelBlue;

                header_user_name.Text = panel_for_user.GetChildAtPoint(copy_user_name_label.Location).Text;
                PictureBox p = (PictureBox)panel_for_user.GetChildAtPoint(copy_picture.Location);
                header_image.Image = p.Image;
                if (prev_panel_clicked == null || prev_panel_clicked.Name != user_chating_id.ToString())
                    reload_chat_messages(panel_for_user);


                if (append_new_messages == null)
                {
                    append_new_messages = new Thread(new ThreadStart(append_new_messages_for_user_thread));
                    append_new_messages.Start();
                }

                if (check_online_thread == null)
                {
                    check_online_thread = new Thread(new ThreadStart(check_online_thread_func));
                    check_online_thread.Start();
                }

                if (check_status_thread == null)
                {
                    check_status_thread = new Thread(new ThreadStart(check_status_thread_func));
                    check_status_thread.Start();
                }

                prev_panel_clicked = panel_for_user;
            }
        }
    }
}
