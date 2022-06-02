using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Proc
    {
        public string ProcName { get; set; }

        public int ProcCount { get; set; }

        public override string ToString()
        {
            return ProcName + ProcCount;
        }
    public Proc(string procName, int procCount)
    {
        ProcName = procName;
        ProcCount = procCount;
    }
        public Proc() { }
    }

}
