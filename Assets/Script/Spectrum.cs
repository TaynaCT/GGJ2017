using UnityEngine;
using System.Collections;

[RequireComponent(typeof (AudioSource))]
public class Spectrum : MonoBehaviour {

    AudioSource audio;
    public float[] samples = new float[512];

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
                
        audio.GetSpectrumData(samples, 0, FFTWindow.Hamming);

        float c1 = samples[3] + samples[2] + samples[4];
        float c2 = samples[11] + samples[12] + samples[13];
        float c3 = samples[22] + samples[23] + samples[24];
        float c4 = samples[44] + samples[45] + samples[46] + samples[47] + samples[48] + samples[49];

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Wave");

        for (int i = 0; i < cubes.Length; i++)
        {
            switch (cubes[i].name)
            {
                case "c1": cubes[i].transform.localPosition += new Vector3(0, 0, -c1);
                    break;

                case "c2": cubes[i].transform.localPosition += new Vector3(0, 0, -c2);
                    break;

                case "c3":
                    cubes[i].transform.localPosition += new Vector3(0, 0, -c3);
                    break;

                case "c4":
                    cubes[i].transform.localPosition += new Vector3(0, 0, -c4);
                    break;

            }
        }       

	}
}
