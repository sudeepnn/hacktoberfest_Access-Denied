using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject CompleteCanvas;
    private GameObject player;
    [Header("score artibute")]
    public Text score_TXT;
    private int stratingscorevalue = 0;
    private int currentzaxis = 0;
    private int lastSceneBuildIndex = 4;
    private void Start()
    {
        Time.timeScale = 1f;
        player = GameObject.FindGameObjectWithTag("Player");
        score_TXT.text = "0";
        stratingscorevalue = (int)player.transform.position.z;
    }
    private void Update()
    {
        if (player.activeInHierarchy == false)
	{
            restartscene();
	}
        scoreupdate();
    }

    private void scoreupdate()
    {
        currentzaxis = (int)player.transform.position.z;
        score_TXT.text = (currentzaxis - stratingscorevalue).ToString();
    }

    private void restartscene()
    {
        int currentBuildindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentBuildindex);
    }
    public void completescene()
    {
        int currentBuildindex = SceneManager.GetActiveScene().buildIndex;
        if (currentBuildindex == lastSceneBuildIndex)
        {
            
           CompleteCanvas.SetActive(true);
            Time.timeScale = 0f;
            return;
        }
        SceneManager.LoadScene(currentBuildindex + 1);

    }

    
}


 

