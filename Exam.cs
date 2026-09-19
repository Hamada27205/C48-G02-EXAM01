using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    internal abstract class Exam : ICloneable
    {
        public Exam(TimeSpan time, int numberOfQuestion)
        {
            Time = time;
            NumberOfQuestion = numberOfQuestion;
            Questions = new List<Question>();
        }

        public TimeSpan Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public List<Question> Questions { get; set; }

        public abstract void ShowExam();

        public virtual object Clone()
        {
            Exam clone = (Exam)MemberwiseClone();
            clone.Questions = new List<Question>(Questions);
            return clone;
        }

    }
}
