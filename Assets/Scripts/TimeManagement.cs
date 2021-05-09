using UnityEngine;

public class TimeManagement : Singleton<TimeManagement>
{
    [SerializeField] private float timer;
    
    [HideInInspector] public float Minutes { get; private set; }

    [HideInInspector] public float Seconds { get; private set; }
    
    // ReSharper restore Unity.ExpensiveCode
    public static void TimeActive()
    {
        Time.timeScale = 1f;
    }

    public static void TimeInActive()
    {
        Time.timeScale = 0f;
    }

    public void SetTimer()
    {
        timer -= Time.unscaledDeltaTime;
      
        Minutes = Mathf.FloorToInt(timer / 60);
        Seconds = Mathf.FloorToInt(timer % 60);
    }
    
}
