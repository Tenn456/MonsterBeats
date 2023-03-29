using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int victim = 0;
    public TMP_Text scoreText;
    public TMP_Text multiplierText;
    public int multiplier = 1;
    int conhit;
    public int hit = 0;
    const int hitInterval = 10;

    // Start is called before the first frame update
    void Start()
    {
        conhit = hitInterval;
        SetScoreText();
        SetMultiplierText();
    }

    // Update is called once per frame
    void Update()
    {
        if (hit >= conhit)
        {
            multiplier++;
            conhit += hitInterval;
        }
        SetScoreText();
        SetMultiplierText();
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + victim.ToString();
    }

    void SetMultiplierText()
    {
        multiplierText.text = "Multiplier: " + multiplier.ToString();
    }
}
