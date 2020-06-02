using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_player_1 : MonoBehaviour
{
    static public int money; // переменная для монет 

    [SerializeField]
    public Text TextMoney; //в данную ссылку будем переносить текстовую и-цию о монетах

    private void Start()
    {
        money = 0; // по умолчанию , при запуске сцены ко-ство монет =  0 
    }

}
