using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletA;
    public GameObject bulletB;
    public bool swap;
    public float cooldown = 0f;
    
    void Update()
    {
        cooldown -= Time.deltaTime;
        
        if (Input.GetButtonDown("Fire1") && swap == false && cooldown <= 0)
        {
            GameObject shotA = Instantiate(bulletA, transform);
            shotA.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 7f, ForceMode2D.Impulse);
            Destroy(shotA, 3f);
            cooldown = 0.1f;
        }
        else if (Input.GetButtonDown("Fire1") && swap == true && cooldown <= 0)
        {
            GameObject shotB = Instantiate(bulletB, transform);
            shotB.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 4f, ForceMode2D.Impulse);
            Destroy(shotB, 5f);
            cooldown = 0.6f;
        }

        if (Input.GetButtonDown("Fire2") && swap == false)
        {
            swap = true;
        }
        else if (Input.GetButtonDown("Fire2") && swap == true)
        {
            swap = false;
        }
    }
}
