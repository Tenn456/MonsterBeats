using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeNote : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().multiplier = 1;
                GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                //dead = true;
            }
        }

        if (Input.GetKeyDown(keyToPress2))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().multiplier = 1;
                GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                //dead = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
    }

    void OnEnable()
    {
        dead = false;
    }

    void OnDisable()
    {
        dead = true;
    }
}