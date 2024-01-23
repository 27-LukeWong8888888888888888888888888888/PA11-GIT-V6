using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdateScript : MonoBehaviour
{
    public Text ScoreText;
    int score;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            score += 10;
            ScoreText.text = "Score: " + score;
        }
    }
}
