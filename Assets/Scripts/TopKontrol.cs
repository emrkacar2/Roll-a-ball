using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public int hiz;
    public Rigidbody fizik;
    public int puan;
    public int objesayisi;

    public Text puanText;
    public Text oyunbittiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // transform.Translate(0, 0, 0.01f);
        // transform.Rotate(0, 0, 0.1f);
        //if (Input.GetKeyDown(KeyCode.Escape))

        //{

        //    Debug.Log("ESC tuşuna basıldı ! ");
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    Debug.Log("E tuşuna basıldı!");

        //}
       float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vektor = new Vector3(yatay,0,dikey);
        fizik.AddForce(vektor*hiz);



        //Debug.Log("yatay = " + yatay);
        //Debug.Log("dikey = " + dikey);






    }
     void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;
        //Debug.Log("puan = " + puan);
        puanText.text = "Puan: " + puan;
        if (objesayisi == puan)
        {
            oyunbittiText.gameObject.SetActive(true);
        }

    }
}
