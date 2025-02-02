using UnityEngine;

public class mainMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject howToPlay;
    public GameObject credits;
    public GameObject settings;


    void Start()
    {

        mainMenu.SetActive(true);
        howToPlay.SetActive(false);
        credits.SetActive(false);
        settings.SetActive(false);

    }

    public void SettingsBtnClicked()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void HowToPlayBtnClicked()
    {
        mainMenu.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void CreditsBtnClicked()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }


    public void BackBtnClicked()
    {
        mainMenu.SetActive(true);
        howToPlay.SetActive(false);
        credits.SetActive(false);
        settings.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void PlayBtnClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }


}
