using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject Main_Menu;
    [SerializeField] GameObject Options_Menu;
    [SerializeField] GameObject IntroVid_Menu;
    [SerializeField] VideoPlayer Video;
    [SerializeField] GameObject MainMenuBKGVid;

    private void Start()
    {
        Options_Menu.SetActive(false);
        IntroVid_Menu.SetActive(false);
        Video.Prepare();
    }

    public void PlayGame()
    {
        MainMenuBKGVid.SetActive(false);

        LoadIntroVidMenu();

        Cursor.visible = false;
        Video.Play();

        Invoke("VideoEnd", 32.0f);
    }

    void VideoEnd()
    {
        Cursor.visible = true;
        SceneManager.LoadScene(1);
    }

    public void LoadOptionsMenu()
    {
        Options_Menu.SetActive(true);
        Main_Menu.SetActive(false);
        IntroVid_Menu.SetActive(false);
    }

    public void LoadMainMenu()
    {
        Options_Menu.SetActive(false);
        Main_Menu.SetActive(true);
        IntroVid_Menu.SetActive(false);
    }

    private void LoadIntroVidMenu()
    {
        Options_Menu.SetActive(false);
        Main_Menu.SetActive(false);
        IntroVid_Menu.SetActive(true);


    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
