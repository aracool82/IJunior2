using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Coin[] _coins;
    private int _score=0;
   

    private void Awake()
    {
        ShowScore(_score);
        _coins = FindObjectsOfType<Coin>();
        foreach (var coin in _coins)
            coin.CollectedCoin += onCollectedCoin;

    }

    private void OnDisable()
    {
        foreach (var coin in _coins)
            coin.CollectedCoin -= onCollectedCoin;
    }

    private void onCollectedCoin()
    {
        _score += 1;
        ShowScore(_score);
    }

    private void ShowScore(int score)
    {
        _scoreText.text = score.ToString();
    }
}
