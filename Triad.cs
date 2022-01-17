using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7
{
    class Triad
    {
        private int _first;
        private int _second;
        private int _third;

        public int First { get { return _first; } set { _first = value; } }

        public int Second { get { return _second; } set { _second = value; } }

        public int Third { get { return _third; } set { _third = value; } }

        public Triad()
        {
            First = 1;
            Second = 1;
            Third = 1;
        }

        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public void Clear()
        {
            First = 0;
            Second = 0;
            Third = 0;
        }

        public void SetParams(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public bool Compare(Triad triad)
        {
            return ((First > triad.First || First == triad.First) && Second > triad.Second && Third > triad.Third);
        }

        public static bool operator >(Triad firstTriad, Triad secondTriad)
        {
            if ((firstTriad.First > secondTriad.First || firstTriad.First == secondTriad.First) && firstTriad.Second > secondTriad.Second && firstTriad.Third > secondTriad.Third)
                return true;
            else return false;

        }
        public static bool operator <(Triad firstTriad, Triad secondTriad)
        {
            return ((firstTriad.First < secondTriad.First || firstTriad.First == secondTriad.First) && firstTriad.Second < secondTriad.Second && firstTriad.Third < secondTriad.Third);
        }

        public static Triad operator ++(Triad triad)
        {
            triad.First *= 10;
            triad.Second *= 10;
            triad.Third *= 10;
            return triad;
        }
    }
}
