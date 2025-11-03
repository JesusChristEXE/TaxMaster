using UnityEngine;
using TMPro;

public class ScoreUpdateScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI Textbox;
    public int score = 0;
    ManagerScript managerScript;

    void Start()
    {
        Textbox.text = "Score: 0";
        managerScript = FindFirstObjectByType<ManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score!= managerScript.scoreTracker) { 
        Changescore();
        }
    }
    private void Changescore() {
        score = managerScript.scoreTracker;
        Textbox.text = "Score:" + score;
    }
}
