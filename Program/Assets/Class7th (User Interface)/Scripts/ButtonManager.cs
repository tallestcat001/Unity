using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] Text [] ButtonTexts;
    [SerializeField] string[] ButtonNames;

    // Start is called before the first frame update
    void Start()
    {
        ButtonTexts[0].text = "New Game";
        ButtonTexts[1].text = "Continue";
        ButtonTexts[2].text = "Exit";
    }

    public void NewGame()
    {
        Debug.Log("New Game");
    }
    
    public void Continue()
    {
        Debug.Log("Continue");
    }

    public void Exit()
    {
        Debug.Log("Exit");
    }
}
