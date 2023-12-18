using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLevel : MonoBehaviour
{
    public AudioSource Soundtrack;
    Button[] Levelbutons;
    public Text CollectedStars;
    int ReachedLevel;
    int[] starsLevel;

    private void Awake()
    {
        //Rest();
        Soundtrack.volume = PlayerPrefs.GetFloat("MusicVolume");
        int level = PlayerPrefs.GetInt("Level", 1);
        ReachedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);
        
        if(ReachedLevel >= 2)
        {
            ReachedLevel = PlayerPrefs.GetInt("Level");
        }
        Debug.Log(ReachedLevel);
        Debug.Log(level);
        
        Levelbutons = new Button[transform.childCount];
        for(int i = 0; i < Levelbutons.Length;i++)
        {
            Levelbutons[i] = transform.GetChild(i).GetComponent<Button>();
            Levelbutons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
            if(i + 1> ReachedLevel)
            {
                Levelbutons[i].interactable = false;
            }
        }
    }

    public void Stars()
    {
        PlayerPrefs.SetInt("StarsCollected", PlayerPrefs.GetInt("StarsCollect"));
        int starsCollected = PlayerPrefs.GetInt("StarsCollected");
        PlayerPrefs.Save();
        CollectedStars.text = "S t a r s  C o l l e c t e d  :  " + starsCollected;
    }
    public void LoadScene(int Level)
    {
        //Level = PlayerPrefs.GetInt("Level");
        PlayerPrefs.SetInt("CurrentLevel", Level);
        PlayerPrefs.SetInt("Level", Level + 1);
        if (Level >= 6)
        {
            PlayerPrefs.SetInt("Level", 6);
        }
        SceneManager.LoadScene("lv " + Level);
    }

    void Rest()
    {
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.SetInt("ReachedLevel", 1);
        PlayerPrefs.SetInt("StarsCollect", 0);
    }

    public void StarsLevel()
    {
        for (int i = 1; i <= Levelbutons.Length; i++)
        {
            starsLevel[i] = PlayerPrefs.GetInt("StarsCollect");
            Debug.Log(starsLevel[i]);
        }
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("MainMenus");
    }

    public void LoadSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    // Update is called once per frame
    void Update()
    {
        Stars();
    }
}
