using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// class
    /// struct
    /// interface
    /// delegate
    /// record

    /// What You Can Write Inside The Enum?
    /// only labels => refer to number


    /// What You Can Write Inside The Class Or Struct?
    /// 1. variable => field (Attributes)
    /// 2. functions => methods
    /// 3. constructor => special method
    /// 4. properties
    /// 5. Events
    /// 6. Incdexers

    /// What You Can Write Inside The Interface?
    /// 1. methods signature
    /// 2. properties signature
    /// 3. events signature
    /// 4. indexers signature
    /// 5. Default implementation of methods, properties, events, and indexers (from C# 8.0 onwards)

    /// Allowed Access Modifiers Inside The Namespace 
    /// 1. public
    /// 2. internal [Default access modifier]

    enum rank { first, seconed, third }

    public class TypeA
    {
        /// Allowed Access Modifiers Inside The class 
        /// 1. private [default] 
        /// 2. private protected => inhertance
        /// 3. protected => inhertance
        /// 4. internal
        /// 5. internal protected => inhertance
        /// 6. public 

        int x; //private => allow to access by class memebers only
        internal int y; //internal => allow to access by class memebers and same assemply only
        public int z; //public => allow to access by class memebers and same assemply and other assemply

        void test()
        {
            rank r = rank.first;
            x = 10; // valid because x is private in typeA
            y = 20; // valid because y is internal in typeA
            z = 30; // valid because z is public in typeA
        }

    }
}
