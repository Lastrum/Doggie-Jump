using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    private void Update()
    {
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("Score");
    }
}
