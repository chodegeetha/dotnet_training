using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Base URL of the RESTful API
            // Base URL of the RESTful API
            string baseUrl = "http://localhost:62881/api/values";

            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send a GET request to retrieve all products
                    HttpResponseMessage response = client.GetAsync(baseUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine("Response from server:");
                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Failed to retrieve values. Status code: " + response.StatusCode);
                    }

                    // You can send other types of requests (POST, PUT, DELETE) in a similar way
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }



            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Prepare the data to be sent in the POST request
                    string jsonData = @"
                        {
                              
                                ""value"": ""Himaja""
                        }";

                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Send a POST request to add a new product
                    HttpResponseMessage Postresponse = client.PostAsync(baseUrl, content).Result;

                    if (Postresponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Values added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to add value. Status code: " + Postresponse.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }




            // PUT request
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string updateValue = "Updated Value";
                    string updateJsonData = $"{{ \"value\": \"{updateValue}\" }}";
                    StringContent updateContent = new StringContent(updateJsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage updateResponse = client.PutAsync(baseUrl + "/1", updateContent).Result;
                    if (updateResponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Value updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to update value. Status code: " + updateResponse.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // DELETE request
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage deleteResponse = client.DeleteAsync(baseUrl + "/0").Result;
                    if (deleteResponse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Value deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete value. Status code: " + deleteResponse.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
        
    

 