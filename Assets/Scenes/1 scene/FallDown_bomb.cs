using UnityEngine;

public class FallDown_bomb : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 1.5f;

    void Update()
    {
        if (transform.position.y < -5.50f)
            Destroy(gameObject);

        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
