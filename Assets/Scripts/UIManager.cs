using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI endTimeText;
    public TextMeshProUGUI endScoreText;
    public GameObject endGameUI;

    float time = 0f;
    int minutes = 0;
    int score=0;

    private void Awake()
    {
        CreateSingleton();
    }

    private void CreateSingleton()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void FixedUpdate()
    {
        timeText.text= GetTimeText();
    }

    string GetTimeText()
    {
        time += Time.deltaTime;
        if (time >= 60f)
        {
            minutes++;
            time = 0f;
        }
        var seconds = Mathf.FloorToInt(time % 60f);
        var result = string.Format("{0:00}:{1:00}", minutes, seconds);
        return result;
    }
    public void AddScore()
    {
        score+=Random.Range(10,20);
        scoreText.text="Score "+score.ToString("0");
    }
    public void EndGame()
    {
        endGameUI.SetActive(true);
        endTimeText.text= GetTimeText();
        endScoreText.text= "Score " + score.ToString("0");
        Time.timeScale = 0f;
    }
}
