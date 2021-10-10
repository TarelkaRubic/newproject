using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newprojectapi.Models
{
    public class User
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public Blob Avatar { get; set; }
    }
}
