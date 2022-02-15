using System;
using System.Collections.Generic;
namespace Integer_Ikılilerin_Toplamı
{
    public class Int_Ikililer
    {
        public List<double> Ikililerin_Islemleri(int[] arr)
        {
            List<double> sonuc = new List<double>();
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i] == arr[i+1])
                {
                    double result = Math.Pow(arr[i]+arr[i+1],2); // İkililer eşitse bu şekilde toplamlarının karesini alıyorum ve
                    sonuc.Add(result); // listeye ekliyorum.
                }
                else
                {
                    double result = arr[i]+arr[i+1]; // eşit olmayan ikilileri sadece toplayıp 
                    sonuc.Add(result); // listeye ekliyorum.
                }
                i++; // 0-1. indexi yaptıkran sonra 1-2 olmaması, 2-3. index olması için 1 kere elle i'yi artırıyorum.
            }
            return sonuc;
        }
        public void IkilileriEkranaYazdırma(List<double> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item+" ");
            }
        }
    }
}
// 0-1, 2-3