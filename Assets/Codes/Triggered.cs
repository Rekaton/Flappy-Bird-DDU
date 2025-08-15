using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Triggered : MonoBehaviour
{

    new int score = 0;
    public TMP_Text scoreText;
 
    private void PointScore()
    {
        score += 1;
        Debug.Log("Score: " + score);
    }

    private void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("No more beer");
            GameOver();
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Oh no! The abyss took you...");
            GameOver();


        }
        else if (collision.gameObject.CompareTag("Score"))
        {
            PointScore();
            Destroy(collision.gameObject);
        }
    }

}
