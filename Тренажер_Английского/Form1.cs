using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тренажер_Английского
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int timer = 20;
        private void buttonInput_MouseClick(object sender, MouseEventArgs e)
        {
            string eword = (textBoxInput.Text);
            string rword = (textBoxTranslate.Text);
            AddWords(eword, rword);
        }

        private void buttonAnswer_MouseClick(object sender, MouseEventArgs e)
        {
            if (labelеToTrans.Text == textBoxKeyBoard.Text)
            {
                labelScore2.Text = Convert.ToString(Check_SecondGame());
            }
            else labelWrong.Text = Convert.ToString(Check_SecondGameFalse());
            labelеToTrans.Text = Rand();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            labelеToTrans.Text = Rand();
        }

        private void button1Start_MouseClick(object sender, MouseEventArgs e)
        {
            labelWord.Text = ;
            labelTransWord.Text = ;
            labelTime.Text = Convert.ToString(timer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
        }

        private void buttonImport_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (Convert.ToBoolean(openFileDialog.ShowDialog()) == true)
            {
                for (int i = 0; i < RussianWords.Count; i++)
                {
                }
            }
    }   }
}
