using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGround : MonoBehaviour
{
    public GameObject DestroyPoint;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<DestroyPoint.transform.position.x){
            Destroy(this.gameObject);
        }
    }
}
