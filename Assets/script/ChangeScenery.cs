using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenery : MonoBehaviour
{
    
    public GameObject Default;
    public GameObject Ground;
    public GameObject PlayDefault;
    public GameObject PlayGround;
    public GameObject btnDefault;
    public GameObject btnGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToGround(){
        Default.SetActive(false);
        Ground.SetActive(true);
        PlayDefault.SetActive(false);
        PlayGround.SetActive(true);
        btnDefault.SetActive(false);
        btnGround.SetActive(true);
    }

    public void ChangeToDefault(){  
        Default.SetActive(true);
        Ground.SetActive(false);
        PlayDefault.SetActive(true);
        PlayGround.SetActive(false);
        btnDefault.SetActive(true);
        btnGround.SetActive(false);
    }
}
