using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InterfaceOrnek
{
    interface IYetenek1
    {
        /*
         * interface'in kendi erişim belirleyicisi neyse içindeki elemanların
         * hepsi aynı erişime sahiptir.
         * 
         * bu nedenle interface içindeki elemanlara erişim belirleyicisi yazılmaz.
         * 
         * interface'lerin metotlarının gövdesi olmaz.
         */

        void X(); //gövdesi yok.

        void Y();

        void Z();

    }
}
