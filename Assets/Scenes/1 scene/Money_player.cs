using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_player : MonoBehaviour
{
    static public int money; //переменная для монетах

    [SerializeField]
    public Text TextMoney; //в данную ссылку будем переносить текстовую информацию о монетах

    void Start()
    {
        money = 0; //по умолчанию, при запуске сцены к-ство монет = 0
    }
}
