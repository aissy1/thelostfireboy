using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide : MonoBehaviour
{
    public AudioSource Soundtrack;

    // Start is called before the first frame update
    void Start()
    {
        Soundtrack.volume = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenus");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
