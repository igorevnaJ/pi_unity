using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{
    public int price; //установим цену нашему фрукту

    private void OnTriggerEnter2D(Collider2D col) //триггер фрукта, реагирует при взаемодействии с фруктом
    {
        Fruit_player.fruit += price; // добавляем монеты в указанную ссылку
        GameObject.FindGameObjectWithTag("Player").GetComponent<Fruit_player>().TextFruit.text = Fruit_player.fruit.ToString();
        Destroy(gameObject); //удаление фрукта с данной игровой сцены  
        Debug.Log("ok");
    }
}
