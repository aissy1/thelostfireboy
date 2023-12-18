using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    charMove komponenGerak;

    void Start()
    {
        komponenGerak = GameObject.Find("character").GetComponent<charMove>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
            komponenGerak.key++;
            Destroy(gameObject);
        }
    }
}
