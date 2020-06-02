using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candy_player : MonoBehaviour
{
    static public int candy; //переменная для конфеты

    [SerializeField]
    public Text TextCandy; //в данную ссылку будем переносить текстовую информацию о конфетах

    private void Start()
    {
        candy = 0; //по умолчанию, при запуске сцены количество монет = 0 
    }

}
