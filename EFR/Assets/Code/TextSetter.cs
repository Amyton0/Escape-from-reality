using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSetter : MonoBehaviour
{
    public int numberOfKeys = 0;
    public TMP_Text currentText;

    void Update()
    {
        currentText.text = numberOfKeys.ToString() + "/7";
    }
}
