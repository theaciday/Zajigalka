using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zajigalka.Models
{
    public class User
    {
        public int Id { get; set; }

        public DateTime DateRegistration { get; set; }

        public DateTime DateLastVisit { get; set; }

    }
}
