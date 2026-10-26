using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    class test
    {
        void test01()
        {
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //seriesByTwo.Current = 20;
        }
    }
    public interface ISeries
    {
        int Current { get; }
        void GetNext();
        void Reset();
    }

    public abstract class SeriesBase : ISeries
    {
        ///private
        ///private protected => me and my sub classes => must be in same assembly
        ///protected => me and my sub classes => in any Assembly
        ///internal
        ///protected internal => available in my assembly for all using but in other assemblies only inhert class can access me 
        ///public


        //public int Current { get; private protected set; }
        public int Current { get; protected set; }
        //public int Current { get; protected internal set; }

        public abstract void GetNext();

        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesByTwo : SeriesBase
    {
        public override void GetNext()
        {
            Current += 2;
        }
    }

    class SeriesByThree : SeriesBase
    {
        public override void GetNext()
        {
            Current += 3;
        }
    }

    class SeriesBySeven : SeriesBase
    {
        public override void GetNext()
        {
            Current += 7;
        }
    }
}
