using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace malka_Project
{
    internal class AppConsole
    {
        public int GetUserPick()
        {
            Console.WriteLine("1.register" + Environment.NewLine +
                              "2.");
            string userpick = Console.ReadLine();
            int pick;
            Int32.TryParse(userpick, out pick);
            return pick;


            

        }
    }
}
