using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public BallController target;
    public float offset;

    

    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = target.transform.position.y + offset;
        transform.position = currentPosition;
    }
}
