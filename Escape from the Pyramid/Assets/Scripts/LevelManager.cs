using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreDisplay;


    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int noOfScore)
    {
        score += noOfScore;
        scoreDisplay.text = "Score: " + score;
    }
}
