using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditPanel;
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
    }

    public void playButtonClicked()
    {
        SceneManager.LoadScene("Map1");
    }    
    public void CreditButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(true);
    }
    public void Exit_Clicked()
    {
        Application.Quit();
    }
    public void BackButtonClicked()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
    }
}
