using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
    [SerializeField]
    private bool isGround;

    void Start()
    {
        // isGround = false; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = collision.gameObject.CompareTag("Ground");
        Debug.Log(collision.gameObject.tag);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = !collision.gameObject.CompareTag("Ground");
    }

    public bool CheckGround()
    {
        return isGround;
    }
}

