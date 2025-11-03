using TMPro;
using UnityEngine;

public class timerscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float currentTimer = 0;
    public TextMeshProUGUI Textbox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Textbox.text = "Timer:"+ currentTimer.ToString();
        currentTimer = Mathf.Floor(Time.time);

        //minutes= Mathf.Floor(Time.time/60)
        //hours=Mathf.Floor(Time.time/3600)
        //seconds= Mathf.Floor(Time.time)-60*minutes-3600*hours
        //Textbox.text= "Timer:"+hours+":"+minutes+":"+seconds
    }
}
