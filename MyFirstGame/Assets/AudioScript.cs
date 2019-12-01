using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioSource MusicSource;
    public int Nyala=0;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip=MusicClip;
    
    }

    // Update is called once per frame
    void Update()
    {
        if(moveball.posisis>=4&&Nyala==0){
            MusicSource.Play();
            Nyala=1;
            }
        else{ 
            
            }
    }
}
