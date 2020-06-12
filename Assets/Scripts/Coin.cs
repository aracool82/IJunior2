using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
            DestroyCoin();
    }

    private void DestroyCoin()
    {
        Destroy(gameObject);
    }
}
