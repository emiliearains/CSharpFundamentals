using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_RepositoryPattern_Console
{
    // Method that runs/starts the UI part of the application
    class ProgramUI
    {
        public void Run()
        {
            //setup here
            Menu();

        }

        // Menu (method)
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // Get user input
                string input = Console.ReadLine();

                // Evaluate user input and act accordingly
                switch (input)
                {
                    case "1":
                        // Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View Content By Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        // Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue....");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create new StreamingContent
        private void CreateNewContent()
        {
            StreamingContent newContent = new StreamingContent();

            // Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            // Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            // Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, R, NC-17");
            newContent.MaturityRating = Console.ReadLine();

            // Star Rating
            Console.WriteLine("Enter the star count for the content (2, 5, 7.5, etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            // IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            // GenreType
            Console.WriteLine("Enter the Genre Number:/n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy");

            string genreAsString = Console.ReadLine();
            int genreasInt = int.Parse(genreAsString);
            newContent.TypeofGenre = (GenreType)genreasInt;

            /* 
             Horror = 1,
             RomCom,
             SciFi,
             Documentary,
             Bromance,
             Drama,
             Action,
             Comedy
            */
        }

        // View Current StreamingContent that is saved
        private void DisplayAllContent()
        {

        }

        // View Existing Content By Title
        private void DisplayContentByTitle()
        {

        }

        // Update Existing Content
        private void UpdateExistingContent()
        {

        }

        //Delete Existing Content
        private void DeleteExistingContent()
        {

        }
    }
}
