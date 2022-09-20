
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project1
{
    public class Education : CV
    {
        public Education(string introduction) : base(introduction)
        {
        }

        new public void display()
        {
            string[] level = new string[] { "Level 1", "Level 2", "Level 3", "Go Back" };
            Console.WriteLine("---Edcation---");
            Console.WriteLine("Course: Computer Science");
            for (int i = 0; i < level.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + level[i]);
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
                        Console.WriteLine("-Communication and Business Skills for IT, Computer Programming, Computer Architecture, Computation and Formal Systems, Computational Mathematics, Database Design,Practical Training \n");
                        break;
                    case 2:
                        Console.WriteLine("-Algorithms and Complexities, Object-Oriented Techniques, Operating Systems, User Interface Design and Computer Graphics, Web-Centric Computing, Software Engineering and Project Management, Industrial Training");
                        break;
                    case 3:
                        Console.WriteLine("-Computer Networks and SystemAdministration, Capacity Planning and Intelligent Systems, Parallel and Distributed Systems, Computer Systems Security, Wireless Networking and Ubiquitous Technologies, Computer Vision, Biometrics and Pattern Recognition, Multimedia and Real-Time Systems");
                        break;
                    case 4:
                        GoBack();
                        break;



                }
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

            }
        }

        //new public void GoBack()
       // {

        //    display();
       // }

    }
}

