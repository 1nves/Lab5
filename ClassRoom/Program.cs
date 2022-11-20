using System;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args) 
        {
            ClassRoom classRoom = new ClassRoom(new List<Pupil> {new GoodPupil(), new BadPupil(), new ExellentPupil(), new GoodPupil()});
            classRoom.Print();
            Console.ReadLine();
        }
    }
}
