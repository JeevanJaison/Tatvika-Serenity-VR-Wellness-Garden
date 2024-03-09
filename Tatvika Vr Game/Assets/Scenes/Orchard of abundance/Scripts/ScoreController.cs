using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreController : MonoBehaviour
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
            Destroy(target.gameObject);
            score++;
        }
        if (target.gameObject.tag == "Bomb")
        {
            score--;
            Destroy(target.gameObject);
        }
    }

}
