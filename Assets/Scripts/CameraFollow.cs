using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Player _player;

    void Update()
    {
        transform.position = GetPosition();
    }

    private Vector3 GetPosition()
    {
        return new Vector3(_player.transform.position.x, transform.position.y, transform.position.z);
    }
}
