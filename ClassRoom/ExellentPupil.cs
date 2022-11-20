using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ExellentPupil : Pupil
    {
        public override void InfoAboutStudent()
        {
            Console.WriteLine("\nExellentStudent:");
        }
        public override void Study() 
        {
            Console.WriteLine("The student is learning on mark 5");
        }
        public override void Read() 
        {
            Console.WriteLine("The student reads 4 books for weak");
        }
        public override void Write() 
        {
            Console.WriteLine("The student writes for 8 hours");
        }
        public override void Relax() 
        {
            Console.WriteLine("The student goes in swiming pool");
        }
    }
}
