

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project1
{
    public class CV
    {
        protected string introduction;
        


        public CV(string introduction)
        {
            this.introduction = introduction;
           

        }

        public string getIntroduction()
        {
            return introduction;
        }
      
        public void display()
        {
            string[] mainmenuOption = new string[] { "Experience/Job history", "Education/Training", "Skills", "Technological Skills", "Contact Details", "Get back" };
            Console.WriteLine("---INTRODUCTION---");
            Console.WriteLine(introduction + "\n");
            Console.WriteLine("---DETAILS' MENU---");
            for (int i = 0; i < mainmenuOption.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + mainmenuOption[i]);
            }

            Console.WriteLine("\n");
        }

        public void makeChoice()
        {
            Console.WriteLine("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != -1)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Experience/Job History: \n");
                        JobDescription job = new JobDescription(introduction);
                        job.display();
                        job.makeChoice();
                        break;
                    case 2:
                        Console.WriteLine("Education/Training: \n");
                        Education levels = new Education(introduction);
                        levels.display();
                        levels.makeChoice();
                        break;
                    case 3:
                        Console.WriteLine("Skills: \n");
                        Console.WriteLine("1. Interpersonal skills\r\n2. Leadership skills\n");
                        break;
                    case 4:
                        Console.WriteLine("Technological Skills: \n");
                        Console.WriteLine("1. Java\r\n2. C++\r\n3. HTML\n");
                        break;
                    case 5:
                        Console.WriteLine("Contact Deatails: \n");
                        Console.WriteLine("+30-2106019311 (landline)\r\n+30-6977664062 (mobile phone)\r\n+30-2106398905 (fax)\n");
                        break;
                    case 6:
                        GoBack();
                        break;


                }
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

            }
        }

        public void GoBack()
        {
            Console.Clear();
            display();
        }


    }



}

