using System;
using System.Collections.Generic;

namespace MyroWebApp.Xamarin.Entities
{
    public class Grades
    {
        public List<Term> Terms { get; set; }
    }

    public class Term
    {
        public string Name { get; set; }
        public decimal ObtainedScore { get; set; }
        public decimal AverageScore { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public decimal ObtainedScore { get; set; }
        public decimal AverageScore { get; set; }
        public List<Test> Tests { get; set; }
    }

    public class Test
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public decimal ObtainedScore { get; set; }
        public decimal AverageScore { get; set; }
        public decimal MaxScore { get; set; }
        public DateTime Date { get; set; }
    }
}
