using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    public class Groups

    {
      
        public string Name { set; get; }

        public string Discription { set; get; }

        public Groups(string Name, string Discription)
        {

            
            this.Name = Name;
            this.Discription = Discription;
        }
    }
}
