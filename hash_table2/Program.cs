using System.Collections;
using System.IO;
namespace hash_table2;
class hash_table2
{
//todo mesala sort yok mu darbuka çalın arabeks göbek atalım göbecik :))
//!string dışı type
    static void Main(string[] soylu)
    {
        Hashtable hs_a=new Hashtable();
        hs_a.Add("001","necmiye");
        hs_a.Add("002","soylu");
        hs_a.Add("003","tayfun");
        hs_a.Add("004","üçüncü");

        Hashtable hs_n=new Hashtable(){
            {"001","Behice"},
            {"002","Soylu"},
            {"003","Murat"},
            {"004","Soylu"}
        };

        foreach(DictionaryEntry e in hs_a)
            Console.WriteLine(e);    
        Console.WriteLine("\n");
        foreach(string s in hs_n.Values)
            Console.WriteLine(s);
        Console.WriteLine("\n");//todo tek consolewriteline desem yeter mi 
        
        //todo <> bir iki oynamanın ardından bunu da deneyelim

        hs_a.Remove("002");
        hs_a.Remove("003");
        hs_a.Remove("004");

        hs_n["002"]="behice";
        hs_n["003"]="behice";
        hs_n["004"]="behice";

        //boş bir hasha aldığım values atayabilir miyim

        ArrayList values_n=new ArrayList();
        ICollection get_values_n=hs_n.Values;
        values_n.AddRange(get_values_n);

        ArrayList values_a=new ArrayList();
        values_a.AddRange(hs_a.Values);//çokta gerekli değilmiş ıcollection muhabbeti

        //yeni hasa toplu atayalım
        //hatta çirkinleşelim valuesı key yapalım
        //bunu iki şekilde yapabilirim ya has'e value olarak obje atarım yada tek tek arraydan alıp atam olur  o zaman da string dişi key olur mu kontroluı olur
    }
}