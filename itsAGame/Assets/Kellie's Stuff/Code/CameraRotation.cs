using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform camTarget;
    public float plerp = 0.2f;
    public float rlerp = 0.1f;
    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position,plerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rlerp);
    }
}
