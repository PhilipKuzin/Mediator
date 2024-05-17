using System;
using UnityEngine;
using Zenject;

public class Level : ITickable
{
    public event Action Defeat;
    public void Start()
    {
        // логика старта
        Debug.Log("Level Started");
    }

    public void Restart()
    {
        // очистка уровня 
        Start();
    }

    public void OnDefeat()
    {
        Defeat?.Invoke();
        // логика остановки игры
        // показ панели поражения 
    }

    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnDefeat();
        }
    }
}
