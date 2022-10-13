using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreTicketBooking
{
    public partial class List<Type>
    {
        /// <summary>
        /// Private field 
        /// </summary>
        private int _count;
        /// <summary>
        /// Private field
        /// </summary>
        private int _capacity;
        /// <summary>
        /// Count Property 
        /// </summary>
        /// <value></value>

        public int Count { get{return _count;} }
        /// <summary>
        /// Capacity Property
        /// </summary>
        /// <value></value>
        public int Capacity { get{return _capacity;} }
        /// <summary>
        /// Array Property
        /// </summary>
        /// <value></value>
        public Type[] Array {get; set;}

        /// <summary>
        /// Indexer
        /// </summary>
        /// <value></value>
        public Type this[int _position]
        {
            get { return Array[_position]; }
            set { Array[_position]=value; }
        }

        /// <summary>
        /// List Constructor
        /// </summary>
        public List(){
            _count=0;
            _capacity=4;
             Array = new Type[_capacity];
        }

        /// <summary>
        /// Parametor Constructor
        /// </summary>
        /// <param name="size"></param>
        public List(int size){
            _count=0;
            _capacity=size;
            Array = new Type[_capacity];
        }
        /// <summary>
        /// Add Method
        /// </summary>
        /// <param name="data"></param>
        public void Add(Type data){
            if(_capacity==_count){
                GrowSize();
            }
            Array[_count]=data;
            _count++;
        }

        /// <summary>
        /// GrowSize Method
        /// </summary>
        public void GrowSize(){
            _capacity = _capacity * 2;
            Type[] temp = new Type[_capacity];
            for(int i=0; i<_count; i++){
                temp[i]= Array[i];
            }
            Array=temp;
        }

    }
}