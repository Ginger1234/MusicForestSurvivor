using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Band : MonoBehaviour
{
    AudioSource thisAudio;
    public player Player;
    bool flagAudioMeetup=true;
    //public AudioSource instrument2;
    //public AudioSource instrument3;


    // Start is called before the first frame update
    void Start()
    {
        thisAudio = GetComponent<AudioSource>();
        
    }
    public void Join()
    {
        thisAudio.Stop();
        bool alreadyAdded=false;
        for (int i=0; i<Player.instruments.Count; i++)
        {
            Player.instruments[i].Stop();
            if(Player.instruments[i]==thisAudio)
            {
                alreadyAdded = true;
            }

        }
        
        //Debug.Log(Player.instruments.Count);
        if (!alreadyAdded)
            Player.instruments.Add(thisAudio);

        for (int i=0; i<Player.instruments.Count; i++)
        {
            Player.instruments[i].Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((flagAudioMeetup) && (Mathf.Abs(Player.transform.position.z - gameObject.transform.position.z)<10))
        {
            flagAudioMeetup=false;
            for (int i=0; i<Player.instruments.Count; i++)
            {
                Player.instruments[i].Stop();
            }
            Debug.Log("too close");
        }
        else if ((!flagAudioMeetup) && (Mathf.Abs(Player.transform.position.z - gameObject.transform.position.z)>10)) 
        {
            for (int i=0; i<Player.instruments.Count; i++)
            {
                Player.instruments[i].Play();
            }
            Debug.Log("far again");
            flagAudioMeetup=true;

        }
        
    }
}
