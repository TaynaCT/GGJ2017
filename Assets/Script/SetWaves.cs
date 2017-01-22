using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWaves : MonoBehaviour
{

    public GameObject wavePrefab;
    public Texture2D[] waveText = new Texture2D[7];
    public float speed;
    public List<GameObject> waves = new List<GameObject>();
    int waveCount = 0;
    int lastI = -1;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("MakeWaves", 1, 2);
        StartCoroutine(wait());
        
    } 
    

    Vector3 RandPos()
    {
        int i = -1;
        Vector3[] pos = new Vector3[4];

        pos[0] = new Vector3(9f, -1, 1.9f);
        pos[1] = new Vector3(5.6f, -1, 1.9f);
        pos[2] = new Vector3(-6f, -1, 1.9f);
        pos[3] = new Vector3(-9f, -1, 1.9f);

        do
        {
            i = Random.Range(0, 4);
        } while (i == lastI);


        lastI = i;
        return pos[i];
    }

    void MakeWaves()
    {
        GameObject tempWave = (GameObject)Instantiate(wavePrefab, RandPos(), Quaternion.identity);
        tempWave.transform.eulerAngles = new Vector3(-90, 0, -180);
        tempWave.name = "Wave" + waveCount;
        waves.Add(tempWave);
        waveCount++;
                
    }

    IEnumerator wait()
    {
        int randFreq = Random.Range(0, 4);

        while (true)
        {
            try
            {
                for (int i = 0; i < waves.Count; i++)
                {
                    if (waves[i] != null)
                    {
                        waves[i].transform.position -= new Vector3(0, 0, Spectrum.freqBand[randFreq] * speed);
                    }
                }
            }
            catch { }
            yield return null;
        }
        
    }
}
