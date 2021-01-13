using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMG : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip[] AudioClipArr;


    float Increasevolume = 0.6f;
    float Decreasevolume = 0.6f;
    float VolumeRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Increasevolume = Increasevolume + (VolumeRate * Time.deltaTime);
            GetComponent<AudioSource>().volume = Increasevolume;
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Decreasevolume = Decreasevolume - (VolumeRate * Time.deltaTime);
            GetComponent<AudioSource>().volume = Decreasevolume;
            
        }
    }
}
