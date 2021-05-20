using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenseMoveEvent : MonoBehaviour
{
    public void Awake()
    {
    }

    public void OnClickGoToDungeon()
    {
        GameManager.Instance.ChangeSceneToDungeon(1);
    }

    public void OnClickGoToTitle()
    {
        GameManager.Instance.ChangeSceneToTitle();
    }

    public void OnClickGoToBaseCamp()
    {
        GameManager.Instance.ChangeSceneToBaseCamp();
    }
}
