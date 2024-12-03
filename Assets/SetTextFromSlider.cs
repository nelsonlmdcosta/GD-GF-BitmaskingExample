using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextFromSlider : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private TMPro.TMP_Text textObject;

    private void Start()
    {
        textObject = GetComponent<TMPro.TMP_Text>();   
    }

    public void Update()
    {
        textObject.text = ((int)slider.value).ToString();
    }

}
