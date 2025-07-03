using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }
}
