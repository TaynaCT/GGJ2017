﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Spectrum : MonoBehaviour
{
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[8];
    public GameObject waveObj = null;

    public bool active = false;
    public float timer;
    AudioSource audio;
    GameObject wave;

    // Use this for initialization
    void Start()
    {
        timer = 0;
        audio = GetComponent<AudioSource>();

        wave = (GameObject)Instantiate(waveObj, new Vector3(2f, .0f, 4), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        
        float c1 = samples[3] + samples[2] + samples[4];
        float c2 = samples[11] + samples[12] + samples[13];
        float c3 = samples[22] + samples[23] + samples[24];
        float c4 = samples[44] + samples[45] + samples[46] + samples[47] + samples[48] + samples[49];

        GameObject[] waves = GameObject.FindGameObjectsWithTag("Wave");

        for (int i = 0; i < waves.Length; i++)
        {
            switch (waves[i].name)
            {
                case "c1":                    
                    waves[i].transform.localPosition += new Vector3(0, 0, -c1);
                    break;

                case "c2":                    
                    waves[i].transform.localPosition += new Vector3(0, 0, -c2);
                    break;

                case "c3":                    
                    waves[i].transform.localPosition += new Vector3(0, 0, -c3);
                    break;

                case "c4":                    
                    waves[i].transform.localPosition += new Vector3(0, 0, -c4);
                    break;

            }
        }

        for (int i = 0; i < samples.Length; i++)
        {
            if (samples[i] < 0.035f && !active && timer == 0)
            {
                active = true;
            }

            //if (0.036f < samples[i] < 0.0f && !active && timer == 0)

                if (wave != null && active)
                    wave.transform.localPosition -= new Vector3(0, 0, c1*0.001f);

            if (wave.transform.localPosition.z < -34.0f)
            {
                timer = 0;
                active = false;
                wave.transform.localPosition = new Vector3(2f, .0f, 4);
            }          
            
        }
        
    }

    void GetSpectrumAudioSource()
    {
        audio.GetSpectrumData(samples, 0, FFTWindow.Hamming);      
          
    }

}
