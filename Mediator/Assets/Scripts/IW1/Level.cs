using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
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



}
