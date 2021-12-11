using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    //private Vector2 direction;
    private float timeInterval;
    public float throwForce = 4f;
    public float fieldofImpact;
    public float force;
    public LayerMask LayerToHit;
    private GrenadeThrow grenadeThrow;
    // Start is called before the first frame update
    void Start()
    {
        grenadeThrow = FindObjectOfType<GrenadeThrow>();
        var direction = transform.right + Vector3.up;
        //timeInterval = grenadeThrow.intervalTime;
        GetComponent<Rigidbody2D>().AddForce(direction * throwForce, ForceMode2D.Impulse);

        StartCoroutine(ExplodeTime());
    }

    IEnumerator ExplodeTime()
    {
        yield return new WaitForSeconds(2.5f);

        Explode();
    }

    void Explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldofImpact, LayerToHit);

        foreach(Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);

            Enemy enemy = obj.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.takeDamage(3);
            }

            PlayerController player = obj.GetComponent<PlayerController>();
            if(player != null)
            {
                player.takeDamage(1);
            }

            FireBarrel barrel = obj.GetComponent<FireBarrel>();
            if(barrel != null)
            {
                barrel.explode();
            }
        }

        Destroy(gameObject);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, fieldofImpact);
    }
}
