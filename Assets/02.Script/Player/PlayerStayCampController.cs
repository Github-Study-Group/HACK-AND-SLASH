using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStayCampController : PlayerController
{
    private bool isStageSelecterTouch;

    protected override void InitializeAwkeStep()
    {
        base.InitializeAwkeStep();

        // 子で必要な初期化を行う。
        isStageSelecterTouch = false;
    }

    protected override void GetUserFKeyInput()
    {
        if (!(Input.GetKeyUp(KeyCode.F)))
        {
            return;
        }

        // 処理条件


        // 処理内容

    }


    private void OnTriggerEnter(Collider other)
    {
        
    }
}
