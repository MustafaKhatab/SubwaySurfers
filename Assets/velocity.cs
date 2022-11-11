using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(3, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (generate.delete)
        {
            if (this.CompareTag("Obstacle") || this.CompareTag("Obstacle2") || this.CompareTag("Obstacle3"))
            {
                this.gameObject.SetActive(false);
            }
        }
        if (generate.deleteall)
        {
            this.gameObject.SetActive(false);
        }
    }
}
