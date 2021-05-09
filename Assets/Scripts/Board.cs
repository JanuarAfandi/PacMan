using UnityEngine;

public class Board : Singleton<Board>
{
    private static Board _board;
    public GameObject [] map;

    public void RandomMap()
    {
        var rand = Random.Range(0,3);

        for (var i = 0; i < map.Length; i++)
        {
            map[i].SetActive(i == rand);
        }
    }
}
