using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject panelDialog;
    public TMP_Text dialog;

    public string[] message = new string[10];
    public bool dialogStart = false;
    private int i = 1;
 
    void Start()
    {
        
        panelDialog.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panelDialog.SetActive(true);
            dialog.text = message[0];
            dialogStart = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panelDialog.SetActive(false);
        dialogStart = false;
    }

    private void Update()
    {
        if (dialogStart == true)
        {
            if (Input.GetKeyDown(KeyCode.Q) && i<10)
            {
                dialog.text = message[i] ;
                i++;
            }

        }
        if (i == 10)
        {
            i = 0;
            panelDialog.SetActive(false);
        }


        }
}
