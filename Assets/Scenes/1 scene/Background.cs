using UnityEngine;
using UnityEditor;

public class Background : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject background;

    void Update()
    {
        //движение background влево
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        //перебрасывание первого background
        if (transform.position.x < -17f)
        {
            Instantiate(background, new Vector3(33.05f, 0f, 0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
