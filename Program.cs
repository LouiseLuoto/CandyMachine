using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Xml.Schema;
    class Candy
    {
        public string name;
        public int total;
    }
    class Program
    {
        static void Main(string[] args)
        {   /*Skapa ett program för en godisautomat i vilken det finns ett antal godisbitar. Som 
            användare får man skriva in ett nummer på luckan som man vill köpa från. Första 
            godisbiten ligger på lucka 1, andra godisbiten på lucka 2 osv. Varje gång man köper en
            godisbit minskar antalet av just den typen. Användaren får fortsätta köpa godisbitar så
            länge han eller hon vill (och även fortsätta och stirra på automaten när den är tom). Det
            kan aldrig bli färre än 0 godisbitar i en lucka, istället får användaren ett meddelande
            att just den typen av godisbitar är slut. För att göra det enklare för dig, använd en 
            klass med namnet Candy som håller reda på godisets namn och antal. Du kan köra med 
            publika variabler. Skapar sedan en datastruktur av typen List<T> som och fyll på den med
            allt godis som ska finnas i godisautomaten.*/
List<Candy> candies = new List<Candy>();
Candy candy = new Candy();
candy.name = "1. Bubs";
candy.total = 0;
candies.Add(candy);

candy = new Candy();
candy.name = "2. Marianne";
candy.total = 5;
candies.Add(candy);

candy = new Candy();
candy.name = "3. Djungelvrål";
candy.total = 5;
candies.Add(candy);

candy = new Candy();
candy.name = "4. Tutti Frutti";
candy.total = 5;
candies.Add(candy);

bool isRunning = true;
while (isRunning)
{
    for (int i = 0; i < candies.Count; i++)         
        Console.WriteLine(candies[i].name + " " + candies[i].total);
    Console.Write("Type B to buy / E to end: ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case ("b" or "B"):
            Console.Write("Pick one candy by number: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (candy.total <= 0)
                Console.WriteLine("Empty slot!");
            else if(candy.total != 0)
                candies[index-1].total--;
            break;
        case "e" or "E":
            isRunning = false;
            break;
    }
        }
    }
}

