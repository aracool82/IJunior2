using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public event UnityAction CollectedCoin;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            DestroyCoin();
            CollectedCoin?.Invoke();
        }
    }

    private void DestroyCoin()
    {
        Destroy(gameObject);
    }
}
