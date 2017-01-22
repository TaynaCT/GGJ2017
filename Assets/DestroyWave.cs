using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWave : MonoBehaviour {

    public SetWaves setWave;

	void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Wave")
        {
            setWave.waves.Remove(col.gameObject);
            Destroy(col.gameObject);            
        }
    }
}
