using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class target : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
    {
        animator.gameObject.GetComponent<racer_mesh>().agent.destination = GameObject.FindObjectOfType<point_manage>().find(animator.GetInteger("current_check") + 1, animator.GetBool("cheat"));
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
