using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWaves : MonoBehaviour {

    public GameObject wavePrefab;
    public float speed;
    GameObject[] waves = new GameObject[20];

    float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
        for (int i = 0; i < 20; i++)
        {
            GameObject tempWave = (GameObject)Instantiate(wavePrefab);
                          
            tempWave.transform.position = transform.position + new Vector3(i + 1.5f, 0, 0);
            tempWave.name = "Wave" + i;
            if (i > 10)
                tempWave.transform.position -= new Vector3(i + 2f, 0, 0);
            else
                tempWave.transform.position += new Vector3(i + 2f, 0, 0);

            waves[i] = tempWave;
            waves[i].active = false;            
                 
        }
       
	}
	
	// Update is called once per frame
	void Update () {
        int count = 0;
        int randWave = Random.Range(0, 20);
        int randFreq = Random.Range(0, 8);

        while (count < 10)
        {
            waves[randWave].active = true;

            if((waves[randWave] != null )&& (waves[randWave].active))
                waves[randWave].transform.position -= new Vector3(0, 0, Spectrum.freqBand[randFreq] * .01f);

            Debug.Log("randFreq =" + randFreq + "freqBand[randFreq] =" + Spectrum.freqBand[randFreq]);

            count++;
        }
        
    }
}
