using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [Range(1f,2f)]
    [SerializeField] private float _speed = 1;

    [Range(4f,6f)]
    [SerializeField] private float _powerJamp = 5f;

    [SerializeField] private Rigidbody _rigidbody;

    private bool _onGraund = true;

    public event UnityAction CoinCollected;

    void Awake()
    {
        _rigidbody.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) && _onGraund ) || (Input.GetMouseButtonDown(0) && _onGraund))
            Jump();
    }

    private void FixedUpdate()
    {
        MoveRight();
    }

    private void MoveRight()
    {
        _rigidbody.AddForce(Vector3.right * _speed, ForceMode.Force);
    }

    private void Jump()
    {
        _onGraund = false;
        _rigidbody.AddForce(Vector3.up * _powerJamp, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin coin))
            CoinCollected?.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out GridObject gridObject))
            if(gridObject.Layer == GridLayer.Ground)
                _onGraund = true;
    }
}
