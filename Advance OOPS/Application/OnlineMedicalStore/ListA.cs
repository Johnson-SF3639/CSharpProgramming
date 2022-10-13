using System;

namespace OnlineMedicalStore
{
    public partial class List <Type>
    {
        public void Insert(int index, Type data){
            _capacity++;
            int i;
            Type[] temp = new Type[_capacity];
            for(i=0; i<_capacity; i++){
                if(i<index){
                    temp[i] = Array[i];
                }
                else if(i == index){
                    temp[i] = data;
                }
                else{
                    temp[i]= Array[i-1];
                }
            }
            Array = temp;
        }
    }
}