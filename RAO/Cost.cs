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
        public DateTime date { get; set; }
        public int description { get; set; }
        public decimal costAmont { get; set; }
        public int costQuantity { get; set; }
        public int expenseSheet_id { get; set; }
        public int sheetState_id { get; set; }
       

        public Cost GetCost(string cost_id)
        {
            JObject jsonParse = JObject.Parse(RAO.get("profile/find/" + cost_id));


            return JsonConvert.DeserializeObject<Cost>(jsonParse["content"].ToString());

        }
    }
}
