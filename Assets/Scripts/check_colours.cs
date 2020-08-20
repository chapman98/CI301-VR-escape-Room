using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_colours : MonoBehaviour
{
    [SerializeField] public static bool[] check = { false, false, false };
    public bool correct = false;
    public GameObject box;
    public float speed = 1f;
    public Vector3 end = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(check[0] && check[1] && check[2])
        {
            correct = true;
        }

        if (correct)
        {
            box.transform.position = Vector3.MoveTowards(box.transform.position, end, speed * Time.deltaTime);
        }
    }
}
