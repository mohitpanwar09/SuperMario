using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gumba : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed=-5f;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_speed*Time.deltaTime,0f,0f);
    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Gumba hit " + other.name);
        if(other.tag=="Pipe"){
            _speed*=-1;
        }
    }
}
