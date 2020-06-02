using UnityEngine;
using UnityEditor;

public class Speed_player : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject player;

    void Update()
    {
        //движение игрока вправо
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}