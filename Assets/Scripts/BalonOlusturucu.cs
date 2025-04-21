using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 1f;
    float zamanSayacý=0f;
    OyunKontrolcu okScripti;
    // Start is called before the first frame update
    void Start()
    {
        okScripti = GameObject.Find("OyunKontrolcu").GetComponent<OyunKontrolcu>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayacý -= Time.deltaTime;
        int katsayi = (int)(okScripti.zamanSayaci/10) - 6; 
        katsayi *= -1;
        if(zamanSayacý < 0 && okScripti.zamanSayaci>0)
        {
            GameObject go = Instantiate(balon,new Vector3 (Random.Range(-2f,2.2f),-6f,0),Quaternion.Euler(0,0,0));
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f*katsayi,80f*katsayi), 0));
            zamanSayacý = balonOlusturmaSuresi;
        }
    }
}
