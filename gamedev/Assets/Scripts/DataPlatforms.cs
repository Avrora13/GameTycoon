using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlatforms : MonoBehaviour
{
    public List<Platforms> dataPlatforms;
    [SerializeField]
    GameObject buttom;
    [SerializeField]
    GameObject panel;


    private void Start()
    {
        for (int i = 0; i < dataPlatforms.Count; i++)
        {
            GameObject newButtom = Instantiate(buttom, new Vector3(0, 0, 0), Quaternion.identity);
            newButtom.transform.SetParent(panel.transform, false);
            newButtom.GetComponent<PlatformChange>().platform = dataPlatforms[i];
            newButtom.GetComponent<PlatformChange>().textButtom.text = $"{newButtom.GetComponent<PlatformChange>().platform.m_name}";
            newButtom.SetActive(true);
        }
    }
}
