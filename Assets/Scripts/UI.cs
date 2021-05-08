using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text scoreText;
    public Text nameText;

   void Update()
    {
        scoreText.text = "Score : " + Data.Score;
        nameText.text = "Nama : " + Data.Name;
    }
}
