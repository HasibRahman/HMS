using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.EntityLayer
{
    public class Physician
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentId { get; set; }
        public string Qualifications { get; set; }
        public int Experience { get; set; }
        public string State { get; set; }
        public string  Plan { get; set; }
    }
}
