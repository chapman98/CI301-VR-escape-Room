using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timer;
    public float time = 0;
    public static bool game = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //from: https://answers.unity.com/questions/1174761/20-minute-countdown-timer.html
        if (game)
        {
            time -= Time.deltaTime;
        }
        string minutes = Mathf.Floor(time / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        timer.text = minutes + ":" + seconds;
    }
}
