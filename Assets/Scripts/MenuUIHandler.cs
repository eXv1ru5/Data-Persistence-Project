using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TextMeshProUGUI bestPlayerAndScoreText;

    private void Start()
    {
        bestPlayerAndScoreText.text = "Best Score: " + PersistenceManager.Instance.bestPlayerName + " : " + PersistenceManager.Instance.bestScore;
    }

    public void StartNew()
    {
        PersistenceManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
