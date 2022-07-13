using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    

    public static bool gameIsPaused = false;

    public GameObject pauseMenuUi;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (gameIsPaused)
            {
                Resume();

            }else{
                Pause();
            }
        }
    }
    public void Resume() 
    {
        FirstPersonController.playerCanMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        FirstPersonController.lockCursor = true;
        pauseMenuUi.SetActive(false); 
        FirstPersonController.cameraCanMove = true;
        gameIsPaused = false;
    }
    public void Pause () 
    {
        FirstPersonController.playerCanMove = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        FirstPersonController.lockCursor = false;
        pauseMenuUi.SetActive(true);
        FirstPersonController.cameraCanMove = false;        
        gameIsPaused = true;
    }
    public void LoadMenu()
    {
        Debug.Log("LoadingMenu...");
        SceneManager.LoadScene("Menu");
        Resume();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Quit()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
