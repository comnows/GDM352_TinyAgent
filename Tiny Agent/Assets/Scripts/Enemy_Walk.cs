using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Walk : StateMachineBehaviour
{
    public float movespeed = 2.5f;
    public float sawRange = 8f;
    public float attackRange = 3f;
    Transform player;
    Rigidbody2D rb;
    Enemy enemy;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       player = GameObject.FindGameObjectWithTag("Player").transform;
       rb = animator.GetComponent<Rigidbody2D>();
       enemy = animator.GetComponent<Enemy>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       enemy.LookAtPlayer();

       Vector2 target = new Vector2(player.position.x, rb.position.y);
       rb.position = Vector2.MoveTowards(animator.transform.position, target, movespeed * Time.fixedDeltaTime);
       //Vector2 newPos = Vector2.MoveTowards(rb.position, target, movespeed * Time.fixedDeltaTime);
       //rb.MovePosition(newPos);

       if(Vector2.Distance(player.position, rb.position) <= attackRange)
       {
           animator.SetTrigger("Attack");
       }

       if(Vector2.Distance(player.position, rb.position) > sawRange || player.GetComponent<PlayerController>().health <= 0)
       {
          animator.SetBool("PlayerFounded", false);
       }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.ResetTrigger("Attack");
    }
}
