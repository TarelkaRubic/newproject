using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newprojectapi.Models
{
    public class User
    {
        public string login { get; set; }
        public int Id { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public Blob Avatar { get; set; }
    }
}
