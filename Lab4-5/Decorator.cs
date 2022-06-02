using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    abstract class ComputerDecorator : Computer
    {
        public ComputerDecorator(Proc p, Video v, IOZUType o) : base(p, v, o)  //base используется для доступа к членвам базового класса
        {
        }
    }
    class NewComputer : ComputerDecorator
    {
        public NewComputer(Proc p, Video v, IOZUType o) : base(p, v, o)
        {
            v.memory.Memory+=2;
        }
        public override string ToString()
        {
            return "Игровой Компьютер с процессором " + Proc.ToString() + " и видеокартой GEForce: " + Video.ToString() + " и типом оперативной памяти: " + TypeOZU.OZU() + " и подсветкой";
        }
    }
}
