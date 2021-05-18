using UnityEngine;
using UnityEngine.SceneManagement;

//4210191029 - Dimas Rizky A.F 
public class MainMenu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditPanel;
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
    }

    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("Map");
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
