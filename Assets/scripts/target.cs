using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : StateMachineBehaviour
{
    public int i = 0;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().pts[animator.GetInteger("currentcheck") +1].position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
