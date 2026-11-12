namespace Records_y10._11
{
    internal class Program
    {

        struct Car
        {
            public string make, model, registryNum, colour;
            public int year, numOfDoors;
            public double price;

            public Car(string make, string model, string registryNum, string colour, int year, int numOfDoors, double price)
            {
                this.make = make;
                this.model = model;
                this.registryNum = registryNum;
                this.colour = colour;
                this.year = year;
                this.numOfDoors = numOfDoors;
                this.price = price;
            }
        }

        static void Main(string[] args)
        {
            Car[] cars = new Car[7];
            cars[0] = new Car("Tesla", "Roadster", "AB26 XYZ", "White", 2026, 5, 200000);
            cars[1] = new Car("Tesla", "Roadster", "CD26 KLM", "White", 2026, 5, 200000);
            cars[2] = new Car("Tesla", "Roadster", "EF26 QRT", "White", 2026, 5, 200000);
            cars[3] = new Car("Tesla", "Roadster", "GH26 WER", "White", 2026, 5, 200000);
            cars[4] = new Car("Tesla", "Roadster", "JK26 PLM", "White", 2026, 5, 200000);
            cars[5] = new Car("Tesla", "Roadster", "MN26 BVC", "White", 2026, 5, 200000);
            cars[6] = new Car("Tesla", "Roadster", "OP26 HGT", "White", 2026, 5, 200000);
        }

    }
}
