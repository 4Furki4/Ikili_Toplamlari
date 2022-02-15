using System;
using System.Collections;

namespace Integer_Ikılilerin_Toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri konsol= new Konsol_Islemleri();
            Int_Ikililer Ikililer= new Int_Ikililer();
            konsol.IlkMesaj();
            Ikililer.IkilileriEkranaYazdırma(Ikililer.Ikililerin_Islemleri(konsol.KonsoldanSayılarıAl()));
            
            
        }
    }
}
