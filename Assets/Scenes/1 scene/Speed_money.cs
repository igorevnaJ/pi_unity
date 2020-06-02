using UnityEngine;
using UnityEditor;

public class Speed_money : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject money;

    void Update()
    {
        //движение moneys вправо
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}