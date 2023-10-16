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
        GetTimeText();
    }

    void GetTimeText()
    {
        time += Time.deltaTime;
        if (time >= 60f)
        {
            minutes++;
            time = 0f;
        }
        int seconds = Mathf.FloorToInt(time % 60f);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void AddScore()
    {
        score+=Random.Range(10,20);
        scoreText.text="Score "+score.ToString("0");
    }
}
