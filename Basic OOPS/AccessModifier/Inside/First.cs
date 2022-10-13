using System;
using Outside;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class First :Third
    {
        public int PublicNumber=10;

        private int _privateNumber = 20;
        public int PrivateNumber { get{return _privateNumber;} }

        internal int InternalNumber = 30;

        protected int protectedNumber = 40;

        public int ProtectedInternalNumber {get{return protectedInternalNumber;}}
        
        
    }
}