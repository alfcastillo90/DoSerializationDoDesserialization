﻿using System;
using Newtonsoft.Json;
namespace SeDes
{
    class Program
    {
        public static string DoSerialization(){
            Rocket[] rockets = {
                new Rocket{ ID = 0, Builder = "NASA", Target = "Moon", Speed=7.8},
                new Rocket{ ID = 1, Builder = "NASA", Target = "Mars", Speed=10.9},
                new Rocket{ ID = 2, Builder = "NASA", Target = "Kepler-452b", Speed=42.1},
                new Rocket{ ID = 3, Builder = "NASA", Target = "N/A", Speed=0}
            }; 
            var json = JsonConvert.SerializeObject(rockets);
            return json;
        }
        public static void DoDesserialization(string json){
            var rockets = JsonConvert.DeserializeObject<Rocket[]>(json);
            foreach(var r in rockets){
                System.Console.WriteLine($"ID:{r.ID} Builder:{r.Builder} Target:{r.Target} Speed:{r.Speed}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var json = DoSerialization();
            System.Console.WriteLine(json);
            System.Console.WriteLine("===========");
            DoDesserialization(json);
        }
    }
}
