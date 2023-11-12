using System.Collections;
using System.IO;
// Kodun anlam ve önemi: Evet hash table da hem value hem key istediğin değişken tipinde olabilr string int hatta object but object olursa yazdırıken şırkar line:23 and 39 
class forTry
{
    static void Main(String[] Soylu)
    {
        Hashtable h=new Hashtable(){
            {1,"banana"},
            {"banana",1}
        };
        ArrayList ow=new ArrayList();
        ArrayList ow2=new ArrayList();
        
    
        ow.AddRange(h.Values);
        ow2.AddRange(h.Keys);

        h[ow]="kral";    
        h["kral"]=ow2;

        foreach(var e in h.Values) //aynı işlemi keys ile yapıp eğlenemlim :))
        {    if(e is ArrayList)
            {
                ArrayList str=new ArrayList();
                str.AddRange(e as ArrayList);//focus on AS
                foreach(var a in str) Console.WriteLine(a);
                continue;
            }
            Console.WriteLine(e);
        } 

        Console.WriteLine("\nhop\n");

        foreach(var e in h.Keys)
        {
            if(e is ArrayList)
            {
                ArrayList arr=new ArrayList();
                arr.AddRange(e as ArrayList);
                foreach(var a in arr) Console.WriteLine(a);
                continue;
            }
            Console.WriteLine(e);
        }   
    }
}
//Mutlu Son...