using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public AudioSource Soundtrack;
    public Transform LoadingBar;

    [SerializeField]
    private float value;
    [SerializeField]
    private float Kecepatan;

    private void Update()
    {
        if (value < 100) 
        {
            value += Kecepatan * Time.deltaTime;
            Debug.Log((int)value);
        }else
        {
            SceneManager.LoadScene("MainMenus");
        }
        LoadingBar.GetComponent<Image>().fillAmount = value / 100;
    }
}
