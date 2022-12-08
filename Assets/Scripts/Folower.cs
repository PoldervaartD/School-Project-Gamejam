using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folower : MonoBehaviour
{
    public Transform follow;
    public float distBeforeReset = 4f;
    public float offset = 4f;

    [Space]
    public float smoothTime = 0.5f;

    private float targetY;

    private void Start()
    {
        targetY = transform.position.y;
    }

    void Update()
    {
        if (transform.position.y - follow.position.y < -distBeforeReset)
            targetY = follow.position.y + offset;

        transform.position = Vector3.Lerp(
            new Vector3(transform.position.x, transform.position.y, -1),
            new Vector3(0, targetY, 0),
            1 - Mathf.Pow(smoothTime, Time.deltaTime)
        );
        //transform.position = new Vector3(transform.position.x, follow.position.y + offset, transform.position.z);
    }
}
