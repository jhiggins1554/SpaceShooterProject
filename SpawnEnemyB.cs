using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyB : MonoBehaviour
{
    public GameObject enemyB;
    public float spawnDelay = 2f;

    void Update()
    {
        spawnDelay -= Time.deltaTime;

        if (spawnDelay <= 0)
        {
            GameObject enB = Instantiate(enemyB, transform);
            enB.GetComponent<Rigidbody2D>().AddForce(Vector2.up * -4f, ForceMode2D.Impulse);
            Destroy(enB, 5f);
            spawnDelay = Random.Range(2f, 5f);
        }
    }
}
