using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    public class Assignment
    {
        public string Name { get; }

        private int _grade = 0;
        public int Grade 
        {
            get
            {
                return _grade;
            } 
            set 
            {
                Grade = value;
                if (Grade >= 0)
                {
                    CompletionStatus = true;
                }
            } 
        }
        public bool CompletionStatus { get; private set; } = false;                
        public Assignment(string assignmentName)
        {
            this.Name = assignmentName;
        }       
    }
}
