using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private int score;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Assert.IsNotNull(scoreText, "No Score TMP applied");
        displayScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        displayScore();
    }
    private void displayScore()
    {
        scoreText.text = "Score: " + score;
    }
}
