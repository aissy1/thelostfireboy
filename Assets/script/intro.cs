using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class intro : MonoBehaviour
{
    public AudioSource Soundtrack;
    public Text dialog;
    private string[] isiDialog;
    private float speed = 20f;
    private float delaySpeed = 1.5f; 
    // Start is called before the first frame update
    void Start()
    {
        Soundtrack.volume = PlayerPrefs.GetFloat("MusicVolume");

        isiDialog = new string[]
        {
            "Dahulu kala di sebuah kerajaan bernama kahuripan terdapat permaisuri yang sedang mengandung calon putra mahkota dan mengidap penyakit langka. ",
            "Raja mengutus jenderalnya untuk mengundang semua tabib tepercaya untuk datang ke kerajaan dan mengobati sang permaisuri. ",
            "Keesokan harinya datanglah tabib dari pulau seberang yang ingin mencoba mengobati ratu dan tidak lama ratu sembuh dari penyakitnya. ",
            "Ketika pangeran putra mahkota telah beranjak dewasa, ia dijuluki dengan nama FireBoy karena kekuatan ajaib yang dimilki. ",
            "Raja hendak menjodohkan pangeran dengan salah satu putri raja William dari kerajaan Daha yang bernama Putri  Ella. ",
            "Rencana pertunangan itu membuat saudara kembar putri Ella iri dan cemburu yaitu putri Elli. ",
            "Putri Elli pun meminta bantuan kepada nenek sihir untuk mengubah saudaranya menjadi seekor hewan dan mengambil kekuatan milik pangeran. ",
            "Permintaan Putri Elli itu dituruti oleh nenek sihir dan membawa putri Ella ke tempat persembunyian. ",
            "Sementara itu, sang pangeran menyadari bahwa Putri Ella menghilang dan kekuatan api yang dimilikinya juga menghilang. ",
            "Ia pun segera melakukan pencarian dengan menyamar sebagai rakyat biasa. ",
        };

        StartCoroutine(ShowProlog());
    }

    IEnumerator ShowProlog()
    {
        foreach (string line in isiDialog)
        {
            dialog.text = ""; // Reset teks

            // Animasi muncul dan bergerak dari bawah ke atas
            for (int i = 0; i < line.Length; i++)
            {
                dialog.text += line[i];
                yield return new WaitForSeconds(1 / speed);
            }
            yield return new WaitForSeconds(delaySpeed);
        }
    }

    public void SkipBtn()
    {
        StopAllCoroutines();
        SceneManager.LoadScene("MenuLevel");
    }
}
