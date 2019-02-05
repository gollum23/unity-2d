using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Debug.Log("Colision");
    // }
    public Text scorePlayerText;
    public Text scoreEnemyText;

    int scorePlayerValue;
    int scoreEnemyValue;

    public SceneChanger sceneChanger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "Jugador")
        {
            scoreEnemyValue++;
            updateScoreText(scoreEnemyText, scoreEnemyValue);
        }
        else if(gameObject.tag == "Enemy")
        {
            scorePlayerValue++;
            updateScoreText(scorePlayerText, scorePlayerValue);
        }

        collision.GetComponent<BallBehaviour>().gameStarted = false;

        CheckScore();

    }

    void CheckScore()
    {
        if(scorePlayerValue >= 3)
        {
            sceneChanger.ChangeSceneTo("WinScene");
        }
        else if(scoreEnemyValue >= 3)
        {
            sceneChanger.ChangeSceneTo("LoseScene");
        }
    }

    void updateScoreText(Text label, int score)
    {
        label.text = score.ToString();
    }
}
