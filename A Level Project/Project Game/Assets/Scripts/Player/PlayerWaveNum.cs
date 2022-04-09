using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWaveNum : MonoBehaviour
{
    public int waveNumber = 0;
    public Text wave;
    public Text finalWave;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        wave.text = "Wave Number: " + waveNumber;
        finalWave.text = "Final Wave Number: " + waveNumber;
    }
}
