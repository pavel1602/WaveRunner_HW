using UnityEngine;

public class RotationObstacle : MonoBehaviour
{
    [SerializeField] private float _rotationDelta;

    private void Update()
    {
        transform.Rotate(0, 0, _rotationDelta);
    }
}