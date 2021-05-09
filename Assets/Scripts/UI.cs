using PacMan.Character;
using UnityEngine;
using UnityEngine.UI;

public class UI : Singleton<UI>
{
    [Header("Component")]
    [SerializeField] private Text scoreText;
    [SerializeField] private Text nameText;
    [SerializeField] private Text timer;
    
    [SerializeField] private InputField inputName;
    [SerializeField] private Button btn;
    
    [Header("Gameobject")]
    [SerializeField]
    private GameObject panelGameOver;
    
    
    public void ShowUI()
    {
        scoreText.text = "Score : " + Data.Score;
        nameText.text = "Nama : " + Data.Name;
        timer.text = $"{TimeManagement.Instance.Minutes} : {TimeManagement.Instance.Seconds}";
    }

    public void EnterButtonClicked()
    {
        btn.onClick.AddListener(() =>
        {
            TimeManagement.TimeActive();
            Board.Instance.RandomMap();
            Data.Name = inputName.text;
            HiddenUI();
        });
    }

    private void HiddenUI()
    {
        inputName.gameObject.SetActive(false);
        btn.gameObject.SetActive(false);
    }

    public void ShowGameOver()
    {
        panelGameOver.SetActive(GameOver.IsGameOver);
    }
}