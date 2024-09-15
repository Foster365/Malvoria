using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField]float smoothSpeed, lookAheadDistance;
    float lookAhead;

    void Update()
    {
        if (target == null) return;

        transform.position = new Vector3(target.position.x , target.position.y + lookAhead, transform.position.z);
        lookAheadDistance = Mathf.Lerp(lookAhead, (lookAheadDistance * target.localScale.y), Time.deltaTime * smoothSpeed);
    }
}
