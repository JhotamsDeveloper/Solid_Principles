using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model_Solid_Principles_1_O
{
    public class Staff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        //public bool IsDoctor { get; set; } = false; 
        public Role Role { get; set; }
    }
}
