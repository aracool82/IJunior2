using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public event UnityAction CollectedCoin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
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
