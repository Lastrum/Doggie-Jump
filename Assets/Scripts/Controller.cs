using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Controller : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10;
    public static float topScore = 0.0f; 
    private float fallingThreshold = -50;

    public static bool death = false;
    
    public GameObject deathGui;
    public GameObject scoreGui;
    public TextMeshProUGUI deathScoreText;
    
    void Start()
    {
        Time.timeScale = 1;
        topScore = 0.0f; 
        scoreGui.SetActive(true);
        deathGui.SetActive(false);
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (death)
        {
            ToggleDeathMenu();
        }
        
        if (rb2d.velocity.y < fallingThreshold)
        {
            ToggleDeathMenu();
        }
        
        if (rb2d.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
        scoreText.text = "Score: " + Mathf.Round(topScore);
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
    }
    
    private void ToggleDeathMenu()
    {
        Time.timeScale = 0;
        deathGui.SetActive(true);
        scoreGui.SetActive(false);
        deathScoreText.text = "Score: " + Mathf.Round(topScore);
        
        int score = (int) Math.Round(topScore);
        if (PlayerPrefs.GetInt("Score") < score)
        {
            PlayerPrefs.SetInt("Score", score);
        }
    }
    
    
    
}
