using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Eight
{
    class ComputerTechnology
    {

        public ComputerTechnology(string M, int PY, int P)
        {
            Model = M;
            Production_Year = PY;
            Price = P;
        }

        public ComputerTechnology()
        {
            Model = "Нет_данных";
            Production_Year = 0;
            Price = 0;
        }

        public string Model;
        public int Price;
        public int Production_Year;

        public virtual string MPPY
        {
            get { return ""; }
        }

        public virtual string Материнская_Плата
        {
            get { return ""; }
        }
        public virtual string Память
        {
            get { return ""; }
        }
        public virtual string Видео_Карта
        {
            get { return ""; }
        }
        public virtual string Процессор
        {
            get { return ""; }
        }
        public virtual string Оперативная_Память
        {
            get { return ""; }
        }

    }
}
