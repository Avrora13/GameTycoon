using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    public createGame game;
    public SlidersEqualizer equalizer;
    [SerializeField]
    GameObject panel;

    public void Stage()
    {
        if (equalizer.max == 100)
        {
            game.s3_World = equalizer.max1;
            game.s3_Graphic = equalizer.max2;
            game.s3_Sound = equalizer.max3;
            panel.SetActive(false);
        }
    }
}
