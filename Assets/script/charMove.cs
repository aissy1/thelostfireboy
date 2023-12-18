using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class charMove : MonoBehaviour
{
    int kecepatan = 5;
    int melompat = 60;
    int nyawa = 1;
    int pindah;
    bool balik;
    public bool isPaused = false;
    public bool stageClear = false;

    public AudioSource Soundtrack;

    public bool tanah;
    public LayerMask targetLayer;
    public Transform deteksiTanah;
    public float jangkauan;
    public int key;
    
    private float timer;

    Vector2 start;

    Rigidbody2D lompat;
    Animator anim;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Periksa jika objek yang menyentuh memiliki tag "Air"
        if (other.CompareTag("water"))
        {
            nyawa--;
            // Panggil metode untuk menangani karakter mati/tewas
            if (nyawa < 1)
            {
                StartCoroutine(HandleCharacterDeath());
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Soundtrack.volume = PlayerPrefs.GetFloat("MusicVolume");
        lompat = GetComponent<Rigidbody2D>();  
        anim = GetComponent<Animator>();
        start = transform.position;
    }

    // Update is called once per frame
    void Update() {

        timer += Time.deltaTime;

        if (stageClear)
        {
            // Simpan nilai timer menggunakan PlayerPrefs
            PlayerPrefs.SetFloat("StageTimer", timer);

            // Pastikan menyimpan perubahan pada PlayerPrefs
            PlayerPrefs.Save();
        }

        if (tanah==true) {
            anim.SetBool("jump", false);
        }
        else
        {
            anim.SetBool("jump", true);
        }

        tanah = Physics2D.OverlapCircle(deteksiTanah.position, jangkauan, targetLayer);

        if (!isPaused)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
                pindah = 1;
                anim.SetBool("move", true);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
                pindah = -1;
                anim.SetBool("move", true);
            }
            else
            {
                anim.SetBool("move", false);
            }
            if (tanah == true && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
            {
                lompat.AddForce(new Vector2(0, melompat));
            }
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            isPaused = true;
            ToggleInGame();
        }

        if (pindah > 0 && balik)
        {
            FlipBody();
        }
        else if (pindah < 0 && !balik)
        {
            FlipBody();
        }
    }
    IEnumerator HandleCharacterDeath()
    {
        yield return new WaitForSeconds(.5f);
        transform.position = start;
    }

    void ToggleInGame()
    {
        if (SceneManager.GetSceneByName("InGameMenus").isLoaded)
        {
            UnloadMenuInGame();
        }
        else
        {
            LoadMenuInGame();
        }
    }

    void FlipBody()
    {
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }
    void LoadMenuInGame()
    {
        SceneManager.LoadScene("InGameMenus", LoadSceneMode.Additive);
    }

    void UnloadMenuInGame()
    {
        SceneManager.UnloadSceneAsync("InGameMenus");
    }
}
