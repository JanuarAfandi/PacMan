using UnityEngine;

//4210191029 - Dimas Rizky A.F

public class Board : Singleton<Board>
{
    public GameObject [] map;

    //method untuk random board berdasarkan array map 
    public void RandomMap()
    {
        var rand = Random.Range(0,3);

        for (var i = 0; i < map.Length; i++)
        {
            map[i].SetActive(i == rand);
        }
    }
}
