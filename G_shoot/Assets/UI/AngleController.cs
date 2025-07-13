using UnityEngine;

public class AngleController : MonoBehaviour
{
    public RectTransform arrowTransform;

    public void SetAngle(float angleDeg)
    {
        arrowTransform.rotation = Quaternion.Euler(0, 0, angleDeg);
    }
}