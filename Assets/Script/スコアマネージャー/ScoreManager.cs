using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数
    public int misu_num = 0;
    public FadeSceneLoader fadeSceneLoader;
    public FadeScenceLoder_1_2 FadeScenceLoder_1_2;
    public GameObject mega9;
    public GameObject mega8;
    public GameObject mega7;
    public GameObject mega6;
    public GameObject mega5;
    public GameObject mega4;
    public GameObject mega3;
    public GameObject mega2;
    public GameObject mega1;
    public GameObject mega0;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sizai")
        {
            score_num +=10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Gomi")
        {
            misu_num += 10;
            Destroy(collision.gameObject);
        }
        
        if (score_num == 10)
        {
            // 生成したい位置を指定する (例: x座標が2、y座標が3の位置)
            Vector3 spawnPosition = new Vector3(6.14f, -4.48f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega9, spawnPosition, Quaternion.identity);

           
        }
        if (score_num == 20)
        {
            Vector3 spawnPosition = new Vector3(6.14f, -3.49f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega8, spawnPosition, Quaternion.identity);
        }
        if (score_num == 30)
        {
            Vector3 spawnPosition = new Vector3(6.14f, -2.5f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega7, spawnPosition, Quaternion.identity);
        }
        if (score_num == 40)
        {
            Vector3 spawnPosition = new Vector3(6.14f, -1.51f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega6, spawnPosition, Quaternion.identity);
        }
        if (score_num == 50)
        {
            Vector3 spawnPosition = new Vector3(6.14f, -0.54f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega5, spawnPosition, Quaternion.identity);
        }
        if (score_num == 60)
        {
            Vector3 spawnPosition = new Vector3(6.14f, 0.44f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega4, spawnPosition, Quaternion.identity);
        }
        if (score_num == 70)
        {
            Vector3 spawnPosition = new Vector3(6.14f, 1.43f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega3, spawnPosition, Quaternion.identity);
        }
        if (score_num == 80)
        {
            Vector3 spawnPosition = new Vector3(6.14f, 2.4f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega2, spawnPosition, Quaternion.identity);
        }
        if (score_num == 90)
        {
            Vector3 spawnPosition = new Vector3(6.14f, 3.38f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega1, spawnPosition, Quaternion.identity);
        }
        if (score_num == 100)
        {
            Vector3 spawnPosition = new Vector3(6.14f, 4.37f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(mega0, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Points" + score_num;

        //switch (score_num)
        //{
        //    case 0:
        //        if (score_num == 10)
        //        {
        //            Instantiate(mega9, transform.position, transform.rotation);
        //        }
        //        break;

        //}

        //for (int i = 0; i < 10; i++)
        //{
        //    if (score_num == 10)
        //    {
        //        Instantiate(mega9, transform.position, transform.rotation);
        //    }
        //}
        if (score_num >99)
        {
            fadeSceneLoader.CallCoroutine();   
        }
        if(misu_num>29)
        {
            FadeScenceLoder_1_2.CallCoroutine();
          
        }   
    }
}