using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class Menu
    {
        private void Print_menu(string[] choices)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine("\t{0}. {1}",i+1,choices[i]);
            }
        }
        public void Program_menu(RuleParser ruleParser, ESProvider exsys, FactParser fparser)
        {
            string[] choices = new string[] {"Gimme a house","Exit" };
            bool quit = false;
            string choice = "";

            while (!quit)
            {
                Print_menu(choices);
                choice = Console.ReadLine();
                if (choice =="q" || choice == "Q") { quit = true; }

            }
            
        }
    }
}
