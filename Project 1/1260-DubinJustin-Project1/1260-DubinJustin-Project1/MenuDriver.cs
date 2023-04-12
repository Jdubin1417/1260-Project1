///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  1260-DubinJustin-Project1
//	File Name:         MenuDriver.cs
//	Description:       Allow user to create username and select menu options, then create MP3 File and display it,
//	                   or quit based on user-input                  
//	Course:            CSCI-1260 - Intro Comp Sci 2
//	Author:            Justin Dubin, dubinj@etsu.edu, East Tennessee State University
//	Created:           Friday, 15 Sept, 2022
//	Copyright:         Justin Dubin, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    /// <summary>
    /// Provides Menu class and its functionality.
    /// </summary>
    public class MenuDriver
    {
        /// <summary>
        /// Creates a Menu object, adds options to it, and gives functionality.
        /// </summary>
        public static void Main()
        {
            //Set up the look and feel of the Console window
            Console.BackgroundColor = ConsoleColor.Black;       //Change the background color of the window to white
            Console.ForegroundColor = ConsoleColor.Blue;        //Change the font color to blue
            Console.Title = "Menu Application";   //Set the text of the title bar (top left)
            
            Console.Write($"\n\n\tWelcome! In this file you can create or open an MP3! Please enter your name: ");
            String UserName = Console.ReadLine(); //Allows User to create Username

            Menu menu = new Menu("Menu");
            menu = menu + "Create new MP3 File" + "Display Current MP3 File" + "Quit";

            String UserTitle; //Creating Attributes
            String UserArtist;
            String UserSong;
            String UserTime;
            Decimal UserCost;
            Double UserSize;
            String UserPath;

            String SongTitle = " "; //Initilizing Attributes
            String Artist = " ";
            String SongReleaseDate = " ";
            String PlaybackTime = " ";
            Decimal DownloadCost = 0;
            Double FileSize = 0;
            String Path = " ";
            MP3 mp3 = null; 

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.QUIT)
            {
                
                switch (choice) //Gives menu Choices to user and allows user to
                                //create attributes for MP3 File
                {
                    case Choices.CREATE:
                        Console.WriteLine("You selected Create\n");

                        Console.WriteLine("Enter MP3 Title here: ");
                        SongTitle = Console.ReadLine();

                        Console.WriteLine("Enter Artist here: ");
                        Artist = Console.ReadLine();

                        Console.WriteLine("Enter Release Date here: ");
                        SongReleaseDate = Console.ReadLine();

                        Console.WriteLine("Enter Song Playtime IN MINUTES here: ");
                        PlaybackTime = Console.ReadLine();

                        Console.WriteLine("Enter Genre From List: ");
                        Console.WriteLine("Rock      = 1\n" +
                                          "Pop       = 2\n" + 
                                          "Jazz      = 3\n" +
                                          "Country   = 4\n" +
                                          "Classical = 5\n" + 
                                          "Other     = 6");
                        int Genre = int.Parse(Console.ReadLine());
                        Genre myGenre = (Genre)Genre;
                        Console.WriteLine("Enter Download Cost here: ");
                        DownloadCost = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter File Size here: ");
                        FileSize = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Album Photo Path here: ");
                        Path = Console.ReadLine();

                        mp3 = new MP3(SongTitle, Artist, SongReleaseDate, PlaybackTime, myGenre, DownloadCost, FileSize, Path);
                        Console.WriteLine(mp3.ToString());
                        Console.WriteLine();
                        Console.WriteLine("Press any Key to Continue!");
                        Console.ReadKey();
                        break;
                        
                    case Choices.DISPLAY: //Displays ToString() method or has user select
                                          //Option 1
                        Console.WriteLine("You selected Display");
                        if (mp3 == null)
                        {
                            Console.WriteLine("You must Create an MP3 File First. Please select option 1 in the menu to create MP3 File!");
                        }
                        else { Console.WriteLine(mp3.ToString()); }

                        Console.WriteLine();
                        Console.WriteLine("Press any Key to Continue!");
                        Console.ReadKey();
                        break;
                }
                choice = (Choices)menu.GetChoice();
            }
            if (choice == Choices.QUIT) //Allows user to exit program at any point from menu
            {
                Console.WriteLine("Press Any Key to Quit");
                Console.WriteLine("Goodbye, " + UserName);
                Console.ReadKey();

            }
        }
    }
}

