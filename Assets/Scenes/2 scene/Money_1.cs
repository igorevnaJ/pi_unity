using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_1 : MonoBehaviour
{
    public int price;//установим цену нашей монеты(какое кол-ство монет будет прибавлться при сборе определенной монеты)

    private void OnTriggerEnter2D(Collider2D col) //  триггер монеты ,реагирует при взаемодействии с монетой 
    {
        Money_player_1.money += price; // добавляем монеты в указанную ссылку
        GameObject.FindGameObjectWithTag("Player").GetComponent<Money_player_1>().TextMoney.text = Money_player_1.money.ToString();
        Destroy(gameObject); //удаление монеты с данной игровой сцены  
        Debug.Log("ok");
    }
}
