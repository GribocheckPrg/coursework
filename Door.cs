using System;
using System.Collections.Generic;
using System.IO;

namespace CourseWork
{
	internal class Door{
		private static string Path = "C:/ProgramFiles/BD.csv";
		internal class Product{
			internal string Name;
            internal int Amount;
            internal int NomerSklada;
            public Product(string name, int amount, int nomerSklada)
            {
                Name = name;
                Amount = amount;
                NomerSklada = nomerSklada;
            }
        }
		internal static List<Product> ListOfProducts() { 
			List<Product> products = new();
			string[] ReadedText = File.ReadAllLines(Path);
			foreach (string line in ReadedText)
			{
				string[] ParsedLine = line.Split(',');
				products.Add(new Product(ParsedLine[0], Convert.ToInt32(ParsedLine[1]), Convert.ToInt32(ParsedLine[2])));
			}
			return products;
		}
	}
}
