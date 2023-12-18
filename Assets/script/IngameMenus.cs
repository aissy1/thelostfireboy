using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IngameMenus : MonoBehaviour
{
   
    public Text stageText;
    charMove KomponenControl;
  
    // Start is called before the first frame update
    void Start()
    {
        KomponenControl = GameObject.Find("character").GetComponent<charMove>();
        StageText();    
    }

    void StageText()
    {
        stageText.text = PlayerPrefs.GetInt("CurrentLevel").ToString();
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void NextBtn()
    {
        KomponenControl.isPaused = false;
        SceneManager.UnloadSceneAsync("InGameMenus");
    }
}
