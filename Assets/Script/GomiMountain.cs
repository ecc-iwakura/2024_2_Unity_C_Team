using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GomiMountain : MonoBehaviour
{
    public FadeSceneLoader_2 fadeSceneLoader_2;
    public int mmis_num = 0;
    public AudioClip sound1;
    AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sizai")
        {
            fadeSceneLoader_2.CallCoroutine();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Gomi")
        {
            audioSource.PlayOneShot(sound1);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "bomu")
        {
            fadeSceneLoader_2.CallCoroutine();
            Destroy(collision.gameObject);

            //fadeSceneLoader_2.CallCoroutine();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mmis_num > 29)
        {
            fadeSceneLoader_2.CallCoroutine();
        }
    }
}
