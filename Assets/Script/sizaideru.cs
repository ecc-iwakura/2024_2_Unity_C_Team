using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizaideru : MonoBehaviour
{
    public GameObject ki;
    public GameObject kugi;
    public GameObject nendo;
    public GameObject dan;
    public GameObject zasi;
    public GameObject sin;
    public GameObject bomu;
    //public GameObject gataibomu;
    private int gandamu; // ラ;ンダムの箱
    private int i; //繰り返しの変数
    public float generate_Time = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spow"); //関数を呼び出すコード    
    }

    // Update is called once per frame
    private IEnumerator spow()
    {
        for (i = 1; i < 10; i++)
        {
            //GameObject newobject = null;

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
                Instantiate(dan, transform.position, transform.rotation);
            }
            else if (gandamu == 5)
            {
                Instantiate(zasi, transform.position, transform.rotation);
            }
            else if (gandamu == 6)
            {
                Instantiate(sin, transform.position, transform.rotation);
            }


            //if (newobject == null)
            //{


            //}

            yield return new WaitForSeconds(generate_Time);


        }
        for (i = 1; i < 15; i++)
        {
            //GameObject newobject = null;

            gandamu = Random.Range(1, 9);
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
                Instantiate(dan, transform.position, transform.rotation);
            }
            else if (gandamu == 5)
            {
                Instantiate(zasi, transform.position, transform.rotation);
            }
            else if (gandamu == 6)
            {
                Instantiate(sin, transform.position, transform.rotation);
            }
            else if (gandamu == 7)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }
            else if (gandamu == 8)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }

            //if (newobject == null)
            //{


            //}

            yield return new WaitForSeconds(generate_Time - 0.5f);

        }
        for (i = 1; i < 10; i++)
        {
            //GameObject newobject = null;

            gandamu = Random.Range(1, 10);
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
                Instantiate(dan, transform.position, transform.rotation);
            }
            else if (gandamu == 5)
            {
                Instantiate(zasi, transform.position, transform.rotation);
            }
            else if (gandamu == 6)
            {
                Instantiate(sin, transform.position, transform.rotation);
            }
            else if (gandamu == 7)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }
            else if (gandamu == 8)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }

            else if (gandamu == 9)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }
            //if (newobject == null)
            //{


            //}

            yield return new WaitForSeconds(generate_Time - 0.7f);

        }

        for (i = 1; i < 50; i++)
        {
            //GameObject newobject = null;

            gandamu = Random.Range(1, 10);
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
                Instantiate(dan, transform.position, transform.rotation);
            }
            else if (gandamu == 5)
            {
                Instantiate(zasi, transform.position, transform.rotation);
            }
            else if (gandamu == 6)
            {
                Instantiate(sin, transform.position, transform.rotation);
            }
            else if (gandamu == 7)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }
            else if (gandamu == 8)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }

            else if (gandamu == 9)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }
            //if (newobject == null)
            //{


            //}

            yield return new WaitForSeconds(generate_Time - 0.9f);

        }


        for (i = 1; i < 300; i++)
        {
            //GameObject newobject = null;

            gandamu = Random.Range(1, 11);
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
                Instantiate(dan, transform.position, transform.rotation);
            }
            else if (gandamu == 5)
            {
                Instantiate(zasi, transform.position, transform.rotation);
            }
            else if (gandamu == 6)
            {
                Instantiate(sin, transform.position, transform.rotation);
            }
            else if (gandamu == 7)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }
            else if (gandamu == 8)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }


            else if (gandamu == 9)
            {
                Instantiate(bomu, transform.position, transform.rotation);
            }
            //if (newobject == null)
            //{


            //}

            yield return new WaitForSeconds(generate_Time - 1.0f);

        }
    }
}
