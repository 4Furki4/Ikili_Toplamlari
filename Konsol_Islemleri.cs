using System;
namespace Integer_Ikılilerin_Toplamı
{
    public class Konsol_Islemleri
    {
        public void IlkMesaj()
        {
            System.Console.WriteLine("Lütfen n tane aralarında boşluk olacak şekilde sayı giriniz."+ 
            "Eğer ikililer birbirinden farklıysa toplamları, aynıysa toplamlarının karesi ekrana yazılacak.");
            System.Console.WriteLine("Dipnot: İkili olması için n çift sayı olmalıdır.");
        }
        public int[] KonsoldanSayılarıAl()
        {
            string input = Console.ReadLine();
            string[] stringSayılar= input.Split(" "); //her sayının arasında konsoldan alırken boşluklara göre bölüp diziye atıyorum.
            int[] sayılar = new int[stringSayılar.Length]; // sayıları int dizide depolayacağım için uzunluğunu konsoldan alınan sayı kadar belirliyorum.
            int i=0;
            foreach (var item in stringSayılar) // string dizideki her sayıyı int değişken yapıp int diziye atıyorum.
            {
                sayılar[i]=int.Parse(item);
                i++;
            }
            return sayılar;
        }
    }
}