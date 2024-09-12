using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    public class Users
    {
        public string ImageUrl { get; set; }
        public string Name { set; get; }
        
        public string More { set; get; }

        public Users(string ImageUrl, string Name, string More)
        {
           
            this.ImageUrl = ImageUrl;
            this.Name = Name;
            this.More = More;
        }


    }
}
