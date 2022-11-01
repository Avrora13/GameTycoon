using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlatformChange : MonoBehaviour
{
    public TMP_Text textButtom;
    public TMP_Text textButtom2;
    public Platforms platform;
    public createGame game;

    public void ChangePlatform()
    {
        game.s_Platform = platform;
        textButtom2.text = platform.m_name;
    }
}
