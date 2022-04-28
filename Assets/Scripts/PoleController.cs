using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleController : MonoBehaviour
{
    public float rotateSpeed;
    public GameView gv;

    private void OnMouseDrag()
    {
        gv.click();
        float rotateX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        transform.RotateAround(transform.position,Vector3.up, -rotateX);
        
    }

}
