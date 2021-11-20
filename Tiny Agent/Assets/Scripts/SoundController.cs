using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController soundInstance;
    [SerializeField] AudioSource audioSystem;

    public AudioClip[] soundVFXList;

    void Awake()
    {
        soundInstance = this;
    }

    public void PlaySoundEffect(int audioIndex)
    {
        audioSystem.PlayOneShot(soundVFXList[audioIndex]);
    }
}
