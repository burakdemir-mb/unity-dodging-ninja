using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kodlar : MonoBehaviour
{
    public GameObject menu;
    public GameObject kazan;
    public GameObject resume;
    private Text info;
    public Button basla;
    public GameObject kaybettin;
    float maxDeger = 60;
    float minDeger = 0;
    public GameObject kazandin;

    private void Awake()
    {
        info= GameObject.FindWithTag("info").GetComponent<Text>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            menu.SetActive(true);
            Time.timeScale= 0;
            resume.SetActive(true);
        }
        
        if (maxDeger>=minDeger)
        {
            maxDeger = maxDeger - 1*Time.deltaTime;
            win();
        }
        info.text= ((int)maxDeger).ToString();
    }

    public void win()
    {
        if (maxDeger <= 0)
        {
            Time.timeScale= 0;
            kaybettin.SetActive(false);
            menu.SetActive(true);
            kazandin.SetActive(true);
            resume.SetActive(false);

        }
    }
    public void stp_button()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
        kaybettin.SetActive(false);
        kazandin.SetActive(false);
    }
    public void restart_button()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Time.timeScale = 1;
        menu.SetActive(false);
        kaybettin.SetActive(false);
        kazandin.SetActive(false);

    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
    public void resume_button()
    {
        menu.SetActive(false);
        Time.timeScale = 1;

        kaybettin.SetActive(false);
        kazandin.SetActive(false);
    }
    

}
