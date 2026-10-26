using Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    #region New Implment
    //interface ISeries
    //{
    //    int Current { get; }
    //    void GetNext();
    //    void Reset();
    //}

    //public abstract class SeriesBase : ISeries
    //{
    //    ///private protected => me and my sub classes => must be in same assembly
    //    ///protected
    //    ///protected internal


    //    public int Current { get; private protected set; }

    //    public abstract void GetNext();

    //    public void Reset()
    //    {
    //        Current = 0;
    //    }
    //}

    //class SeriesByTwo : SeriesBase
    //{
    //    public override void GetNext()
    //    {
    //        Current += 2;
    //    }
    //}

    //class SeriesByThree : SeriesBase
    //{
    //    public override void GetNext()
    //    {
    //        Current += 3;
    //    }
    //}

    //class SeriesBySeven : SeriesBase
    //{
    //    public override void GetNext()
    //    {
    //        Current += 7;
    //    }
    //}
    #endregion

    #region Old Implment
    //internal interface ISeries
    //{
    //    int Current { get; }

    //    void GetNext();

    //    void Reset();
    //    //public void Reset()
    //    //{
    //    //    Current = 0;
    //    //}
    //}

    ////class Series
    ////{
    ////    public int Current { get; set; }
    ////    public void GetNext()
    ////    {
    ////        Current += ?????;
    ////    }
    ////    public void Reset()
    ////    {
    ////        Current = 0;
    ////    }
    ////}

    //class SeriesByTwo : ISeries
    //{
    //    public int Current { get; private set; }

    //    public void GetNext()
    //    {
    //        Current += 2;
    //    }

    //    public void Reset()
    //    {
    //        Current = 0;
    //    }
    //}

    //class SeriesByThree : ISeries
    //{
    //    public int Current { get; private set; }

    //    public void GetNext()
    //    {
    //        Current += 3;
    //    }

    //    public void Reset()
    //    {
    //        Current = 0;
    //    }
    //} 
    #endregion

    #region Access Modifers
    class SeriesByFive : SeriesBase
    {
        public override void GetNext()
        {
            Current += 5;
        }
    }
    #endregion
}
