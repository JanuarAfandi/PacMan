using Character;
using Foods;

public class GameWin : Singleton<GameWin>
{
    //method untuk mengecek jika foodtarget sudah terpenuhi maka player win
    public static bool IsWin => (Data.Score == Factory.Instance.sizeTarget);
}