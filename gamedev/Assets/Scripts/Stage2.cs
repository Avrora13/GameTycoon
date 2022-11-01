using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
    public createGame game;
    public SlidersEqualizer equalizer;
    [SerializeField]
    GameObject panel;

    public void Stage()
    {
        if (equalizer.max == 100)
        {
            game.s2_Dialog = equalizer.max1;
            game.s2_Level = equalizer.max2;
            game.s2_AI = equalizer.max3;
            panel.SetActive(false);
        }
    }
}
