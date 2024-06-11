using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Randamu : MonoBehaviour
{
    public GameObject ki;
    public GameObject kugi;
    public GameObject nendo;
    public GameObject ha;
    public GameObject sabi;
    public GameObject ringo;
    private int gandamu; // ランダムの箱
    private int i; //繰り返しの変数

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spow"); //関数を呼び出すコード    
    }

    // Update is called once per frame
    private IEnumerator spow()
    {
        for (i = 1; i < 100; i++) 
        {
            gandamu = Random.Range(1, 7);
            if (gandamu == 1)
            {
                Instantiate(ki, transform.position, transform.rotation);
               // Destroy(gameObject, 1.0f);
            }
            else if (gandamu == 2)
            {
                Instantiate(kugi, transform.position, transform.rotation);
                
            }
            else if (gandamu == 3)
            {
                Instantiate(nendo, transform.position, transform.rotation);
            }
            else if (gandamu == 4)
            {
                Instantiate(ha, transform.position, transform.rotation);
            }
            else if (gandamu == 5)
            {
                Instantiate(sabi, transform.position, transform.rotation);
            }
            else if (gandamu == 6)
            {
                Instantiate(ringo, transform.position, transform.rotation);
            }
            yield return new WaitForSeconds(2.0f);
            
        }
    }



    void Update()
    {
        
    }
}
