//todo <>
using System.Collections;
using System.Collections.Generic;
using System.IO;
namespace hash_table4;
class Program
{
    static void Main(string[] Soylu)
    {
        Dictionary<int,string> d=new Dictionary<int, string>(){
            {1,"a"},
            {2,"bb"},
            {3,"ccc"},
            {4,"dddd"}
        };
        
        string c;
        if(d.TryGetValue(4, out c))//out değer atiyo Dikkat sadece dictionary ile kullanılabilir
            Console.WriteLine(c);

    }
}