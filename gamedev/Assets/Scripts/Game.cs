using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Game : MonoBehaviour
{
    [SerializeField]
    int money;
    public int m_money { get { return money; } set { money = value; } }
    [SerializeField]
    int sub;
    public int m_sub { get { return sub; } set { sub = value; } }
    [SerializeField]
    TMP_Text text;

    public void Update()
    {
        text.text = $"${m_money}";
    }
}
