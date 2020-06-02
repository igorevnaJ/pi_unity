using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int lives = 3;
    public int Lives
    {
        get {return lives;}
        set
        {
            if (value < 3) lives = value;
            livesBar.Refresh();
        }
    }
    private LivesBar livesBar;


    public GameObject restart;
    public static bool lose = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            Lives--;
            //lose = true;
            restart.SetActive(true);
        }
    }

    private void Awake()
    {
        livesBar = FindObjectOfType<LivesBar>();
    }
}
