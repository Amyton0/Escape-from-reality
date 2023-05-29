using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController playerControllerObject = _object.GetComponent<PlayerController>();
        playerControllerObject.isInverse = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController playerControllerObject = _object.GetComponent<PlayerController>();
        playerControllerObject.isInverse = false;
    }
}
