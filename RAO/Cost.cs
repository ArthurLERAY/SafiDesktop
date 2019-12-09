using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace SAFI_Dekstop.RAO
{
    class Cost
    {
        public int id { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public string costAmount { get; set; }
        public string costQuantity { get; set; }
        public string expenseSheet { get; set; }
        public string sheetState_id { get; set; }

        public Cost GetById(string cost_id)
        {
            JObject jsonParse = JObject.Parse(RAO.get("profile/find/" + cost_id));


            return JsonConvert.DeserializeObject<Cost>(jsonParse["content"].ToString());

        }
    }
}
