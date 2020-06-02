using UnityEngine;
using UnityEditor;

public class Platform : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject platform;

    void Update()
    {
        //движение background влево
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
