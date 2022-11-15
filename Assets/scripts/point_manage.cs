using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_manage : MonoBehaviour
{
    public GameObject[] pts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 find(int po, bool che = false)
    {
        foreach(GameObject pi in pts)
        {
            if(pi.GetComponent<_waypoints>().current == po && pi.GetComponent<_waypoints>().route)
            {
                return pi.transform.position;
            }
        }
        return new Vector3();
    }
}
