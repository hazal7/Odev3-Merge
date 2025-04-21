using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrolcu oyunKontrolScripti;

    private void Start()
    {
        oyunKontrolScripti = GameObject.Find("OyunKontrolcu").GetComponent<OyunKontrolcu>();
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(patlama,transform.position,transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        oyunKontrolScripti.BalonEkle();
       


    }
}
