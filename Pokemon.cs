using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
        string firstName;
        string secondName;
        string thirdName;
        string type;
        int totalForms;
        int currentForm = 1;

        //public Pokemon(string firstName, string secondName, string thirdName, string type, int totalForms)
        public Pokemon(List<string> names, string type, int totalForms)
        {
            //this.firstName = names[0];
            //this.secondName = names[1];
            //this.thirdName = names[2];  Här blir det givetvis null när det inte finns 3 stängar i listan...
            int number = 1;
            foreach (string name in names)
            {
                if (number == 1)
                    this.firstName = name;
                if (number == 2)
                    this.secondName = name;
                if (number == 3)
                    this.thirdName = name;
                number++;
            }
            //this.firstName = firstName;
            //this.secondName = secondName;
            //this.thirdName = thirdName;
            this.type = type;
            this.totalForms = totalForms;
            //this.currentForm = currentForm;
        }

        public void Evolve()
        {
            if(currentForm < totalForms)
            {
                currentForm++;
            }
            else
            {
                Console.WriteLine("This pokemon is already fully evolved!");
            }
        }
        public string GetName()
        {
            if (currentForm == 1)
                return firstName;
            if (currentForm == 2)
                return secondName;
            if (currentForm == 3)
                return thirdName;
            return type; //om inget namn?
        }
        public string GetType()
        {
            return type;
        }
        public int GetTotalForms()
        {
            return totalForms;
        }
        public int GetCurrentForm()
        {
            return currentForm;
        }
    }
}
