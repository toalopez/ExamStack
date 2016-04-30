using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStack
{
    public class Test
    {
        string name = string.Empty;
        int numero = 0;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Numero
        {
            set { numero = value; }
            get { return numero; }
        }
    }
}
