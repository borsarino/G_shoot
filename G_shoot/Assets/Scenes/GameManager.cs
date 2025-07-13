using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
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
        Debug.Log("ゲームクリア");
        gameClearUI.SetActive(true);
    }

    public void GameOver()
    {
        Debug.Log("ゲームオーバー");
        gameOverUI.SetActive(true);
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("Title"); // タイトルシーンに遷移
    }

    public void ToStage1()
    {
        SceneManager.LoadScene("G_shoot"); // ステージ1に遷移
    }

    public void ToStage2()
    {
        SceneManager.LoadScene("G_shoot2"); // ステージ1に遷移
    }

    public void ToStage3()
    {
        SceneManager.LoadScene("G_shoot3"); // ステージ1に遷移
    }
}
