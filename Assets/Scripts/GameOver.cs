using System.Collections;
using System.Collections.Generic;
using Character;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool IsGameOver => (Data.Health <= 0);
}
