using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour
{
    public createGame game;
    public SlidersEqualizer equalizer;
    [SerializeField]
    GameObject panel;

    public void Stage()
    {
        if(equalizer.max == 100)
        {
            game.s1_Engine = equalizer.max1;
            game.s1_Gameplay = equalizer.max2;
            game.s1_Quest = equalizer.max3;
            panel.SetActive(false);
        }
    }
}
