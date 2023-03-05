using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; set; }
    
    public int score { get; set; }
    [SerializeField] private TextMeshProUGUI scoreText;


    private void Start()
    {
        Instance = this;
        SetScore(0);
    }

    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }
}