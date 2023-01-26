using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public GameObject CanvasValidasi;
    public GameObject ButtonOn;
    public GameObject ButtonOff;
    public GameObject BackSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadToScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void validNo(){
        CanvasValidasi.SetActive(false);
    }

    public void SoundOff(){
        ButtonOn.SetActive(false);
        ButtonOff.SetActive(true);
        BackSound.SetActive(true);
    }

    public void SoundOn(){
        ButtonOn.SetActive(true);
        ButtonOff.SetActive(false);
        BackSound.SetActive(false);
    }
}
