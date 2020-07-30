using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static float Lives;
    public static int EnemiesKilled;

    private float startLives = 10;

    public Image healthBar;
    public Text score;
    public Text gameOverScore;
    void Start()
    {
        Lives = startLives;
        EnemiesKilled = 0;
    }

    void Update()
    {
        healthBar.fillAmount = Lives / startLives;
        score.text = (EnemiesKilled * 4).ToString();
        gameOverScore.text = score.text;
    }
}
