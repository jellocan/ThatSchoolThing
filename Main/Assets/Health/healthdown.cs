using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthdown : MonoBehaviour {

    // Use this for initialization
    Animator animaty;
    int health = 9;
    void Start()
    {
        animaty = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update () {
    
            health -=(int) Time.deltaTime;
            animaty.SetInteger("healthc", health);
        

    }
}
