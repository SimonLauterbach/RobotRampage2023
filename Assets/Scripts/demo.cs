using System.Collections.Generic;
using System;
using UnityEngine;
using System.Collections;

public class demo: MonoBehaviour
{
     void Start()
    {
        //Create a Dictionary with String key and int value pairs
        Dictionary<string, int> cityPopulation = new Dictionary<string, int>(); //Decleration
        cityPopulation.Add("Tokyo", 3800000);
        cityPopulation.Add("Dehli", 2570000);
        cityPopulation.Add("Shanghai", 23700000);
        cityPopulation.Add("San Paulo", 21100000);
        cityPopulation.Add("Mexio City", 21000000);

        //Read all the Data
        Console.WriteLine("City Population");

        foreach(KeyValuePair<string, int> city in cityPopulation)
        {
            Console.WriteLine("City: " + city.Key + ", Population: " + city.Value);
        }

        Console.WriteLine("Total number of cities: " + cityPopulation.Count);
    }
}
