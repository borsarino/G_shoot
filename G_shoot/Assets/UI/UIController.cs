using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button stopButton;
    public Button retryButton;
    public Button nextButton;

    public Button BackButton; // 追加: 戻るボタン

    public ShootController shootController;

    void Start()
    {
        // STOPボタンは1回目で角度決定、2回目で力決定 → 発射
        stopButton.onClick.AddListener(OnStopClicked);

        retryButton.onClick.AddListener(OnRetryClicked);
        nextButton.onClick.AddListener(OnNextStageClicked);
        BackButton.onClick.AddListener(OnBackButtonClicked);
    }

    void OnStopClicked()
    {
        shootController.OnStopButtonClicked(); // 角度→力→発射を内部で制御
        Debug.Log("ストップボタン");
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

    void OnBackButtonClicked()
    {
        SceneManager.LoadScene("Title"); // 戻るボタンでメインメニューに戻る
    }
}