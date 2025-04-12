using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class SpiritScore : MonoBehaviour
{
    //stores score
    public int scoreNumber = 0;
    
    //references the TextMeshPro component that has the score text
    public TextMeshProUGUI score;

    
    void Start()
    {
        //sets initial score text
        score.text = scoreNumber.ToString();
    }

    //called when a regular spirit is clicked
    public void addToScore()
    {
        //updates score by 1
        scoreNumber++;
        score.text = scoreNumber.ToString();
    }

    //called when a golden spirit is clicked
    public void goldenSpiritScore()
    {
        //updates score by 5
        scoreNumber = scoreNumber + 5;
        score.text = scoreNumber.ToString();
    }
}
