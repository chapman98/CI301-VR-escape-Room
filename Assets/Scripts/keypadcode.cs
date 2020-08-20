using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypadcode : MonoBehaviour
{
    public int code;
    public static int input;
    public bool correct = false;
    public GameObject door;
    public float speed = 1;
    public Vector3 end = new Vector3(0f, 0f, 0f);


    private void Update()
    {
        if (input == code)
        {
            Debug.Log("open");
            correct = true;
        }

        if (correct)
        {
        https://forum.unity.com/threads/making-an-object-move-and-then-stop-when-it-reaches-a-certain-point.440465/
            Timer.game = false;
            
                door.transform.position = Vector3.MoveTowards(door.transform.position, end, speed * Time.deltaTime);
            
        }
    }
}
