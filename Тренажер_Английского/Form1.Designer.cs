namespace Тренажер_Английского
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonTrue = new System.Windows.Forms.Button();
            this.buttonFalse = new System.Windows.Forms.Button();
            this.textBoxChoice_Play = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxTranslate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKeyBoard = new System.Windows.Forms.TextBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.labelTransWord = new System.Windows.Forms.Label();
            this.button1Start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelеToTrans = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2Start = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(52, 53);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(214, 26);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonTrue
            // 
            this.buttonTrue.Location = new System.Drawing.Point(676, 223);
            this.buttonTrue.Name = "buttonTrue";
            this.buttonTrue.Size = new System.Drawing.Size(128, 58);
            this.buttonTrue.TabIndex = 1;
            this.buttonTrue.Text = "Правильно";
            this.buttonTrue.UseVisualStyleBackColor = true;
            // 
            // buttonFalse
            // 
            this.buttonFalse.Location = new System.Drawing.Point(852, 223);
            this.buttonFalse.Name = "buttonFalse";
            this.buttonFalse.Size = new System.Drawing.Size(133, 58);
            this.buttonFalse.TabIndex = 2;
            this.buttonFalse.Text = "Неправильно";
            this.buttonFalse.UseVisualStyleBackColor = true;
            // 
            // textBoxChoice_Play
            // 
            this.textBoxChoice_Play.Location = new System.Drawing.Point(67, 239);
            this.textBoxChoice_Play.Name = "textBoxChoice_Play";
            this.textBoxChoice_Play.Size = new System.Drawing.Size(316, 26);
            this.textBoxChoice_Play.TabIndex = 3;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(79, 103);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(166, 51);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Добавить слово";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonInput_MouseClick);
            // 
            // textBoxTranslate
            // 
            this.textBoxTranslate.Location = new System.Drawing.Point(290, 53);
            this.textBoxTranslate.Name = "textBoxTranslate";
            this.textBoxTranslate.Size = new System.Drawing.Size(212, 26);
            this.textBoxTranslate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "English";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Русский";
            // 
            // textBoxKeyBoard
            // 
            this.textBoxKeyBoard.Location = new System.Drawing.Point(653, 552);
            this.textBoxKeyBoard.Name = "textBoxKeyBoard";
            this.textBoxKeyBoard.Size = new System.Drawing.Size(191, 26);
            this.textBoxKeyBoard.TabIndex = 11;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(715, 170);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(57, 20);
            this.labelWord.TabIndex = 12;
            this.labelWord.Text = "Слово";
            // 
            // labelTransWord
            // 
            this.labelTransWord.AutoSize = true;
            this.labelTransWord.Location = new System.Drawing.Point(874, 170);
            this.labelTransWord.Name = "labelTransWord";
            this.labelTransWord.Size = new System.Drawing.Size(77, 20);
            this.labelTransWord.TabIndex = 13;
            this.labelTransWord.Text = "Перевод";
            // 
            // button1Start
            // 
            this.button1Start.Location = new System.Drawing.Point(67, 452);
            this.button1Start.Name = "button1Start";
            this.button1Start.Size = new System.Drawing.Size(134, 59);
            this.button1Start.TabIndex = 14;
            this.button1Start.Text = "Начать";
            this.button1Start.UseVisualStyleBackColor = true;
            this.button1Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1Start_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Первая игра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Вторая игра";
            // 
            // labelеToTrans
            // 
            this.labelеToTrans.AutoSize = true;
            this.labelеToTrans.Location = new System.Drawing.Point(906, 555);
            this.labelеToTrans.Name = "labelеToTrans";
            this.labelеToTrans.Size = new System.Drawing.Size(57, 20);
            this.labelеToTrans.TabIndex = 17;
            this.labelеToTrans.Text = "Слово";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Перевод";
            // 
            // button2Start
            // 
            this.button2Start.Location = new System.Drawing.Point(270, 452);
            this.button2Start.Name = "button2Start";
            this.button2Start.Size = new System.Drawing.Size(128, 58);
            this.button2Start.TabIndex = 19;
            this.button2Start.Text = "Начать";
            this.button2Start.UseVisualStyleBackColor = true;
            this.button2Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(63, 281);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(145, 52);
            this.buttonImport.TabIndex = 20;
            this.buttonImport.Text = "Импортировать";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonImport_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Загрузить список слов/ Сохранить ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Очки:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(793, 42);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(51, 20);
            this.labelScore.TabIndex = 24;
            this.labelScore.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Правильно:";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Location = new System.Drawing.Point(819, 372);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(51, 20);
            this.labelScore2.TabIndex = 26;
            this.labelScore2.Text = "label9";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(683, 602);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(121, 44);
            this.buttonAnswer.TabIndex = 27;
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAnswer_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(703, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(793, 88);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(60, 20);
            this.labelTime.TabIndex = 29;
            this.labelTime.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Неправильно:";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Location = new System.Drawing.Point(848, 435);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(60, 20);
            this.labelWrong.TabIndex = 31;
            this.labelWrong.Text = "label11";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(306, 103);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(169, 51);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(224, 281);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(159, 52);
            this.buttonExport.TabIndex = 33;
            this.buttonExport.Text = "Экспортировать";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 710);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.button2Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelеToTrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1Start);
            this.Controls.Add(this.labelTransWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.textBoxKeyBoard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTranslate);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxChoice_Play);
            this.Controls.Add(this.buttonFalse);
            this.Controls.Add(this.buttonTrue);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonTrue;
        private System.Windows.Forms.Button buttonFalse;
        private System.Windows.Forms.TextBox textBoxChoice_Play;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxTranslate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKeyBoard;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelTransWord;
        private System.Windows.Forms.Button button1Start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelеToTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2Start;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExport;
    }
}

