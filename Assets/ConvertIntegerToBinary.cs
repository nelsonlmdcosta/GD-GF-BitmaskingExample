using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConvertIntegerToBinary : MonoBehaviour
{
    [SerializeField] private Slider slider;

    [SerializeField] private TMP_Text textValue;

    public void CalculateIntToBinary()
    {
        int ValueToConvert = (int)slider.value;

        string finalConversion = "";
        for (int i = 0; i < 4; ++i)
        {
            int BitMaskValue = ValueToConvert & (1 << i);

            finalConversion += BitMaskValue == 0 ? 0 : 1;
        }

        textValue.text = finalConversion;
    }
}
