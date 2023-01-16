using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    // Start is called before the first frame update


    private GameObject test;


    void Start()
    {
        test = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        test.transform.position = Input.mousePosition;
    }
}
