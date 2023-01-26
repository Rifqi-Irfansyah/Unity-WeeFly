using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
   Rigidbody2D Rb;
    public float jumpForce;
    public Text scoreTxt;
    public Text scoreAkhirTxt;
    public GameObject CanvasKalah;
    public GameObject CanvasSkor;
    public GameObject CanvasPipa;
    public GameObject AudioPoint;
    public GameObject Ledakan;
    public GameObject Player;

    float score;
    

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score;
        scoreAkhirTxt.text = score + " points";

        if((Input.GetMouseButtonDown(0)) || (Input.GetKey(KeyCode.Space))){
            //loncat 
            Rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        //jika berhasil melewati pipa
        if(collision.gameObject.tag=="point"){
            score ++;
            AudioPoint.SetActive(true);
        }

        //jika menyentuh pipa 
        else if(collision.gameObject.tag=="pipa"){
            // Destroy(gameObject);
            Player.SetActive(false);
            Ledakan.SetActive(true);
            CanvasKalah.SetActive(true);
            CanvasSkor.SetActive(false);
            CanvasPipa.SetActive(false);
        }

        else{
            AudioPoint.SetActive(false);
        }
    }
}