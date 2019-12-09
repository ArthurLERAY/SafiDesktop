using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SAFI_Dekstop.RAO
{
    class Employee
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string phoneNumber { get; set; }
        public string cellPhoneNumber { get; set; }
        public string email { get; set; }
        public string socialSecurityNumber { get; set; }
        public string grossSalary { get; set; }

        /// <summary>
        /// Récupère un Employe par son ID
        /// </summary>
        /// <param name="userId">ID de l'employé</param>
        /// <returns>Employe</returns>
        public Employee GetById(string userId)
        {

            // Transforme la chaine de caractère du RAO en objet JSON = parser
            JObject jsonParse = JObject.Parse(RAO.get("profile/find/" + userId));

            // Retourne un objet de la classe Employee à partir de la chaine de caractère de l'objet JSON parsé avec clef "content"
            return JsonConvert.DeserializeObject<Employee>(jsonParse["content"].ToString());
        }

    }
}
