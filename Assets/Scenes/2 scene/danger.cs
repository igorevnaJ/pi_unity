using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danger : MonoBehaviour
{
    private Rigidbody2D player;
    public Transform start;
    public GameObject Explode;

    private void Start()
    {
        player = FindObjectOfType<Player>().GetComponentInChildren<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = start.position;
            Debug.Log("Restart!");
        }
    }
}