using Character;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//class yang digunakan untuk menghandle ui
public class UI : Singleton<UI>
{
    [Header(Constant.Component)] [SerializeField]
    private Text scoreText;

    [SerializeField] private Text nameText;
    [SerializeField] private Text timer;
    [SerializeField] private Text health;

    [SerializeField] private InputField inputName;
    [SerializeField] private Button btn;

    [Header(Constant.GameObject)] [SerializeField]
    private GameObject panelGameOver;

    [SerializeField] private GameObject panelWin;

    public void ShowUI()
    {
        scoreText.text = $"Score :  {Data.Score}";
        nameText.text = $"Name :   {Data.Name}";
        timer.text = $"{TimeManagement.Instance.Minutes} : {TimeManagement.Instance.Seconds}";
        health.text = $"Health : {Data.Health}";
    }

    public void EnterButtonClicked()
    {
        btn.onClick.AddListener(() =>
        {
            TimeManagement.Instance.timer = 300;
            TimeManagement.TimeActive();
            TimeManagement.Instance.SetTimer();
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
        if (GameOver.IsGameOver)
        {
            TimeManagement.TimeInActive();
        }

        panelGameOver.SetActive(GameOver.IsGameOver);
    }

    public void Restart()
    {
        TimeManagement.TimeActive();
        SceneManager.LoadScene("Scenes/Map");
    }

    public void ShowGameWin()
    {
        if(GameWin.IsWin)
            TimeManagement.TimeInActive();
        panelWin.SetActive(GameWin.IsWin);
    }
}