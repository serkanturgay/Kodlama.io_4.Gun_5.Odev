using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_4.Gun_5.Odev
{
    class MyDictionary<Tno,Tname>
    {
        Tno[] No; //No array tanimlaniyor.
        Tname[] Names; //Names array tanimlaniyor.

        ////////////////////////////CONSTRUCTOR////////////////////////////
        public MyDictionary() 
        {
            No =new Tno[0]; //Dictionary calistiginda 0 elemanli No array olusturuluyor/
            Names = new Tname[0]; //Dictionary calistiginda 0 elemanli Name array olusturuluyor/
        }
        ////////////////////////////CONSTRUCTOR////////////////////////////
        ////////////////////////////ADD (EKLEME)////////////////////////////
        public void Add(Tno no, Tname name)
        {

            Tno[] tempNo = No; //Gecici No array olusturulup No esitleniyor.
            Tname[] tempName = Names; //Gecici Name array olusturulup Name esitleniyor.
            No = new Tno[tempNo.Length + 1]; //No array a 1 eleman eklenmis yeni array tanimlaniyor.
            Names = new Tname[tempName.Length + 1]; //Name array a 1 eleman eklenmis yeni array tanimlaniyor.
            for (int i = 0; i < tempNo.Length; i++) //Gecici arrayda tutulan degerler ana array a aktariliyor.
            {
                No[i] = tempNo[i];
            }
            No[No.Length - 1] = no; //Son bos elemana girdigimiz NO degeri ataniyor.
            for (int i = 0; i < tempName.Length; i++) //Gecici arrayda tutulan degerler ana array a aktariliyor.
            {
                Names[i] = tempName[i];
            }
            Names[Names.Length - 1] = name;//Son bos elemana girdigimiz NAME degeri ataniyor.
        }
        ////////////////////////////ADD (EKLEME)////////////////////////////
        ////////////////////////////Listeleme////////////////////////////

        public void List()
        {
            for (int i = 0; i < No.Length; i++)
            {
                Console.WriteLine("Student Number: " + No[i] + "  Student Name: " + Names[i]);
            }
        }
        ////////////////////////////Listeleme////////////////////////////
    }
}
