using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertBitsToNumber : MonoBehaviour
{
    [SerializeField] private BitValueTracker bitValueTracker = null;

    private TMPro.TMP_Text ButtonText = null;

    private void Start()
    {
        ButtonText = GetComponentInChildren<TMPro.TMP_Text>();
    }

    public void CalculateBitMaskValue()
    {
        if (!bitValueTracker)
        {
            Debug.LogError($"ConvertBitsToNumber At {gameObject.name}, needs BitValueTracker Component Set!");

            return;
        }

        int bitMaskToCalculate = 0;
        for (int i = 0; i < bitValueTracker.TotalBits(); ++i)
        {
            if (bitValueTracker.IsBitSetAt(i))
            {
                int bitMaskForElement = 1 << i;

                bitMaskToCalculate |= bitMaskForElement;
            }
        }

        if (!ButtonText)
        {
            Debug.LogError($"ButtonText At {gameObject.name}, needs Button Component Set!");

            return;
        }

        ButtonText.text = bitMaskToCalculate.ToString();
    }
}
