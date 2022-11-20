using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ClassRoom
    {
        public List<Pupil> Pupils;

        public ClassRoom(List<Pupil> pupils)
        {
            this.Pupils = pupils;
        }

        public void Print()
        {
            foreach (Pupil pupil in Pupils)
            {
                pupil.InfoAboutStudent();
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }
}
