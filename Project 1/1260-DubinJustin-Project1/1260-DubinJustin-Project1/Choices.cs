///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  1260-DubinJustin-Project1
//	File Name:         Choices.cs
//	Description:       A set of choices for a Menu in the MenuDriver.
//                     Gives the option of creating a new MP3, displaying
//                     current MP3, or quitting the program
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
    /// An enum containing the values for different choices for the Menu.
    /// 
    /// These options can be modified to suit the menu as you make changes to fit your program; 
    /// these are simply an example.
    /// </summary>
    public enum Choices
    {
        CREATE = 1,   //Enums have underlying integer values, this specifies to start with 1
        DISPLAY,       //...since we didn't specify, this will be 2
        QUIT    //...3        
    }
}