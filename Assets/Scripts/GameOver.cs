using System.Collections;
using System.Collections.Generic;
using Character;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    //method untuk mengecek jika health <= 0 maka gameover
    public static bool IsGameOver => (Data.Health <= 0);
}
