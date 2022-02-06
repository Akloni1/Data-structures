using System;
using System.Collections;
using System.Collections.Generic;

namespace Badoo
{
    public class Arr<T>: IEnumerable<T>
    {
        private int _count { set; get; }
        private int _numberOfArrayElements { set; get; }
        private T[] _arr;
        private string _age;

        public  Arr(string age)
        {
            _numberOfArrayElements = 0;
            _count = 2;
            _arr = new T[_count];
            _age = age;
        }

       

        public T this[int i]
        {
            get
            {
                  
                int k=0;
                //средний возраст
                if (_age.Equals("average"))
                {
                    k = _numberOfArrayElements / 2;
                    //j = k;
                    if (i % 2 == 0)
                    {
                        k=k - i / 2;
                        
                    }
                    else
                    {
                        k = (k + i / 2)+1;
                       // if (_age[k] == null)
                           // k = 0;
                    }
                }
                //молодой возраст 
                else if (_age.Equals("young"))
                {
                    k = i;
                }
                //постарше
                else if (_age.Equals("old"))
                {
                    k = _numberOfArrayElements - 1 - i;
                }

                if ((_numberOfArrayElements)%2==0&& k==_numberOfArrayElements)
                {
                    return _arr[0];
                }
                else
                {
                    return _arr[k];
                }
               
            }

            set
            {
                int k=0;
                //средний возраст
                if (_age.Equals("average"))
                {
                    k = _numberOfArrayElements / 2;
                    //j = k;
                    if (i % 2 == 0)
                    {
                        k=k - i / 2;
                    }
                    else
                    {
                        k = (k + i / 2)+1;
                    }
                }
                //молодой возраст 
                else if (_age.Equals("young"))
                {
                    k = i;
                }
                //постарше
                else if (_age.Equals("old"))
                {
                    k = _numberOfArrayElements - 1 - i;
                }
                _arr[k] = value;
                
            }
        }

        public void  Add(T person)
        {
            if (_numberOfArrayElements == _count)
            {
                IncreaseArray();
            }
            _arr[_numberOfArrayElements] = person;
                _numberOfArrayElements++;
              
        }

        public void Edit(int index, T person)
        {
            int k=0;
            //средний возраст
            if (_age.Equals("average"))
            {
                k = _numberOfArrayElements / 2;
                //j = k;
                if (index % 2 == 0)
                {
                    k=k - index / 2;
                }
                else
                {
                    k = (k + index / 2)+1;
                }
            }
            //молодой возраст 
            else if (_age.Equals("young"))
            {
                k = index;
            }
            //постарше
            else if (_age.Equals("old"))
            {
                k = _numberOfArrayElements - 1 - index;
            }
            if ((_numberOfArrayElements)%2==0&& k==_numberOfArrayElements)
            { 
                _arr[0]= person;
            }
            else
            {
                _arr[k] = person;
            }
            
        }

        public void Delete(int index)
        {
            int k=0;
            //средний возраст
            if (_age.Equals("average"))
            {
                k = _numberOfArrayElements / 2;
                //j = k;
                if (index % 2 == 0)
                {
                    k=k - index / 2;
                }
                else
                {
                    k = (k + index / 2)+1;
                }
            }
            //молодой возраст 
            else if (_age.Equals("young"))
            {
                k = index;
            }
            //постарше
            else if (_age.Equals("old"))
            {
                k = _numberOfArrayElements - 1 - index;
            }
            
            if ((_numberOfArrayElements)%2==0&& k==_numberOfArrayElements)
            { 
              //  _arr[0]= person;
              k = 0;
              if (!(k < 0) && !(k > this._count))
              {
                  for (int i = k; i < this._arr.Length - 1; i++)
                  {
                      this._arr[i] = this._arr[i + 1];
                  }

                  _count--;
                  _numberOfArrayElements--;
              }
              else
              {
                  throw new ArgumentOutOfRangeException();
              }
            }
            else
            {
                if (!(k < 0) && !(k > this._count))
                {
                    for (int i = k; i < this._arr.Length - 1; i++)
                    {
                        this._arr[i] = this._arr[i + 1];
                    }

                    _count--;
                    _numberOfArrayElements--;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void IncreaseArray()
        {
            T[] newArr = new T[_count*2];
            for (int i = 0; i < _count; i++)
            {
                newArr[i] = _arr[i];
            }
            _arr = newArr;
            _count = _count * 2;
        }
        public void Sort(int index, int count, IComparer<T>? comparer)
        {
            if (count > 1)
            {
                Array.Sort<T>(_arr, index, count, comparer);
            }
            
        }

       public void Sort(IComparer<T>? comparer)
            => Sort(0, _numberOfArrayElements, comparer);


        public IEnumerator<T> GetEnumerator()
        {
            
            int j=0,k=0;//по умолчанию выводим молодой возраст 
            //средний возраст
            if (_age.Equals("average"))
            {
                k = _numberOfArrayElements / 2;
                j = k;
            }
            //молодой возраст 
            else if (_age.Equals("young"))
            {
                  k = 0;
                  j = 0;
            }
            //постарше
            else if (_age.Equals("old"))
            {
                  k = _numberOfArrayElements - 1;
                  j = k;
            }


            for (int i = 0; i < _numberOfArrayElements; i++)
            {
                
                if(j<0&&k==_numberOfArrayElements){break;}

                if (k < _numberOfArrayElements)
                {
                    yield return _arr[k];
                }

                if (j>=0&&!(k==j))
                {
                    yield return _arr[j];
                }

                k++;
                j--;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
     
    }
}