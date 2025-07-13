using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    private bool isGameClear = false;
    public GameObject gameClearUI;
    public GameObject gameOverUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameClear()
    {
        Debug.Log("Game Clear");
        gameClearUI.SetActive(true);
        isGameClear = true;
    }

    public void GameOver()
    {
        if (isGameClear) return; // すでにクリアしている場合は何もしない
        Debug.Log("Game Over");
        gameOverUI.SetActive(true);
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void ToStage1()
    {
        SceneManager.LoadScene("G_shoot");
    }

    public void ToStage2()
    {
        SceneManager.LoadScene("G_shoot2");
    }

    public void ToStage3()
    {
        SceneManager.LoadScene("G_shoot3");
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
