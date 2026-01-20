using UnityEngine;

public class RingRotation : MonoBehaviour
{
    public float rotationSpeed = -180f;
    void Update()
    {
        Transform ringTransform = transform;

        ringTransform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}