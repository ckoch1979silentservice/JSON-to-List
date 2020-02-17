﻿using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;


namespace ConsoleApp1
{
    public class MenuItem
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Name { get; set; }
        public string ImageFile { get; set; }
    }


    class Program
    {

        static void Main(string[] args)
        {
            var webclient = new WebClient();
            var json = webclient.DownloadString(@"C:\Users\c.koch.KOCH\source\repos\ConsoleApp1\ConsoleApp1\data.json");
            List<MenuItem> model = JsonConvert.DeserializeObject<List<MenuItem>>(json);

            foreach (var item in model)
            {
                Console.WriteLine("ID: " + item.ID + " " + "Name: " + item.Name);
            }
        }
    }
}
