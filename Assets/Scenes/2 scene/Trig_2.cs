using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trig_2 : MonoBehaviour
{
    public string player;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == player)
        {
            {
                if (SceneManager.GetActiveScene().buildIndex == Level.Levels)
                {
                    Level.Levels++;
                }
                Debug.Log("Ура!");
                SceneManager.LoadScene(5);
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("NO");
            SceneManager.LoadScene(5);
        }
    }
}
