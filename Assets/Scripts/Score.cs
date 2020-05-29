using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private Coin[] _coins;
    private int _score=0;

    private void Awake()
    {
        ShowScore(_score);
        _coins = FindObjectsOfType<Coin>();
        if (_coins.Length != 0) 
        {
            foreach (var coin in _coins)
                coin.CollectedCoin += onCollectedCoin;
        }
        else
            Debug.Log("Ни одного Coin не найдено, учет набраых очков не будет вестись.");
    }

    private void OnDisable()
    {
        if(_coins != null)
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
        _scoreText.text = $" Очки: {score.ToString()}";
    }
}
