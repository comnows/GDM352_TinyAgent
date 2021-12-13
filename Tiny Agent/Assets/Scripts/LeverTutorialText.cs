using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeverTutorialText : MonoBehaviour
{
    public GameObject image;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        image.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
    }
}
