﻿using Inova.Farm.SistemaInterfaceWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Inova.Farm.WebService
{
    public class ServiceIrrigation
    {

        public ServiceIrrigation()
        {

        }

        public WebClient Client { get; set; }
        
        
        public async Task<Irrigation> CalculateIrrigation(User user, CurrentProduction production)
        {
            HttpClient client = new HttpClient();
            Irrigation irrigation = new Irrigation();
            HttpResponseMessage response = new HttpResponseMessage();
            if (response.IsSuccessStatusCode)
            {
                Stream stream = await response.Content.ReadAsStreamAsync();
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        //faz alguma coisa com esse dado
                    }
                }
            }
            
            
            return null;

        }

    }
}
