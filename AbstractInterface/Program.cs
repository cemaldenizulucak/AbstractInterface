using System;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.go();
            car1.stop();

            Bike bike1 = new Bike();
            bike1.ride();*/

            Kedi kedi1 = new Kedi();
            kedi1.Voice();

            Köpek köpek1 = new Köpek();
            köpek1.Voice();

        }
    }
}
