using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OyunKontrolcu : MonoBehaviour
{
    public TMP_Text zamanText;
    public TMP_Text balonText;
    public float zamanSayaci;
    int patlayanBalon = 0;
    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        balonText.text = "Balon: " + patlayanBalon;
    }

    // Update is called once per frame
    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Süre: " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
    }
    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Balon: " + patlayanBalon;
    }
}
