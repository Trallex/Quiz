using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quiz
{
    public class Question
    {
        public string questionText;
        public string[] answers;
        public bool[] properAnswers;

        public Question(string questionText, string[] answers, bool[] properAnswers)
        {
            this.questionText = questionText;
            this.answers = answers;
            this.properAnswers = properAnswers;
        }
        public Question()
        {
            this.questionText = "..";
            this.answers = null;
            this.properAnswers = null;
        }
    }
    public static class ThisQuiz
    {
        public static List<Question> list;
        static ThisQuiz()
        {
            list = new List<Question>();
        }
        public static void Record(Question value)
        {
            list.Add(value);
        }
        public static void RemoveItem(int number)
        {
            list.RemoveAt(number);
        }
        public static void EditItem(int number, Question value)
        {
            RemoveItem(number);
            list.Insert(number, value);

        }
        public static void ClearThemAll()
        {
            list.Clear();
        }
        public static List<Question> Value()
        {
            return list;
        }
        public static Question Load(int num)
        {
                return list[num];
        }
    }
}
