using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_scene : MonoBehaviour
{
    public void LoadScene(int Level)
    {
        SceneManager.LoadScene(Level);
        Debug.Log("asdasd");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
