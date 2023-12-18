using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public Sprite Windows_32Sprite;
    private SpriteRenderer spriteRenderer3;
    private SpriteRenderer spriteRenderer2;
    private SpriteRenderer spriteRenderer1;
    public Text timerText;
    public int star = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (timerText == null)
        {
            Debug.LogError("timerText is null in Start method.");
        }

        float timerValue = PlayerPrefs.GetFloat("StageTimer", 0f);
        string minutes = Mathf.Floor(timerValue / 60).ToString("00");
        string seconds = (timerValue % 60).ToString("00");

        if (timerText != null)
        {
            timerText.text = "Waktu: " + minutes + ":" + seconds;
        }
        else
        {
            Debug.LogError("timerText is null when trying to set text.");
        }
        if (timerValue <= 30.0)
        {
            star += 3;
            spriteRenderer3 = GameObject.Find("star3").GetComponent<SpriteRenderer>();
            spriteRenderer2 = GameObject.Find("star2").GetComponent<SpriteRenderer>();
            spriteRenderer1 = GameObject.Find("star1").GetComponent<SpriteRenderer>();
            // Inisialisasi sprite 
            spriteRenderer3.sprite = Windows_32Sprite;
            spriteRenderer2.sprite = Windows_32Sprite;
            spriteRenderer1.sprite = Windows_32Sprite;

            PlayerPrefs.SetInt("StarsCollect", PlayerPrefs.GetInt("StarsCollected") + star);
        }
        else if (timerValue <= 50.0)
        {
            star += 2;
            spriteRenderer2 = GameObject.Find("star2").GetComponent<SpriteRenderer>();
            spriteRenderer1 = GameObject.Find("star1").GetComponent<SpriteRenderer>();
            // Inisialisasi sprite 
            spriteRenderer2.sprite = Windows_32Sprite;
            spriteRenderer1.sprite = Windows_32Sprite;

            PlayerPrefs.SetInt("StarsCollect",PlayerPrefs.GetInt("StarsCollected") + star);
        }
        else
        {
            star += 1;
            spriteRenderer1 = GameObject.Find("star1").GetComponent<SpriteRenderer>();
            // Inisialisasi sprite 
            spriteRenderer1.sprite = Windows_32Sprite;

            PlayerPrefs.SetInt("StarsCollect", PlayerPrefs.GetInt("StarsCollected") + star);
        }
        PlayerPrefs.Save();
    }

    public void NextLvl()
    {
        if(PlayerPrefs.GetInt("CurrentLevel") == PlayerPrefs.GetInt("ReachedLevel"))
        {
            PlayerPrefs.SetInt("ReachedLevel", PlayerPrefs.GetInt("ReachedLevel") + 1);
        }
        Debug.Log(PlayerPrefs.GetInt("StarsCollect"));
        Debug.Log(star);
        Debug.Log(PlayerPrefs.GetInt("ReachedLevel"));
        PlayerPrefs.GetInt("StarsCollect");
        PlayerPrefs.Save();
        SceneManager.LoadScene("MenuLevel");
    }
}
