

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project1
{
    public class JobDescription : CV
    {
        public JobDescription(string introduction) : base(introduction)
        {
        }

        new public void display()
        {
            string[] description = new string[] { "Ceridian Mauritius(2021)", "Telecome mauritius(2020)", "Go back" };
            Console.WriteLine("---JOB DESCRIPTION---");
            for (int i = 0; i < description.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + description[i]);
            }

            Console.WriteLine("\n");
        }

        new public void makeChoice()
        {
            Console.WriteLine("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != -1)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Designing, building and maintaining custom HCM solutions \n");
                        break;
                    case 2:
                        Console.WriteLine("Responsible for the installation, configuration, administration, monitoring, maintenance, upgrading and support of Emtel’s Datacom network infrastructure. \n");
                        break;
                    case 3:
                        GoBack();
                        break;



                }
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

            }
        }

        //new public void GoBack()
        //{

          //  display();
        //}

    }
}
