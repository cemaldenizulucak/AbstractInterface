using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterface
{
    public interface IVehicleTest

    {

        /*
            -ınterfaceler arayüzlerdir ve içerisinde sözleşme benzeri yapılar barındırırlar.
            -Banka örneğini vericek olursak  Hesap açmak için belirli bir miktar para koymanız gerekmektedir
            ancak işlem detaylarını burada belirtmelisiniz.
            -Araç örneği üzerinden gidecek olursak;
            *gitme,durma
            *uçabilme
            *binilebilme
            Gibi durumlar benim sözleşmelerimdir içerisindeki metod durumların tamamını bu interfacei seçen her class sağlamak zorundadır.
            Aözleşmler içerinsinde kod barındıramazlar,ancak implemet eden classda işlemler gerçekleştirilebilir.
         
         */


        void go();
        void stop();
    }

    public interface IRideable
    {
        void ride();
    }
    public interface Flyable
    {
        void soar();
    }




    //Araba sınıfı taşıt arayüzünü implemet ederek içerisindeki bütün metodlara(sözleşme) ulaşıp kullanabilir
    //implemet edilen sözleşmelerin tamamını karşılamak zorundadır
    public class Car : IVehicleTest
    {
        public void go()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }   
    }
    //bisiklet sınıfı bu arayüzlerden birden fazlasını uygulayabilmektedir.
    public class Bike : IVehicleTest, IRideable
    {
        public void go()
        {
            throw new NotImplementedException();
        }

        public void ride()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }

        // Porche nin bir sınıf olduğunu düşünürssk birçok farklı interfacei 
        //ve bu interfaceler içersindeki tek ve hızlı bir seferde gerkesiz
        //kod kullanımlarından kaçınmamızı sağlar
    }
}
