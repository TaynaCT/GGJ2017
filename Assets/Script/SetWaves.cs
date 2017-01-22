using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWaves : MonoBehaviour {

    public GameObject wavePrefab;
    GameObject[] waves = new GameObject[20];
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            GameObject tempWave = (GameObject)Instantiate(wavePrefab);
            tempWave.transform.position = transform.position + new Vector3(i + 1.5f, 0, 0);
            tempWave.name = "Wave" + i;
            tempWave.transform.position += new Vector3(i + 2f, 0, 0);
            waves[i] = tempWave;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
