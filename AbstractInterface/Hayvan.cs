using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterface
{

    /*
        Özetle soyutlama işlemidir.Diğer class lar bu classı base alırlar.
        Örneğin alan hesabı yapan bir abs.sınıf düşüünürsek üçgen kare vb şekiller bu classı kullanacaklardır.
        Ancak alan hesaplamaları farklı olacağı için çektikleri metodları ezmeleri gerekmektedir.
     */

    public abstract class Ses
    {
        public abstract void Voice();
    }

    public class Kedi : Ses
    {
        public override void Voice()
        {
            Console.WriteLine("Miyav");
        }
    }

    public class Köpek : Ses
    {
        public override void Voice()
        {
            Console.WriteLine("Hav Hav");
        }
    }
}
