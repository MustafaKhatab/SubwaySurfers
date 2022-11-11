using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI;
    public static bool GameIsPaused = false;
    [SerializeField] TextMeshProUGUI m_Object;
    public static bool Restartgame = false;
    public static bool Restartgame1 = false;
    public bool flag = true;
    public static bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        m_Object.text = "SCORE : ";
    }

    // Update is called once per frame
    void Update()
    {
        if (pause)
        {
            Pause();
            pause = false;
        }
        if (!PauseMenu.GameIsPaused) {
            if (generate.health <= 0 && flag)
            {
                flag = false;
                m_Object.text = "SCORE : " + generate.score;
                pause = true;
            }
            
        }
        
       
    }
    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Restart()
    {
        Restartgame = true;
        Restartgame1 = true;
        flag = true;
        Resume();

    }
    public void Resume()
    {

        GameOverUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        
    }
        void Pause()
    {
        
        
        Time.timeScale = 0f;
        GameIsPaused = true;
        GameOverUI.SetActive(true);

    }
}
