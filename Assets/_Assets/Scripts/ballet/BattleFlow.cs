using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    public GameObject gameWinUI;
    // Start is called before the first frame update
    void Start()
    {
        gameWinUI.SetActive(false);
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnGameOver; // gắn hàm vào delegate
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }
    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0) // khi không còn enemy noà thì hiện win game
        {
            OnGameWin();
        }
    }
    private void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
