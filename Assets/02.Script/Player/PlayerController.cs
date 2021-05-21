using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float playerRunSpeed = 6.0f;
    [SerializeField] private float playerRunRotationSpeed = 10.0f;
    [SerializeField] private Rigidbody playerRigidbody;

    private float inputHorizontalValue = 0;
    private float inputVerticalValue = 0;
    private Vector3 playerMovent = Vector3.zero;

    private void Awake()
    {
        InitializeAwkeStep();
    }

    protected virtual void InitializeAwkeStep()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 物理演算処理が必要ない処理更新
    /// </summary>
    private void Update()
    {
        GetUserMoveKeyInput(); 
        GetUserFKeyInput();
    }

    /// <summary>
    /// ユーザーの移動キー押下情報取得
    /// </summary>
    virtual protected void GetUserMoveKeyInput()
    {
        inputHorizontalValue = Input.GetAxisRaw("Horizontal");
        inputVerticalValue = Input.GetAxisRaw("Vertical");
    }

    /// <summary>
    /// Fキーのイベント
    /// </summary>
    /// <remarks>
    /// Fキーの処理は子クラスでbase以降作成する。
    /// </remarks>
     protected virtual void GetUserFKeyInput() { }

    /// <summary>
    /// 物理演算処理が必要とされる処理更新
    /// </summary>
    private void FixedUpdate()
    {
        RunPlayer();
    }

    /// <summary>
    /// プレイヤーの移動処理
    /// </summary>
    private void RunPlayer()
    {
        Vector3 inputValue = new Vector3(inputHorizontalValue, 0.0f, inputVerticalValue);
        playerMovent = inputValue.normalized * playerRunSpeed * Time.deltaTime;
        if ( playerMovent == Vector3.zero)
        {
            return;
        }

        // 移動
        playerRigidbody.MovePosition( transform.position + playerMovent); 
        
        // 移動方向が正面となる
        Quaternion newRotation = Quaternion.LookRotation(playerMovent);
        playerRigidbody.rotation = Quaternion.Slerp(playerRigidbody.rotation, newRotation, playerRunRotationSpeed * Time.deltaTime);
    }
}
