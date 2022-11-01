using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataGenre : MonoBehaviour
{
    public List<Genre> dataGenres;
    [SerializeField]
    GameObject buttom;
    [SerializeField]
    GameObject panel;


    private void Start()
    {
        for (int i = 0; i < dataGenres.Count; i++)
        {
            GameObject newButtom = Instantiate(buttom, new Vector3(0, 0, 0), Quaternion.identity);
            newButtom.transform.SetParent(panel.transform, false);
            newButtom.GetComponent<GenreChange>().genre = dataGenres[i];
            newButtom.GetComponent<GenreChange>().textButtom.text = $"{newButtom.GetComponent<GenreChange>().genre.m_name}";
            newButtom.SetActive(true);
        }
    }
}
