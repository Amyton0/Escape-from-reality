using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private bool exit = false;
    public int level;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && exit)
        {
            SceneManager.LoadScene(level);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        exit = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        exit = false;
    }
}