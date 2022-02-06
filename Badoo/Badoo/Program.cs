using System;
using System.Collections;
using System.Collections.Generic;

namespace Badoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr<Girl> girls = new Arr<Girl>("average");
         
          Girl girl1 = new Girl("Maha",23 );
          Girl girl2 = new Girl("Ania",20 );
          Girl girl3 = new Girl("Alina",21 );
          Girl girl4 = new Girl("Sonya",25 );
          Girl girl5 = new Girl("Nastya",24 );
          Girl girl6 = new Girl("Pauline",18 );
          Girl girl7 = new Girl("Katya",31 );
          Girl girl8 = new Girl("Dasha",30 );
          Girl girl9 = new Girl("Christina",27 );
          Girl girl10 = new Girl("Irina",50 );
          girls.Add(girl1);
          girls.Add(girl2);
          girls.Add(girl3);
          girls.Add(girl4);
          girls.Add(girl5);
          girls.Add(girl6);
          girls.Add(girl7);
          girls.Add(girl8);
          girls.Add(girl9);
          girls.Sort(new Comparator());
      

          foreach (var VARIABLE in girls)
          {
              Console.WriteLine(VARIABLE._name);
              Console.WriteLine(VARIABLE._age);
          }
           // girls.Delete(7);
           // girls.Edit(7,girl10);
          Console.WriteLine(girls[0]._age+" "+girls[0]._name);
          Console.WriteLine(girls[1]._age+" "+girls[1]._name);
          Console.WriteLine(girls[2]._age+" "+girls[2]._name);
          Console.WriteLine(girls[3]._age+" "+girls[3]._name);
          Console.WriteLine(girls[4]._age+" "+girls[4]._name);
          Console.WriteLine(girls[5]._age+" "+girls[5]._name);
          Console.WriteLine(girls[6]._age+" "+girls[6]._name);
          Console.WriteLine(girls[7]._age+" "+girls[7]._name);
          Console.WriteLine(girls[8]._age+" "+girls[8]._name);
        }
    }
}