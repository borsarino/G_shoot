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
        Debug.Log("�Q�[���N���A");
        gameClearUI.SetActive(true);
    }

    public void GameOver()
    {
        Debug.Log("�Q�[���I�[�o�[");
        gameOverUI.SetActive(true);
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("Title"); // �^�C�g���V�[���ɑJ��
    }

    public void ToStage1()
    {
        SceneManager.LoadScene("G_shoot"); // �X�e�[�W1�ɑJ��
    }

    public void ToStage2()
    {
        SceneManager.LoadScene("G_shoot2"); // �X�e�[�W1�ɑJ��
    }

    public void ToStage3()
    {
        SceneManager.LoadScene("G_shoot3"); // �X�e�[�W1�ɑJ��
    }
}
