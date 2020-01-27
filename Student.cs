using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamensadministration
{
    class Student
    {
        public string namn;
        public string personnummer;

        public override string ToString()
        {
            return namn + " (" + personnummer + ")";
        }

    }
}
