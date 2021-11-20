using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public Transform castPoint;
    public Transform firePoint;
    //public float sawRange = 8;
    public bool isFlipped = false;

    public GameObject bulletPref;
    
    PlayerController playerController;
    public int health = 100;
    int damage = 10;

    private void Start() {
        playerController = FindObjectOfType<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    public void takeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //playerController.enemyKillCount += 1;

        /*EnemySpawner enemySpawner = FindObjectOfType<EnemySpawner>();
        enemySpawner.EnemyDie(gameObject);*/
        
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerController.takeDamage(damage);
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPref, firePoint.position, firePoint.rotation);
    }

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if(transform.position.x < player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0, 180f, 0f);
            isFlipped = false;
        }
        else if(transform.position.x > player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

    public bool CanSeePlayer(float distance)
    {
        bool val = false;
        Vector2 endPos = castPoint.position + castPoint.right * distance;
        RaycastHit2D hitInfo = Physics2D.Linecast(castPoint.position, endPos, 1 << LayerMask.NameToLayer("Player"));

        if(hitInfo.collider != null)
        {
            if(hitInfo.collider.gameObject.CompareTag("Player"))
            {
                val = true;
            }
            else { val = false; }
        }

        Debug.DrawLine(castPoint.position, endPos, Color.red);
        return val;
    }
}
