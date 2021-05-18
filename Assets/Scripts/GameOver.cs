using Character;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    //4210191018 - M.Dwi Febrian
    
    //method untuk mengecek jika health <= 0 maka gameover
    public static bool IsGameOver => (Data.Health <= 0);
}
