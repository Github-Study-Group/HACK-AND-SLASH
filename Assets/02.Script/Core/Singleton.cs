using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シングルトン
/// </summary>
/// <typeparam name="T"></typeparam>
/// <remarks>シングルトンとして使いたい場合はこのクラスを継承する</remarks>
public abstract class Singleton<T>
{
    /// <summary>
    /// インスタンス
    /// </summary>
    private static T instance;

    /// <summary>
    /// インスタンス
    /// </summary>
    public static T Instance
    {
        get
        {
            if (null == instance)
            {
                instance = default;
            }
            return instance;
        }
    }
}