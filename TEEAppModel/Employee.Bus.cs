using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEAppModel
{
    public partial class Employee
    {
        public String FullName { get { return this.FirstName + " " + this.LastName; } }
    }
}
