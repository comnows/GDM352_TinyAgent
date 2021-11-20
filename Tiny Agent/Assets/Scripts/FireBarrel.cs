using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBarrel : MonoBehaviour
{
    public GameObject FireSprayPref;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Bullet"))
        {
            Instantiate(FireSprayPref, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
