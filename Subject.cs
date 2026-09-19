using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    internal class Subject
    {
        public Subject(int sudjectId, string sudjectName)
        {
            SudjectId = sudjectId;
            SudjectName = sudjectName;
        }

        public int SudjectId { get; set; }
        public string SudjectName { get; set; }
        public Exam SubjectExam { get; set; }


        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
        }

        public override string ToString()
        {
            return $"Subject : [{SudjectId}]-{SudjectName}";
        }

    }
}
