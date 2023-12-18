using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    charMove komponenGerak;

    // Start is called before the first frame update
    void Start()
    {
        komponenGerak = GameObject.Find("character").GetComponent<charMove>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(komponenGerak.key == 1)
            {
                komponenGerak.stageClear = true;
                SceneManager.LoadScene("NextLv");
;            }
        }
    }
}
