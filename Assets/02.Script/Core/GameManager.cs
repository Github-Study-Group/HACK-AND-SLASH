using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //シングルトーン
    private static GameManager instance = null;

    private string senceNameTitleUI;
    private string senceNameBaseCampGame;
    private string senceNamePlayGame;

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
        senceNameTitleUI = "01.Scenes/TitleScenes";
        
        // BaseCamp
        senceNameBaseCampGame = "01.Scenes/BaseCampScenes";

        // Play - Stge List
        senceNamePlayGame = "01.Scenes/DungeonStage01";
         
    }

    public void ChangeSceneToBaseCamp()
    {
        Debug.Log("Send Scene : " + senceNameBaseCampGame);
        SceneManager.LoadScene(senceNameBaseCampGame);
    }

    public void ChangeSceneToDungeon(int stage)
    {
        Debug.Log("Send Scene : " + senceNamePlayGame);
        SceneManager.LoadScene(senceNamePlayGame);
    }

    public void ChangeSceneToTitle()
    {
        Debug.Log("Send Scene : " + senceNameTitleUI);
        SceneManager.LoadScene(senceNameTitleUI);
    }
}
