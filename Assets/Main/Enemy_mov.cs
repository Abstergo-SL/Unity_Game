using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.AI;
using Unity.VisualScripting;
using System;
using UnityEditor.PackageManager;
using UnityEngine.Events;

public class Enemy_mov : MonoBehaviour 
{
    //private mov square;
    private GameObject player;
    public NavMeshAgent enemy;
   
    int speed = 50;
    bool chiv = true;
    Vector3 mcposition, enemyposition;
    

    // Start is called before the first frame update
    void Start()
    {

        enemy = GetComponent<NavMeshAgent>();
        enemy.speed = speed;
        enemy.acceleration = 1000;
        player = GameObject.Find("Player");
        

        //StartCounter();


    }


    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == player.name)
        {
            mcposition = player.transform.position;
            enemy.SetDestination(mcposition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //mcposition = GameObject.Find("Cube").transform.position;
        //enemyposition = GameObject.Find("Sphere").transform.position;
        
        

        //if (Input.GetMouseButton(1))
        //{
            
        //    Debug.Log(mcposition);
            
        //    ball.SetDestination(mcposition);

        //}

        //Forward();

    }

    /* private void OnCollisionEnter(Collision collision)
    {
        Forward();
    } */

    

    

}
