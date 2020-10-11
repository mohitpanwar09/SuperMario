using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimScript : MonoBehaviour
{
    private Animator _anim;
    void Start()
    {
        _anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)){
            _anim.SetBool("Run", true);
    
        } 

        if(Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.D)){
            _anim.SetBool("Run", false);
        }  

        if(Input.GetKeyDown(KeyCode.Space)){
            _anim.SetBool("Jump", true);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            _anim.SetBool("Jump", false);
        }
    }
}
