using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public AudioSource hype;
    public static bool GameIsPaused = false;
    public static bool Restartgame = false;
    public static bool PauseAn = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKeyDown(KeyCode.Escape)|PauseAn)
        {
            PauseAn = false;
            if (!GameOver.GameIsPaused) { 

            if (GameIsPaused)
            {
                    
                Resume();
                
            }
            else
            {
                   
                    
                Pause();
            }
            

        }
           
        }

        if (GameOver.pause)
        {


            hype.Pause();

          

        }

        if (GameOver.Restartgame1)
        {
           
            hype.Play();
            GameOver.Restartgame1 = false;
        }

    }
    public void Resume()
    {

        
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        hype.Play();
            
        

    }
    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    } public void PauseAnn()
    {
        PauseAn = true;
    }
    public void Restart()
    {
        Restartgame = true;
        Resume();

    }
        void Pause()
    {
        hype.Pause();
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        

    }
}
