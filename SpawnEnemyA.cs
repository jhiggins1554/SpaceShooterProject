using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyA : MonoBehaviour
{
    public GameObject enemyA;
    public float spawnDelay = 1f;
    
    void Update()
    {
        spawnDelay -= Time.deltaTime;

        if (spawnDelay <= 0)
        {
            GameObject enA = Instantiate(enemyA, transform);
            enA.GetComponent<Rigidbody2D>().AddForce(Vector2.up * -2f, ForceMode2D.Impulse);
            Destroy(enA, 10f);
            spawnDelay = Random.Range(5f, 10f);
        }


    }
}
