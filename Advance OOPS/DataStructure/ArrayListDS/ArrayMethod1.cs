using System;
using System.Collections;

namespace ArrayListDS
{
    public partial class ArrayList<dynamic> : IEnumerable, IEnumerator
    {
        private int i;
        
        public IEnumerator GetEnumerator(){
            i =-1;
            return(IEnumerator)this;
        }
        public bool MoveNext(){
            if(i < _count-1){
                i++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset(){
            i=-1;
        }
        public object Current{
            get{ return Array[i];}
        }
     

    }
}