using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] Text score;
    [SerializeField] int scoreNum = 0;

    void Start()
    {
        score.text = "Score: " + scoreNum;
    }

    public void increaseScore()
    {
        scoreNum += 10;
        score.text = "Score: " + scoreNum;
    }
}
