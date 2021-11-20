using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    private Vector2 direction;
    private float timeInterval;
    private float throwForce = 25f;
    private GrenadeThrow grenadeThrow;
    // Start is called before the first frame update
    void Start()
    {
        grenadeThrow = FindObjectOfType<GrenadeThrow>();
        direction = grenadeThrow.direction;
        timeInterval = grenadeThrow.intervalTime;
        GetComponent<Rigidbody2D>().AddForce(-direction * throwForce);
    }
}
