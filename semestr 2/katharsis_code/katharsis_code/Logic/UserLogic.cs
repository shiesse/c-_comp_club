using System;
using System.Windows.Forms;
using System.Linq;

namespace katharsis_code.Logic
{
    public class UserLogic
    {
        public static User GetUser(string login, string password)
        {
            try
            {
                Context c = new Context();
                return (from user in c.Users
                        where user.Login == login && user.Password == password
                        select user).FirstOrDefault();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
