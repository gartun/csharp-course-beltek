using System;

namespace EmlakciLib
{
    public class Ev
    {
        // ev nesnesine ait olduklarından statik olamazlar
        public int floor;
        public int numOfRooms;
        public int size;
        public string nei;


        // parametre ile çağrılan evin bilgilerini getirir. Nesneye değil classa aittir.
        public static string PrintInfo(Ev ev)
        {
            return $"oda sayısı: {ev.numOfRooms}\nalan: {ev.size}\nsemt: {ev.nei}\nkat sayısı: {ev.floor}";
        }


        // her nesnenin kendi özelliklerini getirir.
        public string PrintInfo()
        {
            return $"oda sayısı: {this.numOfRooms}\nalan: {this.size}\nsemt: {this.nei}\nkat sayısı: {this.floor}";
        }
    }
}//class library dosyası derlendiğinde ortaya dll (dinamic link library) dosyası çıkar
 //Dll dosyaları içerinde classlar bulunur.
 //bu classları başka projelerde kullanmak için projeye referans olarak göstermemiz gerekir.