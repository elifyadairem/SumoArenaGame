using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuManager : MonoBehaviour
{
    
    public void StartGame()
    {
        
        SceneManager.LoadScene(1);
    }


    public void QuitGame()
    {
        Debug.Log("Oyundan Çýkýlýyor...");

        Application.Quit();

 
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }


    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}