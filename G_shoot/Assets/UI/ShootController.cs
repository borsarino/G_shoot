using UnityEngine;
using UnityEngine.UI;

public class ShootController : MonoBehaviour
{
    public Rigidbody2D ballRb;
    public Image angleMeter;
    public Image powerMeter;
    public float maxAngle = 90f;
    public float maxPower = 10f;
    public Button stopButton;

    private float angleValue = 0f;
    private float powerValue = 0f;
    private int state = 0; // 0:角度選択中, 1:パワー選択中, 2:発射済み
    void Start()
    {
        stopButton.onClick.AddListener(OnStopButtonClicked);
    }

    void Update()
    {
        if (state == 0) // 角度を選んでる状態
        {
            angleValue = Mathf.PingPong(Time.time, 1f);
            angleMeter.fillAmount = angleValue;
        }
        else if (state == 1) // パワーを選んでる状態
        {
            powerValue = Mathf.PingPong(Time.time, 1f);
            powerMeter.fillAmount = powerValue;
        }
    }

    public void OnStopButtonClicked()
    {
        if (state == 0)
        {
            // 角度確定
            state = 1;
            Debug.Log("角度決定：" + (angleValue * maxAngle) + "度");
        }
        else if (state == 1)
        {
            // パワー確定 → 発射
            state = 2;
            Shoot();
            stopButton.interactable = false; // ボタンを無効にする
            Debug.Log("パワー決定：" + (powerValue * maxPower));
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
