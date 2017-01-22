using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Spectrum : MonoBehaviour
{
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[4];
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
        MakeFrequencyBands();
               
    }

    void GetSpectrumAudioSource()
    {
        audio.GetSpectrumData(samples, 0, FFTWindow.Hamming);      
          
    }

    void MakeFrequencyBands()
    {
        int count = 0;
        for (int i = 0; i < freqBand.Length; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
             
            if(i== 7)
                sampleCount += 2;
            
            for(int j = 0; j < sampleCount; j++)
            {
                average += samples[count] * (count + 1);
                count++;
            }
            average /= count;
            freqBand[i] = average * 10;
        }
    }

}
