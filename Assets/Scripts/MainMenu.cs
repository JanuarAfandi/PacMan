using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditPanel;
    public GameObject HighscorePanel;
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        HighscorePanel.SetActive(false);
    }

    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("Map");
    }    
    public void CreditButtonClicked()
    {
        MenuPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        CreditPanel.SetActive(true);
    }

    public void HighScoreClicked()
    {
        MenuPanel.SetActive(false);
        HighscorePanel.SetActive(true);
        CreditPanel.SetActive(false);
    }
    
    public void Exit_Clicked()
    {
        Application.Quit();
    }
    public void BackButtonClicked()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        HighscorePanel.SetActive(false);
    }
}
