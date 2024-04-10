using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace malka_Project
{
    public class students_data
    {
        public string UserDetails()
        {
                Dictionary<int, Student> states = new Dictionary<int, Student>();
            {
                for (int i = 0; i < 10; i++)
                {
                    states.Add(i, new Student());
                }
            }
            return 
        }
    }
}
