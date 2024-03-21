using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreController7 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }


    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Fruits")
        {
            score++;
        }
        if (target.gameObject.tag == "RottenFruits")
        {
            score--;
        }
        if (target.gameObject.tag == "Bomb")
        {
            score -= 5;
        }
        Destroy(target.gameObject);

    }

}
