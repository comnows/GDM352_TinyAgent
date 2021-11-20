using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CheckpointVcamera : MonoBehaviour
{
    public GameObject vCam1,vCam2;
    public GameObject fireVCam1, fireVCam2, fireVCam3;  
    public AudioMixerSnapshot inGame, cutScene;
    public GameObject CutScenePP;
    PlayerController playerController;
    PlayerFiring playerFiring;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            playerController = other.GetComponent<PlayerController>();
            playerFiring = other.GetComponent<PlayerFiring>();

            CutScenePP.SetActive(true);
            playerController.enabled = false;
            playerFiring.enabled = false;
            cutScene.TransitionTo(0.05f);
            fireVCam1.SetActive(true);
            vCam1.SetActive(false);
            StartCoroutine(VCamChange());
        }
    }
    IEnumerator VCamChange()
    {
        yield return new WaitForSeconds(2.5f);
        fireVCam2.SetActive(true);
        fireVCam1.SetActive(false);
        
        yield return new WaitForSeconds(2.5f);
        fireVCam3.SetActive(true);
        fireVCam2.SetActive(false);
        
        yield return new WaitForSeconds(2.5f);
        vCam2.SetActive(true);
        fireVCam3.SetActive(false);
        inGame.TransitionTo(0.05f);
        playerController.enabled = true;
        playerFiring.enabled = true;
        CutScenePP.SetActive(false);
        gameObject.SetActive(false);
        
    }
}
