using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    [SerializeField] private GameObject [] highScores;
    public void SetHighScore()
    {
        for (int i = 0; i < highScores.Length; i++)
        {
            var obj = highScores[i].GetComponentsInChildren<Text>();
            if (Database.Get()[i].score == null)
            {
                break;
                return;
            }
            
            obj[0].text = $"{i+1}";
            obj[1].text = $"{Database.Get()[i].name}";
            obj[2].text = $"{Database.Get()[i].score}";
        }
    }

    private void Start()
    {
        //SetHighScore();
        
        print("Size "+Database.Get().Count);
    }
}