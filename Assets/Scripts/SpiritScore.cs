using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class SpiritScore : MonoBehaviour
{
    public int scoreNumber = 0;
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = scoreNumber.ToString();
    }

    // Update is called once per frame
    public void addToScore()
    {
            scoreNumber++;
            score.text = scoreNumber.ToString();
    }
}
