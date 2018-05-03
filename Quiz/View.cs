using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Quiz
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch(button.Text)
            {
                case "Add":
                    Add();
                    break;
                case "Save Quiz":
                    SaveToXML();
                    break;
                case "Delete":
                    Delete();
                    break;
                case "Edit":
                    Edit();
                    break;
                case "Clear":
                    Clear();
                    break;
                    
            }
        }
        private Question CreateObject()
        {  
            string[] sa = { answer1.AnswerText, answer2.AnswerText, answer3.AnswerText, answer4.AnswerText };
            bool[] ba = { answer1.Proper, answer2.Proper, answer3.Proper, answer4.Proper };
            Question temp = new Question(textBoxQuestion.Text, sa, ba);
            return temp;
        }
        private void Add()
        {
            listBoxQuestions.Items.Add((listBoxQuestions.Items.Count + 1).ToString());
            if (ProperQuestion())
            {
                ThisQuiz.Record(CreateObject());
                Clear();
            }            
       }

        private void Clear()
        {
            textBoxQuestion.Clear();
            answer1.ClearAnswer();
            answer2.ClearAnswer();
            answer3.ClearAnswer();
            answer4.ClearAnswer();
        }
        private void Delete()
        {
            ThisQuiz.RemoveItem(listBoxQuestions.SelectedIndex);
            
            for(int i=listBoxQuestions.SelectedIndex; i < listBoxQuestions.Items.Count-1; i++)
            {
                listBoxQuestions.Items[i + 1] = (i+1).ToString();
            }
            listBoxQuestions.Items.RemoveAt(listBoxQuestions.SelectedIndex);
        }
        private void Edit()
        {
            if (ProperQuestion())
            {
                ThisQuiz.EditItem(listBoxQuestions.SelectedIndex, CreateObject());
                Clear();
            }
        }



        private bool ProperQuestion()
        {
            bool[] ba = { answer1.Proper, answer2.Proper, answer3.Proper, answer4.Proper };
            if (textBoxQuestion.Text == "")
            {
                errorProviderQText.SetError(labelQText, "Fill quiestion text!");
                return false;
            }
            else if (AnswerFilled(answer1))
            {
                errorProviderQText.Clear();
                errorProviderQText.SetError(answer1, "Fill answer text!");
                return false;
            }
            else if (AnswerFilled(answer2))
            {
                errorProviderQText.Clear();
                errorProviderQText.SetError(answer2, "Fill answer text!");
                return false;
            }
            else if (AnswerFilled(answer3))
            {
                errorProviderQText.Clear();
                errorProviderQText.SetError(answer3, "Fill answer text!");
                return false;
            }
            else if (AnswerFilled(answer4))
            {
                errorProviderQText.Clear();
                errorProviderQText.SetError(answer4, "Fill answer text!");
                return false;
            }
            else if (!ba.Contains(true))
            {
                errorProviderQText.Clear();
                errorProviderQText.SetError(answer4, "At least one answer should be true");
                return false;
            }
            else
            {
                errorProviderQText.Clear();
                return true;
            }
        }
        private bool AnswerFilled(Answer a)
        {
            return (a.AnswerText == "");          
        }

        private bool ProperFileName()
        {
            char[] badChars = Path.GetInvalidFileNameChars();
            foreach (char i in badChars)
                if (textBoxName.Text.Contains(i))
                    return false;
            return true;
        }

        private void SaveToXML()
        {
            if (ProperFileName())
            {
                SaveXML.SaveData(ThisQuiz.Value(), @".\" + textBoxName.Text + ".xml");
                ThisQuiz.ClearThemAll();
                listBoxQuestions.Items.Clear();
                errorProviderFName.Clear();
            }
            else
                errorProviderFName.SetError(labelQName, "Give proper filename!");
            

        }

        private void listBoxQuestions_DoubleClick(object sender, EventArgs e)
        {
            Question temp =ThisQuiz.Load(listBoxQuestions.SelectedIndex);
            if (temp != null) 
            {
                textBoxQuestion.Text = temp.questionText;
                AnswerLoad(answer1, temp.properAnswers[0], temp.answers[0]);
                AnswerLoad(answer2, temp.properAnswers[1], temp.answers[1]);
                AnswerLoad(answer3, temp.properAnswers[2], temp.answers[2]);
                AnswerLoad(answer4, temp.properAnswers[3], temp.answers[3]);
            }
        }

        private void AnswerLoad(Answer answer, bool check, string text)
        {
            answer.AnswerText = text;
            answer.Proper = check;
        }
    }
}
