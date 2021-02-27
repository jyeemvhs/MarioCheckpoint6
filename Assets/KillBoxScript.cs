using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KillBoxScript : MonoBehaviour
{
//    public Transform mario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        other.transform.GetComponent<MarioScript>().ResetPos();
    }
}
