

namespace CAPolymorphism
{
    // Base class Product
    class Product
    {
       
        public string ProductName;
        public double Price;
        public int Quantity;

        // Constructor
        public Product(string productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
        }
    }

    // Subclass Electronics
    class Electronics : Product
    {
        // Additional properties
        public string Brand;
        public string Warranty;

        // Constructor
        public Electronics(string productName, double price, int quantity, string brand, string warranty)
            : base(productName, price, quantity)
        {
            Brand = brand;
            Warranty = warranty;
        }

        // Method to display electronics details
        public void DisplayElectronicsDetails()
        {
            DisplayProductDetails();
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Warranty: {Warranty}");
        }
    }

    // Subclass Clothing
    class Clothing : Product
    {
        // Additional properties
        public string Size;
        public string Material;

        // Constructor
        public Clothing(string productName, double price, int quantity, string size, string material)
            : base(productName, price, quantity)
        {
            Size = size;
            Material = material;
        }

        // Method to display clothing details
        public void DisplayClothingDetails()
        {
            DisplayProductDetails();
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Material: {Material}");
        }
    }

    // Subclass Books
    class Books : Product
    {
        // Additional properties
        public string Author;
        public string Genre;

        // Constructor
        public Books(string productName, double price, int quantity, string author, string genre)
            : base(productName, price, quantity)
        {
            Author = author;
            Genre = genre;
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            DisplayProductDetails();
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
        }
    }

    class assignment3
    {
        static void Main(string[] args)
        {
            // Create instances of each subclass
            Electronics electronicProduct = new Electronics("Smartphone", 499.99, 10, "Samsung", "1 year");
            Clothing clothingProduct = new Clothing("T-shirt", 19.99, 20, "L", "Cotton");
            Books bookProduct = new Books("The Great Gatsby", 9.99, 30, "F. Scott Fitzgerald", "Fiction");

            // Display details of each product
            Console.WriteLine("Electronics:");
            electronicProduct.DisplayElectronicsDetails();
            Console.WriteLine();

            Console.WriteLine("Clothing:");
            clothingProduct.DisplayClothingDetails();
            Console.WriteLine();

            Console.WriteLine("Books:");
            bookProduct.DisplayBookDetails();
            Console.WriteLine();
        }
    }
}
