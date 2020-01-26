using System;
using System.Collections.Generic;
using System.Text;

namespace MyroWebApp.Xamarin.Entities.Grades
{
    public class Term
    {
        public string Name { get; set; }
        public decimal ObtainedScore { get; set; }
        public decimal AverageScore { get; set; }
        public List<Course> Courses { get; set; }
    }
}
