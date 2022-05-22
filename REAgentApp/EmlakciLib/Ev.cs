using System;

namespace EmlakciLib
{
    public class Ev 
    {
        
        public int Floor { get; set; }
        public int size;

        private int numOfRooms;
        public void SetNumOfRooms(int numOfRooms)
        {
            this.numOfRooms = numOfRooms;
        }

        public int GetNumOfRooms()
        {
            return this.numOfRooms;
        }


        private string nei;

        public string Nei
        {
            get { return nei; }
            set { nei = value.ToUpper(); }
        }

        
        public static string PrintInfo(Ev ev)
        {
            return $"oda sayısı: {ev.GetNumOfRooms()}\talan: {ev.size}\tsemt: {ev.nei}\tkat sayısı: {ev.Floor}\t";
        }


        
        public string PrintInfo()
        {
            return $"oda sayısı: {this.GetNumOfRooms()}\talan: {this.size}\tsemt: {this.nei}\tkat sayısı: {this.Floor}\t";
        }
    }
}

//class library dosyası derlendiğinde ortaya dll (dinamic link library) dosyası çıkar
 //Dll dosyaları içerinde classlar bulunur.
 //bu classları başka projelerde kullanmak için projeye referans olarak göstermemiz gerekir.