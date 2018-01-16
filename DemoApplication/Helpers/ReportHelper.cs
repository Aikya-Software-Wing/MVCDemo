using DemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Helpers
{
    public class ReportHelper
    {
        public static List<StudentAverageViewModel> GetStudentAverages()
        {
            List<StudentAverageViewModel> result = new List<StudentAverageViewModel>();
            StudentModel db = new StudentModel();

            foreach (var student in db.Students.ToList())
            {
                result.Add(new StudentAverageViewModel
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Average = student.Marks.Sum(x => x.MarksObtained) / (decimal)student.Marks.Count()
                });
            }

            return result;
        }
    }
}