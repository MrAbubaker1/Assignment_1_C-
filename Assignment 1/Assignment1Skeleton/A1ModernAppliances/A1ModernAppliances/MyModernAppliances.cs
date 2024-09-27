using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        
        /// Adam
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");
            // Create long variable to hold item number
            long itemNumber;
            // Get user input as string and assign to variable.
            string input = Console.ReadLine();
            // Convert user input from string to long and store as item number variable.
            if(!long.TryParse(input, out itemNumber))
            {
                Console.WriteLine("Invalid item number entered.");
                return;
            }
            // Create 'foundAppliance' variable to hold appliance with item number
            
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Loop through Appliances
                // Test appliance item number equals entered item number

                    // Assign appliance in list to foundAppliance variable

                    // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }
            else
            {
                if (foundAppliance.Quantity > 0)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine("Appliance has been checked out.");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
            // Write "No appliances found with that item number."
            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."

        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        
        /// Jared, this is the method you need to implement
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");
            // Create string variable to hold entered brand
            string brand = Console.ReadLine(); 
            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliance = new List<Appliance>();
            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {
                if (appliance.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                {
                    foundAppliance.Add(appliance);
                }
            }
            DisplayAppliancesFromList(foundAppliance, 0);
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        
        ///Adam
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            // Write "Enter number of doors: "
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Double doors");
            Console.WriteLine("2 - Three doors");
            Console.WriteLine("3 - Four doors");
            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors
            int numberOfDoors;
            // Get user input as string and assign to variable
            string doorsInput = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            if (!int.TryParse(doorsInput, out numberOfDoors))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the doors.");
                return;
            }
            // Create list to hold found Appliance objects
            List<Appliance> foundRefrigerators = new List<Appliance>();
            // Iterate/loop through Appliances
            foreach (var appliance in Appliances)
            {
                if (appliance.Type == Appliance.ApplianceTypes.Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        foundRefrigerators.Add(refrigerator);
                    }
                }
                DisplayAppliancesFromList(foundRefrigerators, 0);
            }
                // Test that current appliance is a refrigerator
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        /// 
        /// Leilanie
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            // Write "Enter grade:"
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");
            Console.WriteLine("Enter grade: ");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade = "";
            // Test input is "0"
            if (input == "0")
            {
                grade = "Any";
            }
                // Assign "Any" to grade
            // Test input is "1"
            else if (input == "1")
            {
                grade = "Residential";
            }
                // Assign "Residential" to grade
            // Test input is "2"
            else if (input == "2")
            {
                grade = "Commerical";
            }
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }
            // Return to calling (previous) method
            // return;

            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");
            // Get user input as string
            input = Console.ReadLine();
            // Create variable to hold voltage
            short voltage = 0;
            // Test input is "0"
            if (input == "0")
            {
                // Assign 0 to voltage
                voltage = 0;
            }
            // Test input is "1"
            else if (input == "1")
            {
                // Assign 18 to voltage
                voltage = 18;
            }
            // Test input is "2"
            else if (input == "2")
            {
                // Assign 24 to voltage
                voltage = 24;
            }
            // Otherwise
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                return;
            }
                // Return to calling (previous) method
                // return;

            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum = (Vacuum)appliance;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal
                    if (grade == "Any" || (vacuum.Grade == grade && (voltage == 0 || vacuum.BatteryVoltage == voltage)))
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        
        ///Ibrahim
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Any");
            // Write "2 - Work site"
            Console.WriteLine("2 - Work Site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");
            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Create character variable that holds room type
            char roomType = 'A';
            // Test input is "0"
                // Assign 'A' to room type variable
            // Test input is "1"
                // Assign 'K' to room type variable
            // Test input is "2"
                // Assign 'W' to room type variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;
            switch (input)
            {
                case "0":
                    roomType = 'A'; //Any
                    break;
                case "1":
                    roomType = 'K'; //Kitchen
                    break;
                case "2":
                    roomType = 'W'; //Work Site
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance>found = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance is Microwave
                if (appliance is Microwave microwave)
                {
                    // Down cast Appliance to Microwave
                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        // Add current appliance in list to found list
                        found.Add(microwave);
                    }
                }
            }
            DisplayAppliancesFromList(found, 0);

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        ///
        ///Ibrahim
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quiestest");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating: ");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating = null;
            // Test input is "0"
                // Assign "Any" to sound rating variable
            // Test input is "1"
                // Assign "Qt" to sound rating variable
            // Test input is "2"
                // Assign "Qr" to sound rating variable
            // Test input is "3"
                // Assign "Qu" to sound rating variable
            // Test input is "4"
                // Assign "M" to sound rating variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
            switch (input)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Quietest";
                    break;
                case "2":
                    soundRating = "Quieter";
                    break;
                case "3":
                    soundRating = "Quiet";
                    break;
                case "4":
                    soundRating = "Moderate";
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test if current appliance is dishwasher
                if (appliance is Dishwasher dishwasher)
                {
                    // Down cast current Appliance to Dishwasher

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    if (soundRating == "Any" || dishwasher.SoundRatingDisplay.Equals(soundRating, StringComparison.OrdinalIgnoreCase))
                    {
                        // Add current appliance in list to found list
                        found.Add(dishwasher);
                    }

                }

            }

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
                        
                        
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        /// 
        /// Leilanie
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 – Refrigerators"
            Console.WriteLine("1 - Refrigerators");
            // Write "2 – Vacuums"
            Console.WriteLine("2 - Vacuums");
            // Write "3 – Microwaves"
            Console.WriteLine("3 - Mircowaves");
            // Write "4 – Dishwashers"
            Console.WriteLine("4 - Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance");

            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter type of appliance");
            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Convert user input from string to int
            int num;
            if(!int.TryParse(input, out num))
            {
                Console.WriteLine("Invalid Input"); 
                return;
            }
            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through appliances
            foreach (var appliance in Appliances)
            {
                if (applianceType == "0")
                {
                    found.Add(appliance);
                }
                else if (applianceType == "1" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (applianceType == "2" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (applianceType == "3" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (applianceType == "4" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
            }
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
             DisplayAppliancesFromList(found, num);
        }
    }
}
