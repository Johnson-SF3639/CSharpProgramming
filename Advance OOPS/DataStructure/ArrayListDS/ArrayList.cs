using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListDS
{
    public partial class ArrayList<dynamic>
    {
        private int _count;
        private int _capacity;
        private int _isFixedSize;
        private int _isReadOnly;
        private dynamic[] Array {get; set;}
        public int Count {get{return _count;}}

        //Indexer
        public dynamic this[int i]{ 
            get{
                return Array[i];
            } 
            set {
                Array[i]=value;
            }
        }

        public ArrayList(){
            _count=0;
            _capacity=4;
            _isFixedSize = 0;
            _isReadOnly = 0;
            Array = new dynamic[_capacity];
        }
        public ArrayList(int size, int capSize){
            _count=0;
            _capacity=capSize;
            _isFixedSize = size;
            _isReadOnly = 0;
            Array = new dynamic[_capacity];
        }

    }
}