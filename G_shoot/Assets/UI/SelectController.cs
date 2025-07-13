using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectController : MonoBehaviour
{
    public Button stageOneButton;
    public Button stageTwoButton;
    public Button stageThreeButton;
    public Button endButton;


    void Start()
    {
        stageOneButton.onClick.AddListener(() => OnStageSelected(1));
        stageTwoButton.onClick.AddListener(() => OnStageSelected(2));
        stageThreeButton.onClick.AddListener(() => OnStageSelected(3));
        // endButton.onClick.AddListener(OnEndClicked);
    }

    void OnStageSelected(int stageNumber)
    {
        Debug.Log("ステージ " + stageNumber + " が選択されました。");
        // ステージ番号に応じてシーンを読み込む
        switch (stageNumber)
        {
            case 1:
                SceneManager.LoadScene("G_shoot");
                break;
            case 2:
                SceneManager.LoadScene("G_shoot");
                break;
            case 3:
                SceneManager.LoadScene("G_shoot");
                break;
            default:
                Debug.LogError("無効なステージ番号です: " + stageNumber);
                break;
        }

    }
    void OnEndClicked()
    {
        Debug.Log("ゲームを終了します。");
        // ゲームを終了

        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
