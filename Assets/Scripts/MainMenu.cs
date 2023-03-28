using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource sfxPlayer;
    //[SerializeField] GameObject difficultyPanel;

	void Start()
	{
		sfxPlayer = GetComponent<AudioSource>();
        //difficultyPanel.SetActive(false);
	}

    public void PlayGame ()
    {
        SceneManager.LoadScene("Game"); //This should be deleted if difficulty options is succesfully added
        //difficultyPanel.SetActive(true);
        //Time.timeScale = 0f;
    }

    /*public void Easy()
    {
        SceneManager.LoadScene("EasyGame");
    }

    public void Normal()
    {
        SceneManager.LoadScene("NormalGame");

    }

    public void Hard()
    {
        SceneManager.LoadScene("EasyGame");
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        difficultyPanel.SetActive(false);
    }
    */
    
	public void Credits ()
    {
       SceneManager.LoadScene("Credits");
    }

	public void HowToPlay ()
    {
       SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
