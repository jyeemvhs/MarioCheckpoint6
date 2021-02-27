using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform mario;

    public float smoothTime = 0.6f;
    private float xVelocity = 0.0f;
    private float yVelocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(mario.transform.position.x, mario.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float newPositionx = Mathf.SmoothDamp(transform.position.x, mario.transform.position.x, ref xVelocity, smoothTime);
        float newPositiony = Mathf.SmoothDamp(transform.position.y, mario.transform.position.y, ref yVelocity, smoothTime);
        transform.position = new Vector3(newPositionx, newPositiony, transform.position.z);

//        transform.position = new Vector3(mario.position.x, mario.position.y, transform.position.z);
    }
}
