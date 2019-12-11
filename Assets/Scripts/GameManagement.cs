using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public int MaxLives = 5;
    public int InitialGold;

    public int mapIndex;
    public int level;
    public GameObject VictoryText;
    public GameObject GameOverText;

    public static int lives;
    private int gold;

    private int remainingEnemies;

    // Start is called before the first frame update
    void Start()
    {
        gold = InitialGold;

        // TODO: health drawer, money drawer.

        remainingEnemies = GetComponent<EnemyGenerator>().Waves.Sum(w => w.Amount);
    }

    public void EnemyEscaped()
    {
        lives--;
        // TODO: update health drawer
        if (lives <= 0)
        {
            GameOver();
        }
        remainingEnemies--;
        if (remainingEnemies == 0)
        {
            Victory();
        }
    }

    public void EnemyKilled()
    {
        remainingEnemies--;
        if (remainingEnemies == 0)
        {
            Victory();
        }
    }

    public void Victory()
    {
        VictoryText.SetActive(true);
        // Invoke("NextLevel", 5.0f);
    }

    public void GameOver()
    {
        GameOverText.SetActive(true);
        // Invoke("BackToMainMenu", 5.0f);
    }


}
