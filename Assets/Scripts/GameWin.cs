using Character;
using Foods;

public class GameWin : Singleton<GameWin>
{
    //4210191018 - M.Dwi Febrian
    
    //method untuk mengecek jika foodtarget sudah terpenuhi maka player win
    public static bool IsWin => (Data.Score == FoodFactory.Instance.sizeTarget);
}