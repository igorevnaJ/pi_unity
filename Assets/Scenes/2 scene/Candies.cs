using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candies : MonoBehaviour
{
    public int price; //установим цену нашей конфете

    private void OnTriggerEnter2D(Collider2D col) //триггер конфеты, реагирует при взаемодействии с конфетой 
    {
        Candy_player.candy += price; //добавляем конфету в указанную ссылку
        GameObject.FindGameObjectWithTag("Player").GetComponent<Candy_player>().TextCandy.text = Candy_player.candy.ToString();
        Destroy(gameObject); //удаление конфеты с данной игровой сцены  
        Debug.Log("ok");
    }
}
