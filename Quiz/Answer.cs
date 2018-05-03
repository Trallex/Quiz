using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Answer : UserControl
    {
        public Answer()
        {
            InitializeComponent();
        }

        public string AnswerText
        {
            get { return textBoxAnswer.Text; }
            set { textBoxAnswer.Text = value; }
        }
        public bool Proper
        {
            get
            {
                return checkBox.Checked;
            }
            set
            {
                checkBox.Checked = value;
            }
        }
        public void ClearAnswer()
        {
            textBoxAnswer.Clear();
            checkBox.Checked = false;
        }
    }
}
