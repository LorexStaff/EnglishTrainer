using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Библиотека_для_Английского
{
    public class Word
    {
        public List<string> RussianWords;
        public List<string> EnglishWords;
        public int points2;
        public int points2false;
        public int points;
        public int timer_val;

        // добавить в листы слова
        public void AddWords(string eword, string rword)
        {
            EnglishWords.Add(eword);
            RussianWords.Add(rword);
        }
        
        //импортировать файл с пк
        public bool OpenGameWords(string dest)
        {
            if (!File.Exists(dest))
                return false;
            string[] fileInfo = File.ReadAllLines(dest);
            RussianWords = new List<string>();
            EnglishWords = new List<string>();
            foreach (var w in fileInfo)
            {
                string[] ws = w.Split('/');
                RussianWords.Add(ws[0]);
                EnglishWords.Add(ws[1]);
            }
            return true;
        }
        //удалить слово из списка
        public void RemoveGameWords(int index)
        {
            RussianWords.RemoveAt(index);
            EnglishWords.RemoveAt(index);
        }
        //рандомная генерация слов
        public string Rand()
        {
            Random rnd = new Random();
            int randIndex = rnd.Next(EnglishWords.Count);
            string random = EnglishWords[randIndex];
            return random;
        }
        //сохранить список на пк
        public bool SaveGameCurrentWords(string dest)
        {
            if (File.Exists(dest) || RussianWords.Count != EnglishWords.Count)
                return false;
            string[] contents = new string[RussianWords.Count];
            for (int i = 0; i < RussianWords.Count; i++)
            {
                contents[i] = $"{RussianWords[i]}/{EnglishWords[i]}";
            }
            File.WriteAllLines(dest, contents);
            return true;
        }
        // Начисление очков
        public int Check_FirstGame()
        {
            points = points + 5;
            return points;
        }
        public int Check_FirstGameFalse()
        {
            points = points - 2;
            return points;
        }
        public int Check_SecondGame()
        {
            points2++;
            return points2;
        }
        public int Check_SecondGameFalse()
        {
            points2false--;
            return points2false;
        }
        // timer
        public int Check_Timer()
        {
            timer_val = timer_val + 7;
            return timer_val;
        }
        public int Check_TimerWrong()
        {
            timer_val = timer_val - 2;
            return timer_val;
        }
        public int Countdown()
        {
          
        }
    }
}
