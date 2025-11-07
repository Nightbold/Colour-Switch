using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumOlusturucu : MonoBehaviour
{
    public GameObject[] objeler;
    public GameObject bayrak,renkD,yildiz;
    public int objeSayisi;
    public float objeMesafesi;
    void Start()
    {
            Vector2 pozisyon1= new Vector2(0,0); // yildiz ve çemberin ilk konumu 
            Vector2 pozisyon2= new Vector2(0,3.5f); // renk değiştirici ilk onumu


            
            for (int i = 0; i < objeSayisi; i++)
            { 
                int objeKodu= Random.Range(0,objeler.Length);
                Instantiate(objeler[objeKodu],pozisyon1,Quaternion.identity);
                Instantiate(yildiz,pozisyon1,Quaternion.identity);
                Instantiate(renkD,pozisyon2,Quaternion.identity);

                pozisyon1.y+=objeMesafesi;
                pozisyon2.y+=objeMesafesi;
            }

               Instantiate(bayrak,new Vector2(0,pozisyon1.y +=1),Quaternion.identity);
    }

    
}
