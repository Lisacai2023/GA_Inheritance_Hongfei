namespace GA_Inheritance_Hongfei
{
    internal class Program
    {
        //Week3_Inheritance
        //Hongfei
        //01/31/2024
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            Console.WriteLine("Week3 Practice inheritance");

            Vehicle vehicle = new Vehicle("Red");
            //Console.WriteLine(vehicle.ToString());

            Land land = new Land("Purple",4);
            //Console.WriteLine(land.ToString());

            Air air = new Air("Green");
            //Console.WriteLine(air.ToString());

            Sea sea = new Sea("Orange", Sea.Type.submarine);
            //Console.WriteLine(sea.ToString());

            Plane plane = new Plane("Pink", 3);
            //Console.WriteLine(plane.ToString());

            Helicopter helicopter = new Helicopter("Blue", 2);
            //Console.WriteLine(helicopter.ToString());

            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(sea);
            vehicles.Add(land);
            vehicles.Add(plane);
            vehicles.Add(helicopter);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }

        }
    }
}
