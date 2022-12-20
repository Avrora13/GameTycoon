using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Game/Platforms")]

public class Platforms : ScriptableObject
{
    [SerializeField]
    int id;
    public int m_id { get { return id; } }
    [SerializeField]
    string namePlatform;
    public string m_name { get { return namePlatform; } set { namePlatform = value; } }
    [SerializeField]
    string namePlatformCompany;
    public string m_nameCompany { get { return namePlatformCompany; } set { namePlatformCompany = value; } }
    [Range(0, 100)]
    public int interest;
    [SerializeField]
    int costLicense;
    public int i_costLicense { get { return costLicense; } set { costLicense = value; } }
    public int yearAdded;
    public int soldedConsole;
}
