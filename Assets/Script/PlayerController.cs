using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            gameObject.transform.position -= new Vector3(.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(.5f, 0, 0);
        }
    }

     void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.tag == "Wave")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
