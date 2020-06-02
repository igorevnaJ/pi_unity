using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 15f;

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 7f ? 7f : mousePos.x;
            mousePos.x = mousePos.x < -7f ? -7f : mousePos.x;
            mousePos.y = mousePos.y > 4.1f ? 4.1f : mousePos.y;
            mousePos.y = mousePos.y < -4.1f ? -4.1f : mousePos.y;
            player.position = Vector2.MoveTowards(player.position,
                new Vector2(mousePos.x, mousePos.y),
                speed * Time.deltaTime);
        }
    }
}
