using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SAFI_Dekstop.RAO
{
    class Parameters
    {
        public string id { get; set; }
        public string name { get; set; }


        public Parameters GetById(string parameters_id)
        {
            JObject jsonParse = JObject.Parse(RAO.get("profile/find/" + parameters_id));


            return JsonConvert.DeserializeObject<Parameters>(jsonParse["content"].ToString());

        }
    }
}
