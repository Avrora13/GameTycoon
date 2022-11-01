using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlidersEqualizer : MonoBehaviour
{
    public List<Slider> sliders;
    public int max1;
    public int max2;
    public int max3;
    public int max;
    public Slider maxSlider;
    public List<TMP_Text> maxsText;

    private void Update()
    {
        max1 = Mathf.RoundToInt(sliders[0].value);
        max2 = Mathf.RoundToInt(sliders[1].value);
        max3 = Mathf.RoundToInt(sliders[2].value);
        max = max1 + max2 + max3;
        maxSlider.value = max;
        maxsText[0].text = $"{max1}";
        maxsText[1].text = $"{max2}";
        maxsText[2].text = $"{max3}";
        maxsText[3].text = $"{max}";
    }
}
