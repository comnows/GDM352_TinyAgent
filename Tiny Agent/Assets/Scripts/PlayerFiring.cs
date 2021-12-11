using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiring : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public int damage = 10;
    PlayerControls playerControls;
    bool ShootPressed;
    bool ShootReleased;

    private void Awake() 
    {
        playerControls = new PlayerControls();
        playerControls.PlayerControl.Shoot.performed += ctx => ShootPressed = true;
        playerControls.PlayerControl.Shoot.canceled += ctx => ShootReleased = true;
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable() 
    {
        playerControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown("Fire1"))
        if(ShootPressed)
        {
            Shoot();
        }
        ShootPressed = false;
        ShootReleased = false;
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        //SoundController.soundInstance.PlaySoundEffect(0);
    }
}
