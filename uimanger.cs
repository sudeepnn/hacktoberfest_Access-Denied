using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class uimanger : MonoBehaviour
{
    public GameObject quitpanel;
    public AudioMixer mixer;

    public void volumechanged(float slidervalue)
    {
        mixer.SetFloat("mixer", slidervalue);
    }
    public void play()
    {
        int currentBuildindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentBuildindex + 1);
    }
    public void yes()
    {
        Application.Quit();
    }
    
    
    public Slider volumeslider;
    public Dropdown quality;
   

    private void Start()
    {
        Updatevolumeslide(); 
    }

    void Updatevolumeslide()
    {
       
    }
}
