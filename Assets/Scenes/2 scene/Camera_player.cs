using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_player : MonoBehaviour
{
    public GameObject camera_player; //переменная, за которой двигается камера

    void Update()
    {
        transform.position = new Vector3(camera_player.transform.position.x, camera_player.transform.position.y, -100f);
    }
}
