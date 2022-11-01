using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Calender : MonoBehaviour
{
    public Date date;
    public List<TMP_Text> calender;
    bool pauseTime = false;
    bool stage1 = false;
    bool stage2 = false;
    bool stage3 = false;
    public List<GameObject> stages;
    public DataGames games;
    public Game game;
    int daysStage;
    int week = 7;
    int startMoney = 100000;
    int endMoney;
    public int rentCost;
    public float taxes = 3.03f;
    [SerializeField]
    GameObject weekSales;
    [SerializeField]
    GameObject panelSales;
    public List<GameObject> Objects;
    int countsales;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            pauseTime = !pauseTime;
        }
        if(pauseTime == false)
        {
            date.timeset -= Time.deltaTime;
        }
        if (date.timeset <= 0)
        {
            date.day += 1;
            date.timeset = 1;
            week--;
            if(week == 0)
            {
                if(games.games.Count > 0)
                {
                    for(int i = 0; i < games.games.Count; i++)
                    {
                        if(games.games[i].sales == true)
                        {
                            games.games[i].countSale = Random.Range(0, maxCountSale(i));
                            game.m_money += games.games[i].countSale * games.games[i].cost;
                            games.games[i].weekSale -= 1;
                            GameObject newButtom = Instantiate(weekSales, new Vector3(0, 0, 0), Quaternion.identity);
                            newButtom.transform.rotation = Quaternion.Euler(0, 0, 90);
                            newButtom.transform.SetParent(panelSales.transform, false);
                            newButtom.SetActive(true);
                            Objects.Add(newButtom);
                            if(countsales < games.games[i].countSale)
                            {
                                countsales = games.games[i].countSale;
                                for(int j = 0; j < Objects.Count; j++)
                                {
                                    Objects[j].GetComponent<Slider>().maxValue = countsales;
                                }
                            }
                            newButtom.GetComponent<Slider>().maxValue = countsales;
                            newButtom.GetComponent<Slider>().value = games.games[i].countSale;
                            if (games.games[i].weekSale == 0)
                            {
                                games.games[i].sales = false;
                            }
                        }
                    }
                }
                week = 7;
            }
            if(stage1 == true)
            {
                daysStage -= 1;
                if(daysStage == 0)
                {
                    stages[0].SetActive(true);
                    stage1 = false;
                }
            }
            else if (stage2 == true)
            {
                daysStage -= 1;
                if (daysStage == 0)
                {
                    stages[1].SetActive(true);
                    stage2 = false;
                }
            }
            else if (stage3 == true)
            {
                daysStage -= 1;
                if (daysStage == 0)
                {
                    stages[2].SetActive(true);
                    stage3 = false;
                }
            }
            if (date.day == 32)
            {
                endMoney = game.m_money;
                int plusMoney = endMoney - startMoney;
                int taxesmoney = (int)(taxes * plusMoney);
                if(plusMoney > 0)
                {
                    game.m_money -= taxesmoney + rentCost;
                }
                else
                {
                    game.m_money -= rentCost;
                }
                startMoney = game.m_money;
                date.i_month += 1;
                date.day = 1;
                if (date.i_month == 13)
                {
                    date.year += 1;
                    date.i_month = 1;
                }
            }
        }
        calender[0].text = $"{date.day}";
        calender[1].text = $"{date.month}";
        calender[2].text = $"{date.year}";
    }

    public void Stage(int stage)
    {
        switch(stage)
        {
            case 1:
                stage1 = true;
                break;
            case 2:
                stage2 = true;
                break;
            case 3:
                stage3 = true;
                break;
        }
        daysStage = 15;
    }

    int maxCountSale(int i)
    {
        return Random.Range(games.games[i].rating * 10, games.games[i].rating * 1000); 
    }
}
