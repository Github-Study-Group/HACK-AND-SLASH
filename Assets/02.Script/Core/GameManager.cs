using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //シングルトーン
    private static GameManager instance = null;

    [SerializeField] private string senceNameTitleUI;
    [SerializeField] private string senceNameBaseCampGame;
    [SerializeField] private string senceNamePlayGame;

    private enum SenceChange
    {
        Title,
        BaseCamp,
        Play,
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    private void Start()
    {
        // Title
        senceNameTitleUI = "Title Scenes";
        
        // BaseCamp
        senceNameBaseCampGame = "BaseCamp Scenes";

        // Play - Stge List
        senceNamePlayGame = "Dungeon Stage01";
         
    }

    public void ChangeSceneToBaseCamp()
    {
        SceneManager.LoadScene(senceNameBaseCampGame);
    }

    public void ChangeSceneToDungeon(int stage)
    {
        SceneManager.LoadScene(senceNamePlayGame);
    }

    public void ChangeSceneToTitle()
    {
        SceneManager.LoadScene(senceNameTitleUI);
    }
}
