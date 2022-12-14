using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public InputField PlayerName;
    public Text BestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        MainManager.LoadBestScore();
        BestScoreText.text = $"Best score: {MainManager.BestScorePlayerName}: {MainManager.BestScore}";
        Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        //Debug.Log(PlayerName.text);
        
        SceneManager.LoadScene(1);
        MainManager.PlayerName = PlayerName.text;



    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
