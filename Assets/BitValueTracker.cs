using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitValueTracker : MonoBehaviour
{
    [SerializeField] private Transform SearchFrom = null;

    private TMPro.TMP_Text[] Texts;
    
    private void Start()
    {
        Texts = SearchFrom.GetComponentsInChildren<TMPro.TMP_Text>();
    }

    public void ToggleText(int TextIDToToggle)
    {
        Texts[TextIDToToggle].text = Texts[TextIDToToggle].text == "" ? "X" : "" ;
    }

    public bool IsBitSetAt(int index)
    {
        return Texts[index].text.Length != 0;
    }

    public int TotalBits()
    {
        return Texts.Length;
    }
}
