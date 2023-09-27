using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    //Generics Means Genreral Form
    //it doesnot specify a particular data typa
    //Generic allow us to a single class or method that can be us for different data types
    //<T> with type parameter
    //type parameter 
    internal class Generics <T>
    {
        //public string data ;
        public T data;
        public Generics(T data)
        {
            this.data = data;
            Console.WriteLine(this.data);
        }
        public void DemoMethod(T no)
        {
            Console.WriteLine(no);
        }
    }
    public class Generic
    {
        public void GenericMethod<T>(T num)
        {
            Console.WriteLine(num);
        }
    }
}
