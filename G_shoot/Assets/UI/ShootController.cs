using UnityEngine;
using UnityEngine.UI;

public class ShootController : MonoBehaviour
{
    public Rigidbody2D ballRb;
    public float maxAngle = 90f;
    public float maxPower = 300f;
    public Button stopButton;

    private float angleValue = 0f;
    private float powerValue = 0f;
    private int state = 0; // 0:角度選択中, 1:パワー選択中, 2:発射, 3:発射後

    public AngleController angleController;
    public PowerController powerController;
    public GameManager myManager;

    void Start()
    {
        stopButton.onClick.AddListener(OnStopButtonClicked);
    }

    void Update()
    {
        if (state == 0) // 角度決定中
        {
            angleValue = Mathf.PingPong(Time.time, 1f);
            float angleDeg = angleValue * maxAngle;
            angleController.SetAngle(angleDeg); // 見た目の回転のみ
        }
        else if (state == 1) // パワー決定中
        {
            powerController.ResetPower(); // パワーゲージをリセット
            powerController.actvate = true; // ゲージを動かす
            state = 2;
        }
        else if (state == 2)
        {

        }
    }

    public void OnStopButtonClicked()
    {
        if (state == 0)
        {
            Debug.Log("角度決定：" + angleValue * maxAngle + "度");
            state = 1;
            return;
        }
        else if (state == 2)
        {
            powerController.FixPower(); // ゲージ止める
            powerValue = powerController.powerValue;
            stopButton.interactable = false;
            Debug.Log("パワー決定：" + powerValue * maxPower);
            if (ballRb != null)
            {
                Shoot(); // 発射処理
                state = 3; // 発射後の状態に変更
                Debug.Log("ボールを発射しました。");
            }
            else
            {
                Debug.LogError("Rigidbody2Dが設定されていません。");
            }
            return;
        }
    }

    void Shoot()
    {
        float angleDeg = angleValue * maxAngle;
        float power = powerValue * maxPower;

        Vector2 direction = Quaternion.Euler(0, 0, angleDeg) * Vector2.right;
        ballRb.AddForce(direction * power, ForceMode2D.Impulse);
    }
    
}