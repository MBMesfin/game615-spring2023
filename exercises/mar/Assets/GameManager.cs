using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TMP_Text scoreText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Mikki";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            score += 1;
            scoreText.text = score.ToString();

    }

    public void resetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
