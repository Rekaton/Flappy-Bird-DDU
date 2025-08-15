using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Triggered : MonoBehaviour
{

    int score = 0;
    public TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = "Score: 0";
    }

    private void PointScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
        //Debug.Log("Score: " + score);
    }

    private void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipes"))
        {
            Debug.Log("No more beer");
            GameOver();
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Oh no! The abyss took you...");
            GameOver();


        }
        else if (collision.gameObject.CompareTag("ScoreBox"))
        {
            PointScore();
            Destroy(collision.gameObject);
        }
    }

}
