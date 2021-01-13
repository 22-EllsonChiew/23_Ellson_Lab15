using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{

    public GameObject JumpText;

    private int jumpCount;
    private Rigidbody rb;

    public bool Isground;

    public Vector3 jump;
    public float Jumpforce = 2.0f;

    private AudioSource audioSource;

    public AudioClip[] AudioClipArr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        audioSource = GetComponent<AudioSource>();
    }


    void OnCollisionStay()
    {
        Isground = true;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Isground)
        {
            jumpCount++;

            JumpText.GetComponent<Text>().text = "Jump: " + jumpCount;

            rb.AddForce(jump * Jumpforce, ForceMode.Impulse);
            Isground = false;

            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);

            //audioSource.Play();


        }
    }
}
