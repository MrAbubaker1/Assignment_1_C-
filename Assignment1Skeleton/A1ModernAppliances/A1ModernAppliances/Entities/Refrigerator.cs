using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    /// <summary>
    /// Represents a refrigerator
    /// </summary>
    class Refrigerator : Appliance
    {
        /// <summary>
        /// Field that holds number of fridge doors
        /// </summary>
        private readonly short _doors;
        /// <summary>
        /// Width of fridge
        /// </summary>
        private readonly int _width;
        /// <summary>
        /// Height of fridge
        /// </summary>
        private readonly int _height;

        /// <summary>
        /// Property for doors
        /// </summary>
        public short Doors
        {
            get { return _doors; }
        }

        /// <summary>
        /// Property for width
        /// </summary>
        public int Width
        {
            get { return _width; }
        }

        /// <summary>
        /// Property for height
        /// </summary>
        public int Height
        {
            get { return _height; }
        }

        /// <summary>
        /// Constructs Refrigerator object
        /// </summary>
        /// <param name="itemNumber">Item number</param>
        /// <param name="brand">Brand</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="wattage">Wattage</param>
        /// <param name="color">Color</param>
        /// <param name="price">Price</param>
        /// <param name="doors">Number of doors</param>
        /// <param name="width">Fridge width</param>
        /// <param name="height">Fridge height</param>
        public Refrigerator(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, short doors, int height, int width) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this._doors = doors;
            this._width = width;
            this._height = height;
        }

        public override string FormatForFile()
        {
            string commonFormatted = base.FormatForFile();
            string formatted = string.Join(';', commonFormatted, Doors, Width, Height);

            return formatted;
        }
        public override string ToString()
        {
            string doorsText = "";

            if (Doors == 2)
            {
                doorsText = "Double Doors";
            }

            else if (Doors == 3)
            {
                doorsText = "Three Doors";
            }

            else if (Doors == 4)
            {
                doorsText = "Four Doors";
            }


            string display =
                string.Format("\nItem Number: {0}", ItemNumber) + "\n" +
                string.Format("Brand: {0}", Brand) + "\n" +
                string.Format("Quantity: {0}", Quantity) + "\n" +
                string.Format("Wattage: {0}", Wattage) + "\n" +
                string.Format("Color: {0}", Color) + "\n" +
                string.Format("Price: {0}", Price) + "\n" +
                string.Format("Number of Doors: {0}", doorsText) + "\n" +
                string.Format("Height: {0}", Height) + "\n" +
                string.Format("Width: {0}", Width);
            

            return display;
        }

    }
}
