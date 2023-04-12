///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  1260-DubinJustin-Project1
//	File Name:         MP3.cs
//	Description:       Allows MP3 Class to be created, allows user to input new values,
//	                   and allow MP3 class to be displayed in String Format.               
//	Course:            CSCI-1260 - Intro Comp Sci 2
//	Author:            Justin Dubin, dubinj@etsu.edu, East Tennessee State University
//	Created:           Friday, 15 Sept, 2022
//	Copyright:         Justin Dubin, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    /// <summary>
    /// MP3 Class creates attributes of the MP3 File, creates attributes the user can
    /// change, and creates string format for the values to be displayed in legible manner
    /// </summary>
    public class MP3
    {
        /// <summary>
        /// Attributes
        /// Standard Attributes for MP3 Class to be listed by user
        /// </summary>
        public String SongTitle { get; set; }
        public String Artist { get; set; }
        public String SongReleaseDate { get; set; }    
        public String PlaybackTime { get; set; }    //playback time is in minutes
        public Genre Genre { get; set; }
        public Decimal DownloadCost { get; set; }
        public Double FileSize { get; set; } //File Size is in MB's
        public String Path { get; set; }

        /// <summary>
        /// "User" Attributes used are being used in Copy Constructor
        /// </summary>
        public String UserTitle { get; set; } 
        public String UserArtist { get; set; }
        public String UserSong { get; set; }
        public String UserTime { get; set; }    //playback time is in minutes
        public Genre UserGenre { get; set; }
        public Decimal UserCost { get; set; }
        public Double UserSize { get; set; } //File Size is in MB's
        public String UserPath { get; set; }

       
        /// <summary>
        /// Default Constructor for MP3 setting default values for attributes
        /// </summary>
        public MP3() 
        {
            String SongTitle = " ";
            String Artist = " ";
            String SongReleaseDate = " ";
            String PlaybackTime = " ";
            Genre Genre = Genre.Rock;
            Decimal DownloadCost = 0;
            Double FileSize = 0;
            String Path = " "; 

        }
        
        /// <summary>
        /// Constructor sets User Attributes to attributes defaulted in the 
        ///default constructor.
        /// </summary>
        /// <param name="SongTitle"></param>
        /// <param name="Artist"></param>
        /// <param name="SongReleaseDate"></param>
        /// <param name="PlaybackTime"></param>
        /// <param name="Genre"></param>
        /// <param name="DownloadCost"></param>
        /// <param name="FileSize"></param>
        /// <param name="Path"></param>
        /// <returns>User Attributes with value of original MP3 attributes</returns>
        public MP3(string SongTitle, string Artist, string SongReleaseDate, string PlaybackTime, Genre Genre, Decimal DownloadCost, Double FileSize, String Path) //Parameterized
        {
            UserTitle = SongTitle;
            UserArtist = Artist;
            UserSong = SongReleaseDate;
            UserTime = PlaybackTime;
            UserGenre = Genre;
            UserCost = DownloadCost;
            UserSize = FileSize;
            UserPath = Path;
        }
  
        /// <summary>
        /// Allows creating of other MP3's that will overwrite the existing MP3
        /// </summary>
        /// <param name="other">The Contact Object's name field value</param>
        /// <returns>New MP3 Attributes with new values</returns>
        public MP3(MP3 other) 
        {
            SongTitle = other.SongTitle;
            Artist = other.Artist;
            SongReleaseDate = other.SongReleaseDate;
            PlaybackTime = other.PlaybackTime;
            DownloadCost = other.DownloadCost;
            FileSize = other.FileSize;
            Path = other.Path;
        }

        /// <summary>
        /// Takes MP3 User values and converts them into readable string format
        /// </summary>
        /// <returns>String format of User attributes</returns>
        public override string ToString()
        {
            string MP3Str =    "MP3 Title: " + UserTitle.ToString() +
                             "\nArtist: " + UserArtist.ToString() +
                             "\nRelease Date: " + UserSong.ToString() +
                             "\nSong Playtime: " + UserTime.ToString() +
                             "\nGenre: " + UserGenre.ToString() +
                             "\nDownload Cost: " + UserCost.ToString() +
                             "\nFile Size: " + UserSize.ToString() +
                             "\nAlbum Photo: " + UserPath.ToString();   
            return MP3Str;
        }
    }
}