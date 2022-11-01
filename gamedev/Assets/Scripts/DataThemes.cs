using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataThemes : MonoBehaviour
{
    public List<Themes> dataThemes;
    [SerializeField]
    GameObject buttom;
    [SerializeField]
    GameObject panel;


    private void Start()
    {
        for(int i = 0; i < dataThemes.Count; i++)
        {
            GameObject newButtom = Instantiate(buttom, new Vector3(0, 0, 0), Quaternion.identity);
            newButtom.transform.SetParent(panel.transform, false);
            newButtom.GetComponent<ThemeChange>().theme = dataThemes[i];
            newButtom.GetComponent<ThemeChange>().textButtom.text = $"{newButtom.GetComponent<ThemeChange>().theme.m_name}";
            newButtom.SetActive(true);
        }
    }
}
