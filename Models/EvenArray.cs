using System;
namespace EssentialCSharp.Models {
    public class EvenArray{
        private int[] _myArray ;
        public EvenArray(int Size){
            _myArray = new int[Size];
            PupList<String> m = new PupList<string>(5);
            m.Set("Ahmed");
            m.Set("Ahmed");
            m.Set("Ahmed");
            m.Set("Ahmed");
            m.Set("Ahmed");
            
        }
        public int this[int index]

        {
            get { return _myArray[index] ; }
            set { 
                if (value % 2 == 0)
                {
                    _myArray[index] = value;                    
                }
                else
                {
                    throw new Exception("input must be an even number.");
                }
             }
        }
    }

    public class PupList<T>{
        private T[] PArray;
        private int intCurrentIndex = 0;
        public  PupList(int size){
            PArray = new T[size] ;           
        }
        public T GetByIndex(int index){
            return PArray[index];
        }

        public void Set(T value){
            PArray[intCurrentIndex] = value;
            intCurrentIndex ++;
        }
    } 
}