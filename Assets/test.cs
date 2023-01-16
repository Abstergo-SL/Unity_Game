using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject me;

    void Start()
    {
        me = this.GameObject(); 
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.W)){
             me.GetComponent<Rigidbody>().AddForce(0F,100F,0F);
        }
    }
}
