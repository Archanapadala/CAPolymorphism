

namespace CAPolymorphism
{
    // Base class Vehicle
    class Vehicle
    {
        // Properties
        public string Make;
        public string Model;
        public int Year;
        public double RentalPricePerDay;

        // Constructor
        public Vehicle(string make, string model, int year, double rentalPricePerDay)
        {
            Make = make;
            Model = model;
            Year = year;
            RentalPricePerDay = rentalPricePerDay;
        }

        // Method to display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price Per Day: {RentalPricePerDay:C}");
        }
    }

    // Subclass Car
    class Car : Vehicle
    {
        // Additional properties
        public int NumberOfSeats;
        public string FuelType;

        // Constructor
        public Car(string make, string model, int year, double rentalPricePerDay, int numberOfSeats, string fuelType)
            : base(make, model, year, rentalPricePerDay)
        {
            NumberOfSeats = numberOfSeats;
            FuelType = fuelType;
        }

        // Method to display car details
        public void DisplayCarDetails()
        {
            DisplayVehicleDetails();
            Console.WriteLine($"Number of Seats: {NumberOfSeats}");
            Console.WriteLine($"Fuel Type: {FuelType}");
        }
    }

    // Subclass Truck
    class Truck : Vehicle
    {
        // Additional properties
        public double CargoCapacity;
        public string TransmissionType;

        // Constructor
        public Truck(string make, string model, int year, double rentalPricePerDay, double cargoCapacity, string transmissionType)
            : base(make, model, year, rentalPricePerDay)
        {
            CargoCapacity = cargoCapacity;
            TransmissionType = transmissionType;
        }

        // Method to display truck details
        public void DisplayTruckDetails()
        {
            DisplayVehicleDetails();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity} tons");
            Console.WriteLine($"Transmission Type: {TransmissionType}");
        }
    }

    // Subclass Motorcycle
    class Motorcycle : Vehicle
    {
        // Additional properties
        public string EngineType;
        public double FuelTankCapacity;

        // Constructor
        public Motorcycle(string make, string model, int year, double rentalPricePerDay, string engineType, double fuelTankCapacity)
            : base(make, model, year, rentalPricePerDay)
        {
            EngineType = engineType;
            FuelTankCapacity = fuelTankCapacity;
        }

        // Method to display motorcycle details
        public void DisplayMotorcycleDetails()
        {
            DisplayVehicleDetails();
            Console.WriteLine($"Engine Type: {EngineType}");
            Console.WriteLine($"Fuel Tank Capacity: {FuelTankCapacity} liters");
        }
    }

    class assignment4
    {
        static void Main(string[] args)
        {
            // Create instances of each subclass
            Car car = new Car("Toyota", "Corolla", 2021, 50.00, 5, "Gasoline");
            Truck truck = new Truck("Ford", "F-150", 2020, 80.00, 3.5, "Automatic");
            Motorcycle motorcycle = new Motorcycle("Honda", "CBR500R", 2019, 30.00, "Inline-4", 17.1);

            // Display details of each vehicle
            Console.WriteLine("Car Details:");
            car.DisplayCarDetails();
            Console.WriteLine();

            Console.WriteLine("Truck Details:");
            truck.DisplayTruckDetails();
            Console.WriteLine();

            Console.WriteLine("Motorcycle Details:");
            motorcycle.DisplayMotorcycleDetails();
            Console.WriteLine();
        }
    }
}
