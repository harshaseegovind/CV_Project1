

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CV CVintro = new CV("I am Seegovind Harsha. BSc(hons) Computer Science degree.");
            //Console.WriteLine(CVintro.getIntroduction());
            string intro = "I am Seegovind Harsha. BSc(hons) Computer Science degree.";
            //string[] mainmenu = new string[] { "Experience/Job history", "Education/Training", "Skills", "Technological Skills", "Contact Details", "Get back" };


            CV CVmain = new CV(intro);
            CVmain.display();
            CVmain.makeChoice();



            Console.ReadLine();

        }
    }
}

