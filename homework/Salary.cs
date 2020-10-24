using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Salary
    {
        #region Properties is created
        private int[] ClassHour = new int[11];
        private int[] ClassIncome = new int[11];

        private int _income;
        #endregion

        #region  Add LLesson Methodu
        public void AddLesson(int level, int hour)
        {
            if (level < 1 || level > 11)
            {
                Console.WriteLine("Tehsil 11 il oldugu ucun 1-11 araliginda qiymet daxil ede bilersiz!");
                return;
            }

            if (level > 0 && level < 5)
            {
                ClassHour[level - 1] += hour;
                ClassIncome[level - 1] += hour * 10;
                return;
            }
            else if (level > 4 && level < 10)
            {
                ClassHour[level - 1] += hour;
                ClassIncome[level - 1] += hour * 15;
                return;
            }
            else
            {
                ClassHour[level - 1] += hour;
                ClassIncome[level - 1] += hour * 20;
                return;
            }


        }
        #endregion

        #region Remove Lesson Methodu
        public void RemoveLesson(int level)
        {
            ClassIncome[level - 1] = 0;
            ClassHour[level - 1] = 0;

        }
        #endregion

        #region Get Slary Methodu
        public int GetSalary()
        {
            for (int i = 0; i < 11; i++)
            {
                _income += ClassIncome[i];


            }
            return _income;
        }
        #endregion

        #region Report Methodu
        public void Report()
        {
            for (int i =0 ; i < 11; i++)
            {
                if (ClassHour[i] != 0)
                {
                 Console.WriteLine( (i+1)+" "+"sinifde"+" "+ ClassHour[i]+" "+"saat ders kecilib.Qazanc:"+" "+ ClassIncome[i]+"azn" );
                }

            }
        }
        #endregion

    }
}