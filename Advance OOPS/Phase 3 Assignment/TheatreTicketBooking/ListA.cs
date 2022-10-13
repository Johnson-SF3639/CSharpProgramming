using System.Collections;

namespace TheatreTicketBooking
{
    public partial class List<Type> : IEnumerable, IEnumerator
    {
        int _position;

        public IEnumerator GetEnumerator()
        {
            _position=-1;
            return (IEnumerator)this;

        }
        public bool MoveNext()
        {
            if(_position < _count-1){
                _position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            _position=-1;
        }
        
        public object Current{
            get{return Array[_position];}
        }
    }
}