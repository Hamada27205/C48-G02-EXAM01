using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    //internal abstract class Question : ICloneable , IComparable<Question>
    //{

    //    public string Header { get; set; }
    //    public string Body { get; set; }
    //    public int Mark { get; set; }

    //    public Answer[] AnswerList { get; set; }

    //    public int RightAnswerId { get; set; }


    //    public Question(string header, string body, int mark)
    //    {
    //        Header = header;
    //        Body = body;
    //        Mark = mark;
    //    }
    //    public Question (string header, string body, int mark, Answer[] answerList, int rightAnswerId):this( header,  body, mark)
    //    {
    //        AnswerList = answerList;
    //        RightAnswerId = rightAnswerId;
    //    }

    //   public abstract void DisplayQuestion();

    //    public override string ToString()
    //    {
    //        return $"Header: {Header} | Body: {Body} | Mark: {Mark} | Answers: {AnswerList.Length} | Right Answer Id: {RightAnswerId}";
    //    }

    //    public int CompareTo(Question other)
    //    {
    //        if (other == null) return 1;
    //        return Mark.CompareTo(other.Mark);
    //    }

    //    public virtual object Clone() 
    //    {

    //        Question clone =(Question) MemberwiseClone();
    //        clone.AnswerList = (Answer[])AnswerList.Clone();
    //        return clone;
    //    }

    //}
}
