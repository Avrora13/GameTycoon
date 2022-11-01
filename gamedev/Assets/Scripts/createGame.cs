using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class createGame : MonoBehaviour
{
    [SerializeField]
    public DataGames dataGames;
    string nameGame;
    [SerializeField]
    TMP_InputField inputField;
    public string s_name { get { return nameGame; } set { nameGame = value; } }
    Genre genre;
    public Genre s_Genre { get { return genre; } set { genre = value; } }
    Themes theme;
    public Themes s_Theme { get { return theme; } set { theme = value; } }
    Platforms platform;
    public Platforms s_Platform { get { return platform; } set { platform = value; } }
    public int s1_Engine;
    public int s1_Gameplay;
    public int s1_Quest;
    public int s2_Dialog;
    public int s2_Level;
    public int s2_AI;
    public int s3_World;
    public int s3_Graphic;
    public int s3_Sound;
    bool creatingGame = false;
    [SerializeField]
    GameObject stage1Obj;

    public void Stage(int stage)
    {
        switch(stage)
        {
            case 0:
                if(genre != null && theme != null && platform != null)
                {
                    Game1 game = new Game1();
                    dataGames.games.Add(game);
                    s_name = inputField.text;
                    dataGames.games[dataGames.games.Count - 1].s_name = nameGame;
                    dataGames.games[dataGames.games.Count - 1].s_Genre = genre;
                    dataGames.games[dataGames.games.Count - 1].s_Theme = theme;
                    dataGames.games[dataGames.games.Count - 1].s_Platform = platform;
                    creatingGame = true;
                    this.gameObject.SetActive(false);
                    stage1Obj.SetActive(true);
                }
                break;
            case 1:
                dataGames.games[dataGames.games.Count - 1].s1_Engine = s1_Engine;
                dataGames.games[dataGames.games.Count - 1].s1_Gameplay = s1_Gameplay;
                dataGames.games[dataGames.games.Count - 1].s1_Quest = s1_Quest;
                break;
            case 2:
                dataGames.games[dataGames.games.Count - 1].s2_AI = s2_AI;
                dataGames.games[dataGames.games.Count - 1].s2_Dialog = s2_Dialog;
                dataGames.games[dataGames.games.Count - 1].s2_Level = s2_Level;
                break;
            case 3:
                dataGames.games[dataGames.games.Count - 1].s3_Graphic = s3_Graphic;
                dataGames.games[dataGames.games.Count - 1].s3_Sound = s3_Sound;
                dataGames.games[dataGames.games.Count - 1].s3_World = s3_World;
                break;
            case 4:
                dataGames.games[dataGames.games.Count - 1].sales = true;
                creatingGame = false;
                break;
        }
    }
    public int Rating()
    {
        int rating = 0;
        if (s1_Engine >= genre.s1_Engine)
        {
            rating++;
        }
        if (s1_Gameplay >= genre.s1_Gameplay)
        {
            rating++;
        }
        if (s1_Quest >= genre.s1_Quest)
        {
            rating++;
        }
        if (s2_AI >= genre.s2_AI)
        {
            rating++;
        }
        if (s2_Dialog >= genre.s2_Dialog)
        {
            rating++;
        }
        if (s2_Level >= genre.s2_Level)
        {
            rating++;
        }
        if (s3_Graphic >= genre.s3_Graphic)
        {
            rating++;
        }
        if (s3_Sound >= genre.s3_Sound)
        {
            rating++;
        }
        if (s3_World >= genre.s3_World)
        {
            rating++;
        }
        switch(genre.m_id)
        {
            case 0:
                int r_int = Random.Range(0, 101);
                if(theme.g_ratios_action > r_int)
                {
                    rating++;
                }
                break;
            case 1:
                r_int = Random.Range(0, 101);
                if (theme.g_ratios_adventure > r_int)
                {
                    rating++;
                }
                break;
            case 2:
                r_int = Random.Range(0, 101);
                if (theme.g_ratios_casual > r_int)
                {
                    rating++;
                }
                break;
            case 3:
                r_int = Random.Range(0, 101);
                if (theme.g_ratios_rpg > r_int)
                {
                    rating++;
                }
                break;
            case 4:
                r_int = Random.Range(0, 101);
                if (theme.g_ratios_simulation > r_int)
                {
                    rating++;
                }
                break;
            case 5:
                r_int = Random.Range(0, 101);
                if (theme.g_ratios_strategy > r_int)
                {
                    rating++;
                }
                break;
        }
        dataGames.games[dataGames.games.Count - 1].rating = rating;
        return rating;
    }

    public void startCreatingGame()
    {
        if(creatingGame != true)
        {
            this.gameObject.SetActive(true);
            s1_Engine = 0;
            s1_Gameplay = 0;
            s1_Quest = 0;
            s2_AI = 0;
            s2_Dialog = 0;
            s2_Level = 0;
            s3_Graphic = 0;
            s3_Sound = 0;
            s3_World = 0;
            s_name = "";
            s_Genre = null;
            s_Platform = null;
            s_Theme = null;
        }
    }
}
