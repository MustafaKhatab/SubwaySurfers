using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Music : MonoBehaviour
{
    public static bool mute;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ToggleMute()
    {
        if (mute)
        {
            AudioListener.pause = true;
            mute = !mute;
        }
        else
        {

            AudioListener.pause = false;
            mute = !mute;
        }
    }

}
