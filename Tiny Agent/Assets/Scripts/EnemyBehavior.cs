using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform backCastPoint;
    [SerializeField] Transform castPoint;
    [SerializeField] float sawRange;
    [SerializeField] float attackRange;
    [SerializeField] float moveSpeed;
    Animator animator;
    Rigidbody2D enemyRB;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CanSeePlayer(sawRange))
        {
            ChasePlayer();
        }
    }

    bool CanSeePlayer(float distance)
    {
        bool val = false;
        float castDist = distance;

        Vector2 endPos = castPoint.position + Vector3.right * distance;

        RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endPos, 1 << LayerMask.NameToLayer("asdf"));

        if(hit.collider != null)
        {
            if(hit.collider.CompareTag("Player"))
            {
                val = true;
            }
            else { val = false; }
        }

        return val;
    }

    void ChasePlayer()
    {
        if(Mathf.Abs(transform.position.x - player.position.x) > attackRange)
        {
            enemyRB.velocity = new Vector2(moveSpeed, 0);
        }
    }
}
