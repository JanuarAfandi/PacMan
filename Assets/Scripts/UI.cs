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

    //Method untuk menampilkan data player pada ui
    public void ShowUIPlayer()
    {
        scoreText.text = $"Score :  {Data.Score}";
        nameText.text = $"Name :   {Data.Name}";
        timer.text = $"{TimeManagement.Instance.Minutes} : {TimeManagement.Instance.Seconds}";
        health.text = $"Health : {Data.Health}";
    }

    //method untuk handle input name player
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

    //method untuk hide input name & button player
    private void HiddenUI()
    {
        inputName.gameObject.SetActive(false);
        btn.gameObject.SetActive(false);
    }

    //method untuk menampilkan ui gameover
    public void ShowGameOver()
    {
        if (GameOver.IsGameOver)
        {
            TimeManagement.TimeInActive();
        }

        panelGameOver.SetActive(GameOver.IsGameOver);
    }

    //method untuk melakukan restart dan dipanggil ketika button restart di click
    public void Restart()
    {
        TimeManagement.TimeActive();
        SceneManager.LoadScene("Scenes/Map");
    }

    public void Exit()
    {
        TimeManagement.TimeActive();
        SceneManager.LoadScene("MainMenu");
    }

    //method untuk menampilkan ui gamewin
    public void ShowGameWin()
    {
        if(GameWin.IsWin)
            TimeManagement.TimeInActive();
        panelWin.SetActive(GameWin.IsWin);
    }
}