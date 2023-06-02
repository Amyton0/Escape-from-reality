using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject panelDialog;
    public TMP_Text dialog;

    public string[] AnekdoteArray = new string[52] {"Идет мужик по улице, вдруг к нему подбегает человек в плаще, сует в карман",
        "листок бумаги, говорит: 'Сам не читай, никому не давай!' - и был таков. Мужик",
          "пожал плечами и пошел дальше, про записку забыл. Возвращается домой, жена видит",
        "- у него из кармана листок бумаги торчит. Она спрашивает:'А что это?' - 'Да",
"понимаешь', - говорит мужик - 'подбежал ко мне на улице какой-то тип в плаще,",
"говорит -сам не читай, никому не давай! - и убежал.' - 'Дай-ка посмотрю' говорит",
"жена. Достает записку, читает, вдруг как схватит скалку 'А ну-ка убирайся прочь",
"из моего дома!' И спустила мужика с лестницы.Сидит мужик у подьезда, горюет,",
"недоумевает. Мимо идет лучший друг, видит - тот сидит, горюет - спрашивает: 'Что",
"ты такой стремный?' - 'Да понимаешь', - говорит наш герой - 'подошел ко мне на",
"улице человек в плаще, сунул записку, говорит - сам не читай, никому не давай.",
"Жена прочитала - из дома выгнала...' - 'А что за записка', спрашивает друг,",
"берет, читает, и вдруг бросается на него с кулаками: 'Убью!' И гнал его три",
"квартала, соседи вызвали милицию. Приезжает мент, спрашивает: 'В чем дело,",
"товарищи?' - 'Да вот,' - говорит мужик - 'подбежал ко мне на улице тип в плаще,",
"сунул записку - сам не читай, никому не давай - и убежал. Жена прочитала - из",
"дому выгнала, лучший друг прочитал - напал, избил...' - 'Гхм, ну-ка гражданин,",
"дайте-ка нам вещественное доказательство... Ах вооот как! А ну-ка, посидишь у",
"меня в КПЗ, а я к прокурору!' - Надел на мужика наручники, сунул в камеру, а сам",
"в прокуратуру, завели дело.Состоялся суд. На суде председатель спрашивает:",
"'Подсудимый, знаете ли вы, в чем вас обвиняют?' - 'Не знаю, гражданин судья.",
"Понимаете, иду я по улице, ко мне подбегает человек в плаще, сует записку,",
        "говорит - сам не читай, никому не давай - Жена прочитала - из дома выгнала,",
        "лучший друг прочитал - напал, избил, постовой прочитал - засадил меня в суд...'",
        "- Судья достает папку: 'Записка приобщена к делу... Так... Ах вот оно что, ну",
        "дело ясное. Пожизненное заключение с конфискацией имущества, обжалованию не",
        "подлежит! Дело закрыто!'Едет наш герой по этапу на зону. Сидит, с зэками",
        "болтает: 'Ты за что? - Я-за убийство - А ты? - Я за грабеж - А ты? - Да ни за",
        "что! - Ну все ни за что, а все-таки? - Понимаете, иду я по улице, ко мне",
        "подбегает мужик в плаще, сует записку - сам не читай, никому не давай. Жена",
        "прочитала - из дома выгнала, лучший друг прочитал - напал, избил, мент прочитал",
        "- засадил меня в КПЗ, судья прочитал - дал пожизненное...'- 'Да,' - смеются зэки",
        "- 'не повезло тебе. А что за записка-то?' Мужик дает им записку, они читают, и",
        "сразу: 'Ах ты козел, мы тебя щас замочим!' Началась драка, вбежали охранники, от",
        "качки поезд перевернулся и зэки разбежались.Наш герой бежал без устали несколько",
        "недель пока не вышел к морю. Там он втихаря раздобыл денег и устроился на",
        "корабль, плывущий куда подальше. Капитан заметил странного парня и вызвал его к",
        "себе на разговор: 'Ну, я вижу, что ты скрываешься. Ты не бойся, я своих не",
        "выдам, и с паспортом тебе помогу, ты только скажи: чего натворил-то?' - 'Да",
        "ничего! Понимаешь, иду я по улице, ко мне подбегает мужик в плаще, сует записку",
        "- сам не читай, никому не давай. Жена прочитала - из дома выгнала, лучший друг",
        "прочитал - напал, избил, мент прочитал - засадил меня в КПЗ, судья прочитал -",
        "дал пожизненное, зэки в вагоне прочитали - с поезда выкинули...' - 'Ндаа,",
        "странная история... А записка-то сохранилась? Дай взглянуть' - Читает капитан",
        "записку и меняется в лице: 'Ах ты так, а я-то еще тебе с убежищем хотел",
        "помогать! А ну-ка ребятушки, скинем этого гада за борт! И записку свою",
        "прихвати!' И летит наш мужик за борт...Еле живой плывет мужик по океану, на",
        "исходе второго дня видит необитаемый остров. Вылезает на него, весь мокрый,",
        "дрожит, и все думает: а что ж в записке-то? Наконец решается ее прочитать,",
        "разворачивает, а там буквы смыло.", "разворачивает, а там буквы смыло.", "разворачивает, а там буквы смыло."};

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
