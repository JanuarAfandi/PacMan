using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public GameObject inputName;
    public GameObject inputField;
    public GameObject Map1;
    public GameObject Map2;
    public GameObject Map3;

    // Start is called before the first frame update
    void Start()
    {
        inputName.SetActive(true);
        Time.timeScale = 0f;
    }
    public void enterButtonClicked()
    {
        inputName.SetActive(false);
        Time.timeScale = 1f;

        Data.Name = inputField.GetComponent<Text>().text;

        int rand = Random.Range(1,3);
        if (rand == 1)
        {
            Map1.SetActive(true);
            Map2.SetActive(false);
            Map2.SetActive(false);
        }
        if (rand == 2)
        {
            Map1.SetActive(false);
            Map2.SetActive(true);
            Map3.SetActive(false);
        }
        if (rand == 3)
        {
            Map1.SetActive(false);
            Map2.SetActive(false);
            Map3.SetActive(true);
        }
    }
}
