using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace SAFI_Dekstop.RAO
{
    class Login
    {
        public Int64 id { get; set; }
        public String code { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String login { get; set; }
        public String password { get; set; }
        public String address { get; set; }
        public String postalCode { get; set; }
        public String city { get; set; }
        public String phone { get; set; }
        public String hireDate { get; set; }
        public String timespan { get; set; }
        public String api_token { get; set; }
        public String district_id { get; set; }
        
         public static Login getLogin(String login, String pwd)
         {
            var routeLogin = "login/" + login + "/" + pwd;

              
            var json = RAO.get(routeLogin);

              
            Login unLogin = JsonConvert.DeserializeObject<Login>(json);

               
            //Debug.WriteLine(unLogin.address);
            return unLogin;

         }
        
    }
}
