using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    float timeLeft = 5.0f;
    Text text;
    int finalScore;

    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
        finalScore = Score.pointCounter;
    }

    void Update()
    {
        text.text = "Final score: " + finalScore;

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0) { 
            SceneManager.LoadScene("StartScene");
        }
    }
}