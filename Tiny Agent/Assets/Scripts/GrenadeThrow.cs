using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
    [SerializeField]
    private float minDistance = 0.2f;
    [SerializeField]
    private float maxTime = 1f;

    private InputManager inputManager;

    private Vector2 startPosition;
    private float startTime;
    private float startIntervalTime;
    private Vector2 endPosition;
    private float endTime;
    private float endIntervalTime;
    public Vector2 direction;
    public float intervalTime;

    public GameObject grenade;
    public Transform ThrowPoint;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }

    private void OnEnable()
    {
        inputManager.OnStartTouch += SwipeStart;
        inputManager.OnEndTouch += SwipeEnd;
    }

    private void OnDisable()
    {
        inputManager.OnStartTouch += SwipeStart;
        inputManager.OnEndTouch += SwipeEnd;
    }

    private void SwipeStart(Vector2 position, float time)
    {
        startPosition = position; startTime = time; startIntervalTime = Time.time;
        Debug.Log("start time = " + time);
    }

    private void SwipeEnd(Vector2 position, float time)
    {
        endPosition = position; endTime = time; endIntervalTime = Time.time;
        Debug.Log("end time = " + time);
        DetectSwipe();
    }

    private void DetectSwipe()
    {
        float distance = Vector3.Distance(startPosition, endPosition);
        float totalTime = endTime - startTime;
        Debug.Log("total time = " + totalTime);
        if(distance >= minDistance && totalTime <= maxTime)
        {
            direction = startPosition - endPosition;
            intervalTime = endIntervalTime - startIntervalTime;
            Debug.Log("Swipe Detection");
            Debug.DrawLine(startPosition, endPosition, Color.red, 5f);
            ThrowGrenade();
        }
    }

    private void ThrowGrenade()
    {
        Instantiate(grenade, ThrowPoint.position, Quaternion.identity);
    }
}
