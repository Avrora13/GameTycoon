using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public List<Slider> sliderList;
    public void ChangeBalance(int slider)
    {
        float count = sliderList[slider].value;
        float countMax = (100 - count);
        float all = 0;
        for(int i = 0; i < sliderList.Count; i++)
        {
            if(i != slider)
            {
                sliderList[i].maxValue = countMax;
            }
            all += sliderList[i].value;
            if(all > 100)
            {
                all -= 100;
                sliderList[slider].maxValue = sliderList[slider].value - all;
            }
        }
    }
}
