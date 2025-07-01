using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private Button _newGame;
    [SerializeField] private Button _loadGame;
    [SerializeField] private Button _options;
    [SerializeField] private Button _credits;
    [SerializeField] private Button _exit;
    

    

     public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
