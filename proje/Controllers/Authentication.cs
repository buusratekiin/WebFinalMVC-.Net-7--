using Service.Models;

namespace Service.Models
{
    public class Authentication
    {
        public string ErrorMessage {get;set;}
        public bool UsernamePasswordControl(string username, string password)
        {
            if (username == "admin" && password == "1234") // logic.......
                return true;
            else
            {
                ErrorMessage = "kullanıcı adı bulunamadı.";
                return false; // kullanıcı adı bulunamadı.
            }

        }

        public bool UsernamePasswordControlFromDB(string username, string password)
        {
            if (username == "admin" && password == "1234") // DB.......
                return true;
            else
                return false;
        }
    }
}
