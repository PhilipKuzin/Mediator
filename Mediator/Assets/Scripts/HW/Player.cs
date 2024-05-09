using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action Dead;
    public event Action OnHealthChanged;
    public event Action OnLevelChanged;
    public event Action OnPlayerReborn;

    public int MaxHealth => 10;
    public int StartLevel => 0;

    private int _currentHealth;
    public int CurrentHealth
    {
        get { return _currentHealth; }
        private set { _currentHealth = value; }
    }

    private int _currentLevel;
    public int CurrentLevel
    {
        get { return _currentLevel; }
        private set { _currentLevel = value; }
    }

    private void Start()
    {
        Reborn();
    }

    private void Update()
    {
        CheckDeath();
    }

    public void Reborn()
    {
        CurrentHealth = MaxHealth;
        CurrentLevel = StartLevel;
        OnPlayerReborn?.Invoke();
    }

    public void IncreaseHealth()
    {
        CurrentHealth++;
        OnHealthChanged?.Invoke();
    }

    public void ReduceHealth()
    {
        CurrentHealth--;
        OnHealthChanged?.Invoke();
    }

    public void IncreaseLevel()
    {
        CurrentLevel++;
        OnLevelChanged?.Invoke();
    }

    public void ReduceLevel()
    {
        CurrentLevel--;
        OnLevelChanged?.Invoke();
    }

    private void CheckDeath()
    {
        if (_currentHealth <= 0)
        {
            Dead?.Invoke();
        }
    }




}
