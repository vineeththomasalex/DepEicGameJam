using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform Target;
    public float CameraFollowSpeed = 3.5f;
    public float yOffset;
    public float zOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 followPosition = Target.transform.position;
        followPosition.y = followPosition.y +yOffset;
        followPosition.z = followPosition.z +zOffset;
        this.transform.position = Vector3.Lerp(this.transform.position, followPosition, Time.deltaTime*CameraFollowSpeed);//Linear interpolation
        this.transform.LookAt(Target, Vector3.up);
    }
}
