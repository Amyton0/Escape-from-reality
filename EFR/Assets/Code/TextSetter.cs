using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSetter : MonoBehaviour
{
    public int numberOfKeys = 0;

    void Update()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText(numberOfKeys.ToString());
    }
}
