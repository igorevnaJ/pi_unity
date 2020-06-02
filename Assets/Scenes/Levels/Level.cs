using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public static int Levels = 1; //сколько уровней будет открыто при старте
    [SerializeField]
    Sprite open; //картинка открытого/пройденного уровня
    [SerializeField]
    Sprite closed; //картинка закрытого/не пройденного уровня

    void Start()
    {
     for(int i = 0; i < transform.childCount; i++) //узнаем, какие есть дочерние объекты у all_level и будемобращаться именно к этим элементам
        {
            if(i < Levels) //если i < нашего levels (сейчас 1), то мі делаем кнопку активной 
            {
                transform.GetChild(i).GetComponent<Image>().sprite = open;
                transform.GetChild(i).GetComponent<Button>().interactable = true; //кнопка становится активной(реагирует на нажатие)
            } else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = closed;
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }   
    }
}
