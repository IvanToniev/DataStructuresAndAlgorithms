using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Employer
    {
        public int Id { get; set; }
        public long Salary { get; set; }
        public List<Employer> Employers { get; set; }

        public Employer(int id)
        {
            this.Id = id;
            this.Employers = new List<Employer>();
        }
    }
}
