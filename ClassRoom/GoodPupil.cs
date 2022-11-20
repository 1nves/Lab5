using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void InfoAboutStudent()
        {
            Console.WriteLine("\nGoodStudent:");
        }
        public override void Study()
        {
            Console.WriteLine("The student is learning on mark 4");
        }
        public override void Read()
        {
            Console.WriteLine("The student reads 3 books for weak");
        }
        public override void Write()
        {
            Console.WriteLine("The student writes for 4 hours");
        }
        public override void Relax()
        {
            Console.WriteLine("The student play video games");
        }
    }
}
