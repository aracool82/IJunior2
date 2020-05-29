using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    void Update()
    {
        transform.position = GetPosition();
    }

    private Vector3 GetPosition()
    {
        return new Vector3(_playerTransform.position.x, transform.position.y, transform.position.z);
    }
}
