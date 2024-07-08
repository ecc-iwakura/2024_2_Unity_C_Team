using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlescrit : MonoBehaviour
{
    private int state = 0;
    public float senitime = 2.5f;
    private float timer = 0;
    public string LoadScenename;
    private AudioSource Audio; 
    
    // Start is called before the first frame update
    void Start()
    {
        state = 0;
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case 0:
                timer = 0;
                state = 1;
                break;
            case 1:

                break;
            case 2:
                timer += Time.deltaTime;
                if (timer > senitime)
                {
                    state = 3;
                }
                break;
            case 3:
                SceneManager.LoadScene(LoadScenename);
                break;
        }
    }
    public void OnClickEvent()
    {
        state = 2;
        Audio.Play();
    }
}
