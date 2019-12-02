using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace SAFI_Dekstop.RAO
{
    class RAO
    {

        public static RestClient RestClient { get; private set; }

        public static String get(String route)
        {
            //var URL = Properties.Settings.Default.routeAPI+route;
            //var client = new RestClient(URL);
            //client.Authenticator = new HttpBasicAuthenticator(username, password);

            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);

            //get
            RestRequest request = new RestRequest();
            request.Resource = route;
            IRestResponse response = client.Execute(request);

            //Debug.WriteLine(response.Content);
            return response.Content;




        }
    }
}
