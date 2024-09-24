using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    public class Tasks_Completed
    {
        public string Nametask { set; get; }

        public Tasks_Completed(string Nametask)
        {

            this.Nametask = Nametask;
        }
    }
}
