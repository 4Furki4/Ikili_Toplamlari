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
                    double result = Math.Pow(arr[i]+arr[i+1],2);
                    sonuc.Add(result);
                }
                else
                {
                    double result = arr[i]+arr[i+1];
                    sonuc.Add(result);
                }
                i++;
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