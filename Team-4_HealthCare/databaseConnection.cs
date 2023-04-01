using System.IO;
using System.Linq;
using System.Text.Json;

namespace Team_4_HealthCare
{
    internal class databaseConnection
    {


        internal LoginList[] getUsers()
        {
            string loginjson = File.ReadAllText("C:\\Users\\namir\\source\\repos\\Team-4_HealthCare\\Team-4_HealthCare\\loginDetails.json");
            LoginarrayList jsonObject = JsonSerializer.Deserialize<LoginarrayList>(loginjson);
            LoginList[] Result = jsonObject.LoginLists;
            return Result;
        }

        public bool getVaildUser(string UserID, string passcode)
        {
            LoginList[] loginList = getUsers();
            LoginList result = loginList.FirstOrDefault(item => item.userName == UserID && item.password == passcode);
            return result != null;
        }

    }
}

