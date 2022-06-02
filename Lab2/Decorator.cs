using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    abstract class Decorator : Computer
    {
        public Decorator(string computertype, Proc proc, Video video, int sizeOZU, string typeOZU, int sizeHD, string typeHD, DateTime date, IOZUType ozu) : base(computertype, proc, video, sizeOZU, typeOZU, sizeHD, typeHD, ozu)
        {

        }
    }
    class NewComputer : Decorator
    {
        public NewComputer(string computertype, Proc proc, Video video, int sizeOZU, string typeOZU, int sizeHD, string typeHD, DateTime date, IOZUType ozu) : base(computertype, proc, video, sizeOZU, typeOZU, sizeHD, typeHD, date, ozu)
        {
            video.VideoMemory.Memory += 2;
        }
        public override string ToString()
        {

            return "Компьютер с процессором " + Proc.ToString() + " и видеокартой " + Video.ToString() + ", типом оперативной памяти: " + OZU.OZU();
        }
    }
}
