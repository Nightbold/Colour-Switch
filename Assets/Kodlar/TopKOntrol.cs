using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TopKOntrol : MonoBehaviour
{
    Rigidbody2D top;
    public float power;
    private SpriteRenderer topsr;
    private int skor;
    public TMP_Text skorYazisi;
    public Color[] renkler ; // Bu diziye bazı renkler eklemeyi unutmayın

    void Start()
    {
        top = GetComponent<Rigidbody2D>();
        topsr = GetComponent<SpriteRenderer>(); // topRenk'i başlatıyoruz
        renkDegistir();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            top.velocity = Vector2.up * power;
        }
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Kenar" && temas.GetComponent<KenarRenk>().renk != topsr.color) // temas edilen nesne etiketi kenar ise ve rengi toptan farklıysa 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (temas.CompareTag("RenkDegis"))
        {
            renkDegistir();
            Destroy(temas.gameObject);
        }
        if (temas.CompareTag("Pua"))
        {   
            skor +=Random.Range(3,6);
            skorYazisi.text="skor: "+skor.ToString();
            Destroy(temas.gameObject);
        }
        if (temas.CompareTag("Bayrak"))
        {
            int level = SceneManager.GetActiveScene().buildIndex; // aktif sahneyi alıyoruz
            level++; // sonraki sahne için arrtıryoruz
            SceneManager.LoadScene(level); // sonraki sahneyi yükleme

        }
    }

    void renkDegistir()
    {
        int rastgele = Random.Range(0, renkler.Length);
        topsr.color = renkler[rastgele]; // Rastgele bir renk seçip topRenk'e atıyoruz
    }
}
