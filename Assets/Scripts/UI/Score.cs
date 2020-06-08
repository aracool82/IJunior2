using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private Player _player;
    private int _score=0;

    private void Awake()
    {
        ShowScore(_score);
    }

    private void OnEnable()
    {
        _player.CoinCollected += onCollectedCoin;
    }

    private void OnDisable()
    {
        _player.CoinCollected -= onCollectedCoin;
    }

    private void onCollectedCoin()
    {
        _score += 1;
        ShowScore(_score);
    }

    private void ShowScore(int score)
    {
        _scoreText.text = $" Очки: {score.ToString()}";
    }
}
