using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button stopButton;
    public Button retryButton;
    public Button nextButton;
    public Button stageSelectButton;

    public ShootController shootController;

    void Start()
    {
        // STOPボタンは1回目で角度決定、2回目で力決定 → 発射
        stopButton.onClick.AddListener(OnStopClicked);

        retryButton.onClick.AddListener(OnRetryClicked);
        nextButton.onClick.AddListener(OnNextStageClicked);
        stageSelectButton.onClick.AddListener(OnStageSelectClicked);
    }

    void OnStopClicked()
    {
        shootController.OnStopButtonClicked(); // 角度→力→発射を内部で制御
    }

    void OnRetryClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnNextStageClicked()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            Debug.Log("次のステージがありません。");
        }
    }

    void OnStageSelectClicked()
    {
        SceneManager.LoadScene("StageSelect");
    }
}