using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    public Canvas canvas;
    RectTransform safeAreaTransform;
    Rect currentSafeArea = new Rect();
    ScreenOrientation currentOrientation = ScreenOrientation.AutoRotation;

    // Start is called before the first frame update
    void Start()
    {
        safeAreaTransform = GetComponent<RectTransform>();
        currentOrientation = Screen.orientation;
        currentSafeArea = Screen.safeArea;

        ApplySafeArea();
    }

    void ApplySafeArea()
    {
        if (safeAreaTransform == null) return;
        Rect safeArea = Screen.safeArea;
        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = safeArea.position + safeArea.size;
        anchorMin.x /= canvas.pixelRect.width;
        anchorMin.y /= canvas.pixelRect.height;
        anchorMax.x /= canvas.pixelRect.width;
        anchorMax.y /= canvas.pixelRect.height;

        safeAreaTransform.anchorMin = anchorMin;
        safeAreaTransform.anchorMax = anchorMax;

        currentOrientation = Screen.orientation;
        currentSafeArea = Screen.safeArea;
    }

    // Update is called once per frame
    void Update()
    {
        if ((currentOrientation != Screen.orientation) || (currentSafeArea != Screen.safeArea)){
            ApplySafeArea();
        }
    }
}
