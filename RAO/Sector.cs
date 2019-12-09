using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SAFI_Dekstop.RAO
{
    class Sector
    {
        public string id { get; set; }
        public string name { get; set; }



        /// <param name="sector_id">ID de l'employé</param>
        public Sector GetById(string sector_id)
        {
            JObject jsonParse = JObject.Parse(RAO.get("profile/find/" + sector_id));


            return JsonConvert.DeserializeObject<Sector>(jsonParse["content"].ToString());

        }
    }
   
}
