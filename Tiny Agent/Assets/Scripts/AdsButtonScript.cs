using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdsButtonScript : MonoBehaviour
{
    public Button watchAdsButton;

    // Update is called once per frame
    void Update()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            watchAdsButton.interactable = false;
        }
        else
        {
            watchAdsButton.interactable = true;
        }
    }
}
