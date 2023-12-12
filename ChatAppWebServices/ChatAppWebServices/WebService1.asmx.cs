using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace ChatAppWebServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Connect conn;
        public WebService1()
        {
            conn = new Connect();
        }

        [WebMethod]
        public DataSet GetAllOtherUser(int user_id)
        {
            string query = "SELECT * FROM users WHERE user_id != " + user_id;
            return conn.Reader(query);
        }

        [WebMethod]
        public DataSet GetMessageForUser(int from_user, int to_user)
        {
            DataSet dataSet = new DataSet();
            string query = "SELECT message_id, message_text, send_from_user_id, send_to_user_id, message_date, status, fr.image as 'from_image'" +
                " FROM messages as m JOIN users as fr ON m.send_from_user_id = fr.user_id" +
                " WHERE (send_from_user_id = {0} AND send_to_user_id = {1}) OR (send_from_user_id = {2} AND send_to_user_id = {3}) ORDER BY message_date ASC";
            query = string.Format(query, from_user, to_user, to_user, from_user);
            dataSet = conn.Reader(query);
            query = "UPDATE messages SET status = 3 WHERE send_from_user_id = {0} AND send_to_user_id = {1}";
            query = string.Format(query, from_user, to_user);
            conn.Writer(query);
            return dataSet;
        }

        [WebMethod]
        public DataSet CheckNewMessageForUser(int user_id)
        {
            DataSet dataSet = new DataSet();
            string query = "SELECT send_from_user_id, COUNT(send_from_user_id) FROM messages WHERE send_to_user_id = {0} AND status != 3 GROUP BY send_from_user_id HAVING COUNT(send_from_user_id) > 0";
            query = string.Format(query, user_id);
            dataSet = conn.Reader(query);
            return dataSet;
        }

        [WebMethod]
        public DataSet GetNewMessageForNotif(int from_user, int to_user)
        {
            DataSet dataSet = new DataSet();
            string query = "SELECT message_text, fr.image as from_image, fr.user_name as from_user_name" +
                " FROM messages m JOIN users fr ON m.send_from_user_id = fr.user_id" +
                " WHERE send_from_user_id = {0} AND send_to_user_id = {1} AND status = 1 ORDER BY message_date ASC";
            query = string.Format(query, from_user, to_user);
            dataSet = conn.Reader(query);
            query = "UPDATE messages SET status = 2 WHERE send_from_user_id = {0} AND send_to_user_id = {1} AND status = 1";
            query = string.Format(query, from_user, to_user);
            conn.Writer(query);
            return dataSet;
        }

        [WebMethod]
        public void SendMessageForUser(string message_txt, int send_from_user_id, int send_to_user_id)
        {
            string query = "INSERT INTO messages(message_text, send_from_user_id, send_to_user_id, status)" +
                " VALUES('{0}', {1}, {2}, 1)";
            query = string.Format(query, message_txt, send_from_user_id, send_to_user_id);
            conn.Writer(query);
        }

        [WebMethod]
        public DataSet CheckUser(string user_name, string phone)
        {
            string query = "SELECT * FROM users WHERE user_name = '{0}' AND phone = '{1}'";
            query = string.Format(query, user_name, phone);
            return conn.Reader(query);
        }
        
        [WebMethod]
        public int LoginUser(int user_id)
        {
            string updateQuery = "UPDATE users SET online = 1 WHERE user_id = " + user_id;
            return conn.Writer(updateQuery);
        }

        [WebMethod]
        public DataSet GetNewMessageForUser(int from_user, int to_user)
        {
            DataSet dataSet = new DataSet();
            string query = "SELECT message_id, message_text, send_from_user_id, send_to_user_id, message_date, status, fr.image as from_image" +
                " FROM messages m JOIN users fr ON m.send_from_user_id = fr.user_id" +
                " WHERE send_from_user_id = {0} AND send_to_user_id = {1} AND status != 3 ORDER BY message_date ASC";
            query = string.Format(query, from_user, to_user);
            dataSet = conn.Reader(query);
            query = "UPDATE messages SET status = 3 WHERE send_from_user_id = {0} AND send_to_user_id = {1} AND status != 3";
            query = string.Format(query, from_user, to_user);
            conn.Writer(query);
            return dataSet;
        }

        [WebMethod]
        public int LogOutUser(int user_id)
        {
            string updateQuery = "UPDATE users SET online = 0, last_appear = GETDATE() WHERE user_id = " + user_id;
            return conn.Writer(updateQuery);
        }

        [WebMethod]
        public DataSet CheckOnline(int user_id)
        {
            string query = "SELECT online, last_appear FROM users WHERE user_id = " + user_id;
            return conn.Reader(query);
        }

        [WebMethod]
        public DataSet CheckStatus(int from_user, int to_user)
        {
            string query = "SELECT message_id, status FROM messages" +
                " WHERE send_from_user_id = {0} AND send_to_user_id = {1} AND status != 1";
            query = string.Format(query, to_user, from_user);
            return conn.Reader(query);
        }

        [WebMethod]
        public int EnterRemoting(int user_id)
        {
            string updateQuery = "UPDATE users SET is_remoting = 1 WHERE user_id = " + user_id;
            return conn.Writer(updateQuery);
        }   

        [WebMethod]
        public int ExitRemoting(int user_id)
        {
            string updateQuery = "UPDATE users SET is_remoting = 0 WHERE user_id = " + user_id;
            return conn.Writer(updateQuery);
        }

        [WebMethod]
        public DataSet GetOnlineRemotingUser(int user_id)
        {
            string query = "SELECT * FROM users WHERE is_remoting = 1 AND user_id != " + user_id;
            return conn.Reader(query);
        }

        [WebMethod]
        public int EditUserName(int user_id, string user_name)
        {
            string updateQuery = "UPDATE users SET user_name = '" + user_name + "' WHERE user_id = " + user_id;
            return conn.Writer(updateQuery);
        }

        [WebMethod]
        public int EditUserAbout(int user_id, string user_about)
        {
            string updateQuery = "UPDATE users SET about = '" + user_about + "' WHERE user_id = " + user_id;
            return conn.Writer(updateQuery);
        }

        [WebMethod]
        public void CreateUser(string user_name, string user_phone, string user_about)
        {
            string query = "INSERT INTO users(user_name, phone, about)" +
                " VALUES('{0}', '{1}', '{2}')";
            query = string.Format(query, user_name, user_phone, user_about);
            conn.Writer(query);
        }

        [WebMethod]
        public DataSet GetUserId(string user_name)
        {
            string query = "SELECT user_id FROM users WHERE user_name = '" + user_name + "'";
            return conn.Reader(query);
        }

        [WebMethod]
        public DataSet CheckIfThereIsContactBetweenThisUsers(int user_id, int chatting_user_id)
        {
            string query = "SELECT COUNT(message_id) FROM messages" +
                " WHERE (send_from_user_id = {0} AND send_to_user_id = {1}) OR (send_from_user_id = {2} AND send_to_user_id = {3})";
            query = string.Format(query, user_id, chatting_user_id, chatting_user_id, user_id);
            return conn.Reader(query);
        }

        [WebMethod]
        public DataSet GetUserData(int user_id)
        {
            string query = "SELECT * FROM users WHERE user_id = {0}";
            query = string.Format(query, user_id);
            return conn.Reader(query);
        }
    }
}
