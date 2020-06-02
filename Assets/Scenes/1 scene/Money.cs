using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int price; //цена монеты (какое к-ство будет прибавляться при сборе монеты)

    void OnTriggerEnter2D(Collider2D col)
    { //триггер, реагирует при взаимодействии с монетой
        Money_player.money += price; //добавляем монету в указанную ссылку
        GameObject.FindGameObjectWithTag("Player").GetComponent<Money_player>().TextMoney.text = Money_player.money.ToString();
        Destroy(gameObject); //удаление монеты с сцены
    }
}
