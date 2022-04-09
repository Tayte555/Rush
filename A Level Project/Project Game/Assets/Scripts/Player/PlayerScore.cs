using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int playerScore = 0;
    public Text score;
    public Text finalScore;

    void Start()
    {

    }

    void Update()
    {
        score.text = "Score: " + playerScore;
        finalScore.text = "Final Score: " + playerScore;
    }
}
