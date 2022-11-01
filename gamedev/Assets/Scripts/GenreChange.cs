using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;

public class GenreChange : MonoBehaviour
{
    public TMP_Text textButtom;
    public TMP_Text textButtom2;
    public Genre genre;
    public createGame game;

    public void ChangeGenre()
    {
        game.s_Genre = genre;
        textButtom2.text = genre.m_name;
    }
}
