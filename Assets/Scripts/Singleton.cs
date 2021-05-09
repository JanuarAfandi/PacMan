using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _singleton;

    public static T Instance
    {
        get
        {
            if (_singleton == null)
            {
                _singleton = FindObjectOfType<T>();
            }

            return _singleton;
        }
    }
}