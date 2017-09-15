using System;
namespace Ses4SimpleClassExample
{
    public class Car
    {
		public string petName;
		public int currSpeed;

		public Car():this("Chuck", 10)
		{
		}
        public Car(string petName):this(petName, 0)
		{
		}
		public Car(string petName, int currSpeed)
		{
            //validate name
            //validate currSpeed
            this.petName = petName;
            this.currSpeed = currSpeed;
		}

        public void PrintState()
		{
            Console.WriteLine("{0} is running at {1} MPH", petName, currSpeed);
        }
        public void SpeedUp(int delta){
            currSpeed += delta;
        }
    }
}
