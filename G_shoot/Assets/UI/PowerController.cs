using UnityEngine;

public class PowerController : MonoBehaviour
{
    public RectTransform gaugeTransform; // 動かすゲージ
    public float moveDistance = 270f;    // 左右に動く距離
    public float speed = 100f;           // 動く速度（ピクセル/秒）

    private bool isFixed = false;
    public bool actvate = false;
    private float time = 0f;

    public float powerValue { get; private set; } // 0〜1 のパワー値

    void Start()
    {
        // ゲージを一番左に初期化
        gaugeTransform.anchoredPosition = new Vector2(-moveDistance / 2f, gaugeTransform.anchoredPosition.y);
    }

    void Update()
    {
        if (isFixed || !actvate) return;

        time += Time.deltaTime * speed;

        float offset = Mathf.PingPong(time, moveDistance);
        float xPos = offset - moveDistance / 2f;

        gaugeTransform.anchoredPosition = new Vector2(xPos, gaugeTransform.anchoredPosition.y);
    }

    public void FixPower()
    {
        actvate = false;
        isFixed = true;
        float xPos = gaugeTransform.anchoredPosition.x + moveDistance / 2f;
        powerValue = Mathf.Clamp01(xPos / moveDistance);
        Debug.Log("Fixed Power Value: " + powerValue);
    }

    public void ResetPower()
    {
        actvate = false;
        isFixed = false;
        time = 0f;
    }
}