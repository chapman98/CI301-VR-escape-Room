using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terminal : MonoBehaviour
{
    public bool correct = false;
    public float speed = 1f;
    public Vector3 end = new Vector3(0f, 0f, 0f);
    public string answer = "rover";
    public GameObject box; 

    public static string input;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadSceneAsync("UI password");
    }

    // Update is called once per frame
    void Update()
    {
      if(input == answer)
        {
            correct = true;
        }

      if(correct)
        {
            box.transform.position = Vector3.MoveTowards(box.transform.position, end, speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision col)
    {
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("UI password"));
    }
}
