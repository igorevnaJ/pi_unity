using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;

    void Start()
    {
        StartCoroutine(Spawn());    
    }
    IEnumerator Spawn()
    {
        while(!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-7.5f, 7.5f), 5.75f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
