using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public struct TypeC
    {
        /// Allowed Access Modifiers Inside The class 
        /// 1. private [default] 
        /// 4. internal
        /// 6. public 

        int x; //private => allow to access by struct memebers only
        internal int y; //internal => allow to access by struct memebers and same assemply only
        public int z; //public => allow to access by struct memebers and same assemply and other assemply
    
        void test()
        {
            rank r = rank.first;
            x = 10; // valid because x is private in typeC
            y = 20; // valid because y is internal in typeC
            z = 30; // valid because z is public in typeC
        }
    }
}
