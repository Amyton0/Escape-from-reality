using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject panelDialog;
    public TMP_Text dialog;

    public string[] AnekdoteArray = new string[52] {"���� ����� �� �����, ����� � ���� ��������� ������� � �����, ���� � ������",
        "������ ������, �������: '��� �� �����, ������ �� �����!' - � ��� �����. �����",
          "����� ������� � ����� ������, ��� ������� �����. ������������ �����, ���� �����",
        "- � ���� �� ������� ������ ������ ������. ��� ����������:'� ��� ���?' - '��",
"���������', - ������� ����� - '�������� �� ��� �� ����� �����-�� ��� � �����,",
"������� -��� �� �����, ������ �� �����! - � ������.' - '���-�� ��������' �������",
"����. ������� �������, ������, ����� ��� ������� ������ '� ��-�� �������� �����",
"�� ����� ����!' � �������� ������ � ��������.����� ����� � ��������, ������,",
"�����������. ���� ���� ������ ����, ����� - ��� �����, ������ - ����������: '���",
"�� ����� ��������?' - '�� ���������', - ������� ��� ����� - '������� �� ��� ��",
"����� ������� � �����, ����� �������, ������� - ��� �� �����, ������ �� �����.",
"���� ��������� - �� ���� �������...' - '� ��� �� �������', ���������� ����,",
"�����, ������, � ����� ��������� �� ���� � ��������: '����!' � ���� ��� ���",
"��������, ������ ������� �������. ��������� ����, ����������: '� ��� ����,",
"��������?' - '�� ���,' - ������� ����� - '�������� �� ��� �� ����� ��� � �����,",
"����� ������� - ��� �� �����, ������ �� ����� - � ������. ���� ��������� - ��",
"���� �������, ������ ���� �������� - �����, �����...' - '���, ��-�� ���������,",
"�����-�� ��� ������������ ��������������... �� ����� ���! � ��-��, �������� �",
"���� � ���, � � � ���������!' - ����� �� ������ ���������, ����� � ������, � ���",
"� �����������, ������ ����.��������� ���. �� ���� ������������ ����������:",
"'����������, ������ �� ��, � ��� ��� ��������?' - '�� ����, ��������� �����.",
"���������, ��� � �� �����, �� ��� ��������� ������� � �����, ���� �������,",
        "������� - ��� �� �����, ������ �� ����� - ���� ��������� - �� ���� �������,",
        "������ ���� �������� - �����, �����, �������� �������� - ������� ���� � ���...'",
        "- ����� ������� �����: '������� ��������� � ����... ���... �� ��� ��� ���, ��",
        "���� �����. ����������� ���������� � ������������ ���������, ����������� ��",
        "��������! ���� �������!'���� ��� ����� �� ����� �� ����. �����, � ������",
        "�������: '�� �� ���? - �-�� �������� - � ��? - � �� ������ - � ��? - �� �� ��",
        "���! - �� ��� �� �� ���, � ���-����? - ���������, ��� � �� �����, �� ���",
        "��������� ����� � �����, ���� ������� - ��� �� �����, ������ �� �����. ����",
        "��������� - �� ���� �������, ������ ���� �������� - �����, �����, ���� ��������",
        "- ������� ���� � ���, ����� �������� - ��� �����������...'- '��,' - ������� ����",
        "- '�� ������� ����. � ��� �� �������-��?' ����� ���� �� �������, ��� ������, �",
        "�����: '�� �� �����, �� ���� ��� �������!' �������� �����, ������� ���������, ��",
        "����� ����� ������������ � ���� �����������.��� ����� ����� ��� ������ ���������",
        "������ ���� �� ����� � ����. ��� �� ������� �������� ����� � ��������� ��",
        "�������, �������� ���� ��������. ������� ������� ��������� ����� � ������ ��� �",
        "���� �� ��������: '��, � ����, ��� �� �����������. �� �� �����, � ����� ��",
        "�����, � � ��������� ���� ������, �� ������ �����: ���� ��������-��?' - '��",
        "������! ���������, ��� � �� �����, �� ��� ��������� ����� � �����, ���� �������",
        "- ��� �� �����, ������ �� �����. ���� ��������� - �� ���� �������, ������ ����",
        "�������� - �����, �����, ���� �������� - ������� ���� � ���, ����� �������� -",
        "��� �����������, ���� � ������ ��������� - � ������ ��������...' - '����,",
        "�������� �������... � �������-�� �����������? ��� ���������' - ������ �������",
        "������� � �������� � ����: '�� �� ���, � �-�� ��� ���� � �������� �����",
        "��������! � ��-�� ���������, ������ ����� ���� �� ����! � ������� ����",
        "��������!' � ����� ��� ����� �� ����...��� ����� ������ ����� �� ������, ��",
        "������ ������� ��� ����� ����������� ������. �������� �� ����, ���� ������,",
        "������, � ��� ������: � ��� � � �������-��? ������� �������� �� ���������,",
        "�������������, � ��� ����� �����.", "�������������, � ��� ����� �����.", "�������������, � ��� ����� �����."};

    public string[] message = new string[22];
    public bool dialogStart = false;
    private bool[] keyTaken = new bool[7] { false, false, false, false, false, false, false };
    private bool isAnecdote = false;
    private int i = 1;
    private int k = 0;
    [SerializeField] private GameObject _object;

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
            string name = gameObject.tag;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EndDialogue();
        i = 1;
    }
    public void EndDialogue()
    {
        panelDialog.SetActive(false);
        dialogStart = false;
        isAnecdote = false;
    }
    private void SayAnecdote()
    {
        if (Input.GetKeyDown(KeyCode.Q) && i < 52)
        {
            dialog.text = message[i];
            i++;
        }
        if (i == 51)
        {
            i = 1;
            panelDialog.SetActive(false);

            if (!keyTaken[5])
            {
                TextSetter textSetter = _object.GetComponent<TextSetter>();
                textSetter.numberOfKeys += 1;
                keyTaken[5] = true;
            }
        }
    }
    private void Update()
    {
        if (dialogStart == true)
        {

            if (name == "Capibara")
            {
                if (Input.GetKeyDown(KeyCode.Q) && i < 22)
                {
                    dialog.text = message[i];
                    i++;
                }
                if (i == 22)
                {
                    i = 0;
                    panelDialog.SetActive(false);

                    if (!keyTaken[0])
                    {
                        TextSetter textSetter = _object.GetComponent<TextSetter>();
                        textSetter.numberOfKeys += 1;
                        keyTaken[0] = true;
                    }
                }
            }

            if (name == "Gosling")
            {
                if (Input.GetKeyDown(KeyCode.Q) && i < 12)
                {
                    dialog.text = message[i];
                    i++;
                }
                if (i == 12)
                {
                    i = 0;
                    panelDialog.SetActive(false);

                    if (!keyTaken[1])
                    {
                        TextSetter textSetter = _object.GetComponent<TextSetter>();
                        textSetter.numberOfKeys += 1;
                        keyTaken[1] = true;
                    }
                }
            }


            if (name == "Sina")
            {
                if (Input.GetKeyDown(KeyCode.Q) && i < 20)
                {
                    dialog.text = message[i];
                    i++;
                }
                if (i == 19)
                {
                    i = 0;
                    panelDialog.SetActive(false);

                    if (!keyTaken[2])
                    {
                        TextSetter textSetter = _object.GetComponent<TextSetter>();
                        textSetter.numberOfKeys += 1;
                        keyTaken[2] = true;
                    }
                }
            }

            if (name == "Zina")
            {
                if (Input.GetKeyDown(KeyCode.Q) && i < 11)
                {
                    dialog.text = message[i];
                    i++;
                }
                if (i == 11)
                {
                    i = 0;
                    panelDialog.SetActive(false);

                    if (!keyTaken[3])
                    {
                        TextSetter textSetter = _object.GetComponent<TextSetter>();
                        textSetter.numberOfKeys += 1;
                        keyTaken[3] = true;
                    }
                }
            }

            if (name == "Pyro")
            {
                if (Input.GetKeyDown(KeyCode.Q) && i < 13)
                {
                    dialog.text = message[i];
                    i++;
                }
                if (i == 13)
                {
                    i = 0;
                    panelDialog.SetActive(false);

                    if (!keyTaken[4])
                    {
                        TextSetter textSetter = _object.GetComponent<TextSetter>();
                        textSetter.numberOfKeys += 1;
                        keyTaken[4] = true;
                    }
                }
            }

            if (name == "Student" && isAnecdote == false)
            {
                
                if (Input.GetKeyDown(KeyCode.Q) && i < 10 )
                {
                    dialog.text = message[i];
                    i++;
                }
                if (i == 10)
                {
                    i = 0;
                    panelDialog.SetActive(false);
                }

            }

            if (name == "Student")
            {

                if (Input.GetKeyDown(KeyCode.T) && k < 52)
                {
                    isAnecdote = true;
                    dialog.text = AnekdoteArray[k];
                    k++;
                }
                if (k == 51)
                {
                    isAnecdote = false;
                    k = 0;
                    panelDialog.SetActive(false);
                }
            }

            if (name == "Izuminka")
            {
                if (Input.GetKeyDown(KeyCode.Q) && i < 20)
                {
                    dialog.text = message[i];
                    i++;
                }
                if (i == 20)
                {
                    i = 0;
                    panelDialog.SetActive(false);

                    if (!keyTaken[6])
                    {
                        TextSetter textSetter = _object.GetComponent<TextSetter>();
                        textSetter.numberOfKeys += 1;
                        keyTaken[6] = true;
                    }
                }
            }
        }
    }
}
