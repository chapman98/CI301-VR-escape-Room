using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class keypad : MonoBehaviour
{
    public AudioSource keysound; //https://opengameart.org/content/beep-tone-sound-sfx
    private float timer = -1f;
    private bool coutdown = false;
    public int keypad_number;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coutdown)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                coutdown = false;
            }
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (coutdown == false)
        {
            Debug.Log(keypad_number);
            keypadcode.input = int.Parse(keypadcode.input.ToString() + keypad_number.ToString());
            keysound.Play();
            timer = 0.5f;
            coutdown = true;

        }


    }

}
