using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onLoseGame;
    [SerializeField]
    private UnityEvent onWinGame;
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private UnityEvent<int> onUpdateBestScore;
    [SerializeField]
    private SpaceshipManager spaceshipManager;
    [SerializeField]
    private AsteroidManager asteroidManager;   
    private bool gameLost = false;
    private bool allShipsDestroyed = false;
    private bool allAsteroidsDestroyed = false;
    public void LoseGame()
    {   
        onUpdateBestScore?.Invoke(scoreManager.Score);     
        onLoseGame?.Invoke();
        spaceshipManager.StopShips();
        asteroidManager.StopAsteroids();
    }

    private void Start()
    {
        asteroidManager.StartAsteroids();
        spaceshipManager.StartShips();
        scoreManager.InitializeScore();
    }

    public void AllShipsDestroyed()
    {
        allShipsDestroyed = true;
        CheckWinCondition();
    }
    public void AllAsteroidsDestroyed()
    {
        allAsteroidsDestroyed = true;
        CheckWinCondition();
    }

    private void CheckWinCondition()
    {
        if (!gameLost && allShipsDestroyed && allAsteroidsDestroyed)
        {
            onUpdateBestScore?.Invoke(scoreManager.Score);
            onWinGame?.Invoke();
        }
    }
}
