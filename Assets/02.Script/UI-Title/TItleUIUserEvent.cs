using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TItleUIUserEvent : MonoBehaviour
{
    [SerializeField] private TitleUIController UIControll;

    private void Awake()
    {

    }

    public void OnClickGoToBaseCamp()
    {
        GameManager.Instance.ChangeSceneToBaseCamp();
    }
}
