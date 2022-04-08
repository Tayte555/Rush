using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWaveNum : MonoBehaviour
{
    public int waveNumber = 0;
    Text wave;

    // Start is called before the first frame update
    void Start()
    {
        wave = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        wave.text = "Wave Number: " + waveNumber;   
    }
}
