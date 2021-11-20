using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        PlayerController player = hitInfo.GetComponent<PlayerController>();
        if(player != null)
        {
            player.takeDamage(damage);
        }

        if(!hitInfo.CompareTag("Ladder"))
        {
            Destroy(gameObject);
        }
    }
}
