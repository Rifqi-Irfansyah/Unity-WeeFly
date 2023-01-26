using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public GameObject ButtonRetry;
    public GameObject CanvasAbout;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveAbout(){
        CanvasAbout.SetActive(true);
    }

    public void unActiveAbout(){
        CanvasAbout.SetActive(false);
    }

    public void ResetTheGame(){
        ButtonRetry.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
