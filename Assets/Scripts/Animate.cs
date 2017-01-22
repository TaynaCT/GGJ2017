using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        /*
         * if (Press left)
         * {
         *      anim.setBool("left", true);
         * }
         * else
         * {
         *      anim.setBool("left", false);
         * }
           
            if (Press right)
         * {
         *      anim.setBool("right", true);
         * }
         * else
         * {
         *      anim.setBool("right", false);
         * }


        */
    }
}
