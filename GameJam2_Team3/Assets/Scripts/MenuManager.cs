using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject Main_Menu;
    [SerializeField] GameObject Options_Menu;

    private void Start()
    {
        Options_Menu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("ArtTestScene");
    }

    public void LoadOptionsMenu()
    {
        Options_Menu.SetActive(true);
        Main_Menu.SetActive(false);
    }

    public void LoadMainMenu()
    {
        Options_Menu.SetActive(false);
        Main_Menu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
