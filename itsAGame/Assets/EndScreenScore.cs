using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EndScreenScore : MonoBehaviour
{
     
    
    public TextMeshProUGUI finalScore;
    private void Update()
    {
        finalScore.text = "Your Score " + ScoreManager.score;
    }
}
