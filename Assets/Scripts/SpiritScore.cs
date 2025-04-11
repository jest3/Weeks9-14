using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class SpiritScore : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score++;
        scoreText.text = "Spirits Caught: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
