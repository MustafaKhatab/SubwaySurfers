using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {

            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Obstacle2"))
        {

            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Obstacle3"))
        {

            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Health"))
        {

            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Ability"))
        {

            other.gameObject.SetActive(false);
        }
    }
}