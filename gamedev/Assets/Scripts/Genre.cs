using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Game/Genre")]
public class Genre : ScriptableObject
{
    [SerializeField]
    int id;
    public int m_id { get { return id; } }
    [SerializeField]
    string nameGenre;
    public string m_name { get { return nameGenre; } set { nameGenre = value; } }
    [Range(0, 100)]
    public int interest;
    [Range(0, 100)]
    public int s1_Engine;
    [Range(0, 100)]
    public int s1_Gameplay;
    [Range(0, 100)]
    public int s1_Quest;
    [Range(0, 100)]
    public int s2_Dialog;
    [Range(0, 100)]
    public int s2_Level;
    [Range(0, 100)]
    public int s2_AI;
    [Range(0, 100)]
    public int s3_World;
    [Range(0, 100)]
    public int s3_Graphic;
    [Range(0, 100)]
    public int s3_Sound;
}
