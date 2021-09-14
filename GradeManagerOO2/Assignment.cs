using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    class Assignment
    {
        public string name { get; set; }
        public int grade { get; set; }

        public bool status { get; set; }

        public Assignment(string assignmentName, int assignmentGrade, bool assignmentStatus)
        {
            this.name = assignmentName;
            this.grade = assignmentGrade;
            this.status = assignmentStatus;

        }
    }
}
