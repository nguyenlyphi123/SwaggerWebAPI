using System;
using System.Collections.Generic;

#nullable disable

namespace CoreAPI.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public int? StudentClassId { get; set; }
    }
}
