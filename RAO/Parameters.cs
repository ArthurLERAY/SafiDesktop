using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SAFI_Dekstop.RAO
{
    class sheet
    {
        public String id { get; set; }
        public String  name { get; set; }

        public sheet GetParemetres(string parameters_id)
        {
            JObject jsonParse = JObject.Parse(RAO.get("profile/find/" + parameters_id));


            return JsonConvert.DeserializeObject<sheet>(jsonParse["content"].ToString());

        }
    }
}
