using System;
using UnityEngine;
using Zenject;

public class Level : ITickable
{
    public event Action Defeat;
    public void Start()
    {
        // ������ ������
        Debug.Log("Level Started");
    }

    public void Restart()
    {
        // ������� ������ 
        Start();
    }

    public void OnDefeat()
    {
        Defeat?.Invoke();
        // ������ ��������� ����
        // ����� ������ ��������� 
    }

    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnDefeat();
        }
    }
}
