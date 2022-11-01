using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Game/Theme")]

public class Themes : ScriptableObject
{
    [SerializeField]
    int id;
    public int m_id { get { return id; } }
    [SerializeField]
    string nameTheme;
    public string m_name { get { return nameTheme; } set { nameTheme = value; } }
    [Range(0,100)]
    public int g_ratios_rpg;
    [Range(0, 100)]
    public int g_ratios_action;
    [Range(0, 100)]
    public int g_ratios_strategy;
    [Range(0, 100)]
    public int g_ratios_adventure;
    [Range(0, 100)]
    public int g_ratios_casual;
    [Range(0, 100)]
    public int g_ratios_simulation;
    [Range(0, 100)]
    public int interest;
}
