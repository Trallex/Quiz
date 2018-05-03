namespace Quiz
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelQName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelXML = new System.Windows.Forms.Label();
            this.labelQText = new System.Windows.Forms.Label();
            this.labelQuestions = new System.Windows.Forms.Label();
            this.errorProviderQText = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.answer4 = new Quiz.Answer();
            this.answer3 = new Quiz.Answer();
            this.answer2 = new Quiz.Answer();
            this.answer1 = new Quiz.Answer();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(23, 30);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(840, 139);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(725, 372);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 50);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save Quiz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(23, 372);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(138, 50);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(891, 76);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(121, 355);
            this.listBoxQuestions.TabIndex = 7;
            this.listBoxQuestions.DoubleClick += new System.EventHandler(this.listBoxQuestions_DoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(201, 372);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(138, 50);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(380, 372);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 50);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(554, 372);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(138, 50);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1806, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelQName
            // 
            this.labelQName.AutoSize = true;
            this.labelQName.Location = new System.Drawing.Point(899, 11);
            this.labelQName.Name = "labelQName";
            this.labelQName.Size = new System.Drawing.Size(60, 13);
            this.labelQName.TabIndex = 12;
            this.labelQName.Text = "Quiz name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(891, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(98, 20);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.Text = "quizdata";
            // 
            // labelXML
            // 
            this.labelXML.AutoSize = true;
            this.labelXML.Location = new System.Drawing.Point(993, 33);
            this.labelXML.Name = "labelXML";
            this.labelXML.Size = new System.Drawing.Size(25, 13);
            this.labelXML.TabIndex = 14;
            this.labelXML.Text = ".xml";
            // 
            // labelQText
            // 
            this.labelQText.AutoSize = true;
            this.labelQText.Location = new System.Drawing.Point(23, 11);
            this.labelQText.Name = "labelQText";
            this.labelQText.Size = new System.Drawing.Size(72, 13);
            this.labelQText.TabIndex = 15;
            this.labelQText.Text = "Question text:";
            // 
            // labelQuestions
            // 
            this.labelQuestions.AutoSize = true;
            this.labelQuestions.Location = new System.Drawing.Point(899, 62);
            this.labelQuestions.Name = "labelQuestions";
            this.labelQuestions.Size = new System.Drawing.Size(57, 13);
            this.labelQuestions.TabIndex = 16;
            this.labelQuestions.Text = "Questions:";
            // 
            // errorProviderQText
            // 
            this.errorProviderQText.ContainerControl = this;
            // 
            // errorProviderFName
            // 
            this.errorProviderFName.ContainerControl = this;
            // 
            // answer4
            // 
            this.answer4.AnswerText = "";
            this.answer4.Location = new System.Drawing.Point(446, 257);
            this.answer4.Name = "answer4";
            this.answer4.Proper = false;
            this.answer4.Size = new System.Drawing.Size(417, 76);
            this.answer4.TabIndex = 4;
            // 
            // answer3
            // 
            this.answer3.AnswerText = "";
            this.answer3.Location = new System.Drawing.Point(23, 257);
            this.answer3.Name = "answer3";
            this.answer3.Proper = false;
            this.answer3.Size = new System.Drawing.Size(417, 76);
            this.answer3.TabIndex = 3;
            // 
            // answer2
            // 
            this.answer2.AnswerText = "";
            this.answer2.Location = new System.Drawing.Point(446, 175);
            this.answer2.Name = "answer2";
            this.answer2.Proper = false;
            this.answer2.Size = new System.Drawing.Size(417, 76);
            this.answer2.TabIndex = 2;
            // 
            // answer1
            // 
            this.answer1.AnswerText = "";
            this.answer1.Location = new System.Drawing.Point(23, 175);
            this.answer1.Name = "answer1";
            this.answer1.Proper = false;
            this.answer1.Size = new System.Drawing.Size(417, 76);
            this.answer1.TabIndex = 1;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 443);
            this.Controls.Add(this.labelQuestions);
            this.Controls.Add(this.labelQText);
            this.Controls.Add(this.labelXML);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelQName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.textBoxQuestion);
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "JKQuiz Generator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private Answer answer1;
        private Answer answer2;
        private Answer answer3;
        private Answer answer4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelQName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelXML;
        private System.Windows.Forms.Label labelQText;
        private System.Windows.Forms.Label labelQuestions;
        private System.Windows.Forms.ErrorProvider errorProviderQText;
        private System.Windows.Forms.ErrorProvider errorProviderFName;
    }
}

