using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;



    // Start is called before the first frame update
    void Start()
    {
        theMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        

        /*if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }*/
    }
}
