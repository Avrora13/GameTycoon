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
    [SerializeField]
    Calender calender;
    public List<GameObject> platformsObj;

    private void Start()
    {
        List<GameObject> platformsObj = new List<GameObject>();
    }

    public void OpenPlatforms()
    {
        if(platformsObj != null)
        {
            for(int i = 0; i < platformsObj.Count; i++)
            {
                Destroy(platformsObj[i]);
            }
            platformsObj.Clear();
        }
        for (int i = 0; i < dataPlatforms.Count; i++)
        {
            if (dataPlatforms[i].yearAdded <= calender.date.year)
            {
                GameObject newButtom = Instantiate(buttom, new Vector3(0, 0, 0), Quaternion.identity);
                newButtom.transform.SetParent(panel.transform, false);
                newButtom.GetComponent<PlatformChange>().platform = dataPlatforms[i];
                newButtom.GetComponent<PlatformChange>().textButtom.text = $"{newButtom.GetComponent<PlatformChange>().platform.m_name}";
                newButtom.SetActive(true);
                platformsObj.Add(newButtom);
            }
        }
    }
}
