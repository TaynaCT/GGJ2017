using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool isPaused = false;

	
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
    }
}
