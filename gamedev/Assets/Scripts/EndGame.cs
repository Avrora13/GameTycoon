using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    createGame game;
    [SerializeField]
    List<TMP_Text> texts;
    [SerializeField]
    GameObject buttomCreate;


    public void GameCreated()
    {
        texts[0].text = game.dataGames.games[game.dataGames.games.Count - 1].s_name;
        texts[1].text = $"{Mathf.Round(game.s1_Engine / 3)}";
        texts[2].text = $"{Mathf.Round(game.s1_Gameplay / 3)}";
        texts[3].text = $"{Mathf.Round(game.s1_Quest / 3)}";
        texts[4].text = $"{Mathf.Round(game.s2_AI / 3)}";
        texts[5].text = $"{Mathf.Round(game.s2_Dialog / 3)}";
        texts[6].text = $"{Mathf.Round(game.s2_Level / 3)}";
        texts[7].text = $"{Mathf.Round(game.s3_Graphic / 3)}";
        texts[8].text = $"{Mathf.Round(game.s3_World / 3)}";
        texts[9].text = $"{Mathf.Round(game.s3_Sound / 3)}";
        texts[10].text = $"{game.Rating()}/10";
        buttomCreate.SetActive(true);
    }
}
