using System.Collections;
using UnityEngine;

public class SpawnMoney : MonoBehaviour
{
    public GameObject money;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(money, new Vector2(Random.Range(-7f, 7f), 5f), Quaternion.identity);
            yield return new WaitForSeconds(0.9f);
        }
    }
}