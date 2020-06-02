using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit_player : MonoBehaviour
{
    static public int fruit; //переменная для фруктов

    [SerializeField]
    public Text TextFruit; //в данную ссылку будем переносить текстовую информацию о фруктах

    private void Start()
    {
        fruit = 0; //по умолчанию, при запуске сцены количество фруктов = 0 
    }

}
