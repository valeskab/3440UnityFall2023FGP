using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedVisualBehaviour : MonoBehaviour
{
    [SerializeField] private ClearCounterBehaviour clearCounter;
    [SerializeField] private GameObject visualGameObject;
    private void Start()
    {
        PlayerControllerBehaviour.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender,
        PlayerControllerBehaviour.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == clearCounter)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        visualGameObject.SetActive(true);
    }

    private void Hide()
    {
        visualGameObject.SetActive(false);
    }
}
