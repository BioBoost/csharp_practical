using System;

namespace MarcoPolo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalInformation info = new PersonalInformation();
            info.FullName();
            info.Age();
            info.EyeColor();
        }
    }
}
