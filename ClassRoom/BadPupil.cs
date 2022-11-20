using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void InfoAboutStudent()
        {
            Console.WriteLine("\nBadStudent:");
        }
        public override void Study()
        {
            Console.WriteLine("The student is learning on mark 2");
        }
        public override void Read()
        {
            Console.WriteLine("The student reads 0 books for weak");
        }
        public override void Write()
        {
            Console.WriteLine("The student writes for 1 hours");
        }
        public override void Relax()
        {
            Console.WriteLine("The student smokes cigarettes");
        }
    }
}
