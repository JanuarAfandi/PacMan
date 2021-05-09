using System.Collections;
using System.Collections.Generic;
using PacMan.Character;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool IsGameOver => (Data.Health <= 0) ? true : false;
}
