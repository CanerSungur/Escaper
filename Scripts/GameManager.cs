using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;
    public GameObject gameOverUI;

    void Start()
    {
        GameIsOver = false;
    }

    void Update()
    {
        if (GameIsOver)
        {
            GameOver();
        }
        else
        {
            if (PlayerStats.Lives <= 0)
            {
                GameIsOver = true;
            }
        }
    }

    private void GameOver()
    {
        gameOverUI.SetActive(true);
        GameIsOver = true;
        Time.timeScale = 0.01f;
    }

    public void Retry()
    {
        gameOverUI.SetActive(false);
        GameIsOver = false;
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        {
            gameOverUI.SetActive(false);
            GameIsOver = false;
            Time.timeScale = 1;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
