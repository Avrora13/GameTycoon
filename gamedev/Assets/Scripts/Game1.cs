using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : ScriptableObject
{
    string nameGame;
    public string s_name { get { return nameGame; } set { nameGame = value; } }
    Genre genre;
    public Genre s_Genre { get { return genre; } set { genre = value; } }
    Themes theme;
    public Themes s_Theme { get { return theme; } set { theme = value; } }
    Platforms platform;
    public Platforms s_Platform { get { return platform; } set { platform = value; } }
    public bool sales = false;
    public int weekSale = 15;
    public int cost = 9;
    public int countSale;
    public int s1_Engine;
    public int s1_Gameplay;
    public int s1_Quest;
    public int s2_Dialog;
    public int s2_Level;
    public int s2_AI;
    public int s3_World;
    public int s3_Graphic;
    public int s3_Sound;
    public int rating;
}
