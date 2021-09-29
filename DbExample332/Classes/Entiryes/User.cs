using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample332.Classes.Entiryes
{
    public class User
    {
        public int UserId;
        public string UserName;
        public string UserLogin;
        public string UserPass;

        public User(DataRow row) {
            UserId = Convert.ToInt32(row["UserId"]);
            UserName = Convert.ToString(row["UserName"]);
            UserLogin = Convert.ToString(row["UserLogin"]);
            UserPass = Convert.ToString(row["UserPass"]);
        }

        public User() { }

        public static List<User> Select() {
            List<User> users = new List<User>();
            foreach (DataRow row in DbConnector.Select("Select * from Users").Rows) {
                users.Add(new User(row));
            }
            return users;
        }

        //INSERT INTO `Users` (`UserName`, `UserLogin`, `UserPass`) VALUES ('1', '1', '1');
        /// <summary>
        /// Метод добавления нового пользователя
        /// </summary>
        /// <param name="UserName">Имя пользователя</param>
        /// <param name="UserLogin">Логин</param>
        /// <param name="UserPass">Пароль</param>
        public static void Add(string UserName, string UserLogin, string UserPass) {
            DbConnector.Select("INSERT INTO `Users` (`UserName`, `UserLogin`, `UserPass`) VALUES ('"+UserName+"', '"+UserLogin+"', '"+UserPass+"');");
        }

        public void Change(string UserName, string UserLogin, string UserPass) {
            DbConnector.Select("UPDATE `Users` SET `UserName` = '"+UserName+"', `UserLogin` = '"+UserLogin+"', `UserPass` = '"+UserPass+"' WHERE (`UserId` = '"+UserId+"');");
        }
    }
}
