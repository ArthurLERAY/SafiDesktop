using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SAFI_Dekstop.RAO
{
    class LoginRAO
    {
        public static Login getLogin(String login, String pwd)
        {
            var routeLogin = "login/" + login + "/" + pwd;

            //Debug.WriteLine(routeLogin);
            var json = RAO.get(routeLogin);

            Debug.WriteLine(json);
            Login unLogin = JsonConvert.DeserializeObject<Login>(json);

            //Debug.WriteLine(unLogin);
            //Debug.WriteLine(unLogin.address);
            return unLogin;



        }
    }
}
