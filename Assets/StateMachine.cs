using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private Animator anim;
    private bool isTurned = false;
    private bool attack = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            isTurned = !isTurned;
            anim.SetBool("Turned",isTurned);
            Debug.Log(isTurned);
            
        }
        if (Input.GetKeyDown("p")){
            Debug.Log("Attacking");
            attack = true;
            anim.SetTrigger("Attack 0");
        }
        
    }
}
