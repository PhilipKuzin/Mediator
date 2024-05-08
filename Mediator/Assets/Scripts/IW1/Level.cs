using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
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



}
