using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_4.Gun_5.Odev
{
    class MyDictionary<Tno,Tname>
    {
        Tno[] No;
        Tname[] Names;
        public MyDictionary()
        {
            No =new Tno[0];
            Names = new Tname[0];
        }

        public void Add(Tno no, Tname name)
        {

            Tno[] tempNo = No;
            Tname[] tempName = Names;
            No = new Tno[tempNo.Length + 1];
            Names = new Tname[tempName.Length + 1];
            for (int i = 0; i < tempNo.Length; i++)
            {
                No[i] = tempNo[i];
            }
            No[No.Length - 1] = no;
            for (int i = 0; i < tempName.Length; i++)
            {
                Names[i] = tempName[i];
            }
            Names[Names.Length - 1] = name;
        }

    }
}
