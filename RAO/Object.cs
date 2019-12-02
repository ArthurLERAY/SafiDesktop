using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SAFI_Dekstop.RAO
{
    public class Object
    {
        /* static Object client = new Object();

         static async Task RunAsync()
         {
             // Update port # in the following line.
             client.BaseAddress = new Uri("http://localhost:52080/");
             client.DefaultRequestHeaders.Accept.Clear();
             client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

             static async Task<Product> GetProductAsync(string path)
             {
                 Product product = null;
                 HttpResponseMessage response = await client.GetAsync(path);
                 if (response.IsSuccessStatusCode)
                 {
                     product = await response.Content.ReadAsAsync<Product>();
                 }
                 return product;
             }

             static async Task<Uri> CreateProductAsync(Product product)
             {
                 HttpResponseMessage response = await client.PostAsJsonAsync(
                     "api/products", product);
                 response.EnsureSuccessStatusCode();

                 // return URI of the created resource.
                 return response.Headers.Location;
             }

             static async Task<Product> UpdateProductAsync(Product product)
             {
                 HttpResponseMessage response = await client.PutAsJsonAsync(
                     $"api/products/{product.Id}", product);
                 response.EnsureSuccessStatusCode();

                 // Deserialize the updated product from the response body.
                 product = await response.Content.ReadAsAsync<Product>();
                 return product;
             }

             static async Task<HttpStatusCode> DeleteProductAsync(string id)
             {
                 HttpResponseMessage response = await client.DeleteAsync(
                     $"api/products/{id}");
                 return response.StatusCode;
             }

         }*/
    }
}
    
