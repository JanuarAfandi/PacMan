using UnityEngine;

//abstract class singleton digunakan sebagai parent class untuk mengimplementasikan singleton pada class turunannya
public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
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