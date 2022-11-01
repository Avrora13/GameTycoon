using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThemeChange : MonoBehaviour
{
    public TMP_Text textButtom;
    public TMP_Text textButtom2;
    public Themes theme;
    public createGame game;

    public void ChangeTheme()
    {
        game.s_Theme = theme;
        textButtom2.text = theme.m_name;
    }
}
