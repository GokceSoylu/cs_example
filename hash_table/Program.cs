using System.Collections;
using System.IO;
namespace hash_table;
class hash_table
{
    static void Main(string[] soylu)
    {
        Hashtable hs=new Hashtable(); //todo tıpkı pytoh gibi farklıo oluşturma şekillerde var you know sister add olamadan 
        hs.Add("1","aarabica");
        hs.Add("2","barabica");
        hs.Add("3","carabica");
        hs.Add("4","darabica"); //!stringden başka tip olabilir mi

        if(hs.ContainsValue("darabica"))//todo  ---> oww DictionaryEntry ele1 in my_hashtable1 ele1.value ele1.key
            foreach(string s in hs.Values)//yup it works :))
                Console.WriteLine(s);
    }
}



// başlayalım  hocam Hash table zaten olayı python dan biliyoruz.  key value muhabbeti
// Add ContainsValue(value) ContainsKey(key) 
//key Icollevtion objesi ile alınır //todo direkt hashtable objesi ile key kullandı
//.Keys (the method) .Values da var bu tüm values döndürür ama tabi range olarak arrayList yani hocam -->//todo denenir
//işin garip tarafı key leride string olarak tutuyor
//as you have already known tje keys must be unique
//clear and remove("key")
//Contains ContainsKey ContainsValue

//todo son orneğği sklm