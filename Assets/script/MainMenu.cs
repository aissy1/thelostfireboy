using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioSource Soundtrack;
    public Button aksesBtn;
    public Button aksesBtn1;

    // Start is called before the first frame update
    void Start()
    {

        //PlayerPrefs.SetInt("Level", 1);
        //PlayerPrefs.SetInt("ReachedLevel", 1);
        //PlayerPrefs.SetInt("StarsCollect", 0);
        Soundtrack.volume = PlayerPrefs.GetFloat("MusicVolume");

        if (PlayerPrefs.GetInt("Level") == 0)
        {
            PlayerPrefs.SetInt("Level", 1);
        }

        if (PlayerPrefs.GetInt("ReachedLevel") <= 1)
        {
            aksesBtn.interactable = false;
        }
        else
        {
            aksesBtn.interactable = true;
        }

        if (PlayerPrefs.GetInt("ReachedLevel") > 1)
        {
            aksesBtn1.GetComponentInChildren<Text>().text = ("New Game").ToString();
        }
    }
    public void LoadIntro()
    {
        SceneManager.LoadScene("Intro");
        PlayerPrefs.SetInt("ReachedLevel", 1);
        PlayerPrefs.SetInt("StarsCollected", 0);
        PlayerPrefs.SetInt("StarsCollect", 0);
        PlayerPrefs.SetInt("Level", 1);
    }

    public void LoadContinue() 
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void LoadSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void LoadQuit()
    {
        Application.Quit();
    }

    public void LoadGuide()
    {
        SceneManager.LoadScene("Guide");
    }
}
