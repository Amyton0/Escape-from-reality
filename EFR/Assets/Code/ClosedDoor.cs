using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedDoor : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private GameObject openedDoor;

    void Update()
    {
        TextSetter textSetter = _object.GetComponent<TextSetter>();
        if (textSetter.numberOfKeys == 7)
        {
            gameObject.SetActive(false);
            openedDoor.SetActive(true);
        }
    }
}
