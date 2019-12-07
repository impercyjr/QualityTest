using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp1.models
{
    class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateAt { get; set; }
        public Status status { get; set; }
        

    }

        public bool IsNewStudent()
    {
        return (DateTime.Now - this.CreateAt).TotalDay < 60);
    }
    public bool IsDeactive()
    {
        if (this.status == 0)
        {
            return true;
        }
        else return false;
    }
    public enum Status
    {
        Active = 1
        Deactive = 0

    }

}
