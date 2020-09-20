using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Eight
{
    class PersonalComputer : ComputerTechnology
    {
        public PersonalComputer()
            : base()
        {
            MotherBroads = MotherBroad.Нет_модели;
            Memorys = Memory.Нет_данных;
            VideoGames = VideoGame.Нет_данных;
            Processors = Processor.Нет_данных;
            RAMs = RAM.Нет_данных;
        }

        public PersonalComputer(string M, int PY, int P, MotherBroad MB, Memory Mem, VideoGame VD, Processor PS, RAM RM)
            : base(M, PY, P)
        {
            MotherBroads = MB;
            Memorys = Mem;
            VideoGames = VD;
            Processors = PS;
            RAMs = RM;
        }

        public MotherBroad MotherBroads;
        public Memory Memorys;
        public VideoGame VideoGames;
        public Processor Processors;
        public RAM RAMs;

        public override string Материнская_Плата
        {
            get
            {
                return MotherBroads.ToString();
            }
        }
        public override string Память
        {
            get
            {
                return Memorys.ToString();
            }
        }
        public override string Видео_Карта
        {
            get
            {
                return VideoGames.ToString();
            }
        }
        public override string Процессор
        {
            get
            {
                return Processors.ToString();
            }
        }
        public override string Оперативная_Память
        {
            get
            {
                return RAMs.ToString();
            }
        }

    }
}
