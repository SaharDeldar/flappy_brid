using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatepipe : MonoBehaviour
{
    public GameObject target;
    public float last_x;
    // Start is called before the first frame update
    void Start()
    {
        last_x=transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - last_x >10)
        {
        int r1=Random.Range(-5,-15);
        Vector3 my_pos1=new Vector3(transform.position.x+10,transform.position.y+r1,0);
        Instantiate(target,my_pos1,transform.rotation ); 
        last_x=transform.position.x;

        int r2=r1+32;
        Vector3 my_pos2=new Vector3(transform.position.x+10,transform.position.y+r2,0);
        Instantiate(target,my_pos2,transform.rotation ); 
        last_x=transform.position.x;
        }
    }
}
