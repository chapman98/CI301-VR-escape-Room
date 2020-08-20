using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{
    public GameObject correct;
    public GameObject wrong1;
    public GameObject wrong2;
    public float dist_c;
    public float dist_w1;
    public float dist_w2;

    private Rigidbody rb_c;
    private Rigidbody rb_w1;
    private Rigidbody rb_w2;

    public int id;

    public Vector3 snapping;
    // Start is called before the first frame update
    void Start()
    {
        rb_c = correct.GetComponent<Rigidbody>();
        rb_w1 = wrong1.GetComponent<Rigidbody>();
        rb_w2 = wrong2.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dist_c = Vector3.Distance(this.transform.position, correct.transform.position);
        dist_w1 = Vector3.Distance(this.transform.position, wrong1.transform.position);
        dist_w2 = Vector3.Distance(this.transform.position, wrong2.transform.position);

        if(dist_c < 1.0f)
        {
            correct.transform.position = snapping;
            correct.transform.rotation = Quaternion.Euler(0, 0, 0);
            rb_c.useGravity = false;
            check_colours.check[id] = true;

        }
        if(dist_c > 1.0f)
        {
            rb_c.useGravity = true;
            check_colours.check[id] = false;
        }

        if (dist_w1 < 1.0f)
        {
            wrong1.transform.position = snapping;
            wrong1.transform.rotation = Quaternion.Euler(0, 0, 0);
            rb_w1.useGravity = false;

        }
        if (dist_w1 > 1.0f)
        {
            rb_w1.useGravity = true;
        }

        if (dist_w2 < 1.0f)
        {
            wrong2.transform.position = snapping;
            wrong2.transform.rotation = Quaternion.Euler(0, 0, 0);
            rb_w2.useGravity = false;

        }
        if (dist_w2 > 1.0f)
        {
            rb_w2.useGravity = true;
        }
    }
}
