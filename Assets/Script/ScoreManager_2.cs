using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class ScoreManager_2 : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数
    public int misu_num = 0;
    public FadeSceneLoader fadeSceneLoader;
    public FadeSceneLoader_2 fadeSceneLoader_2;
    public GameObject burizzi9;
    public GameObject burizzi8;
    public GameObject burizzi7;
    public GameObject burizzi6;
    public GameObject burizzi5;
    public GameObject burizzi4;
    public GameObject burizzi3;
    public GameObject burizzi2;
    public GameObject burizzi1;
    public GameObject burizzi0;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sizai")
        {
            score_num += 10;
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
            Vector3 spawnPosition = new Vector3(1.61f, -1.92f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi9, spawnPosition, Quaternion.identity);


        }
        if (score_num == 20)
        {
            Vector3 spawnPosition = new Vector3(2.35f, -1.92f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi8, spawnPosition, Quaternion.identity);
        }
        if (score_num == 30)
        {
            Vector3 spawnPosition = new Vector3(3.08f, -1.93f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi7, spawnPosition, Quaternion.identity);
        }
        if (score_num == 40)
        {
            Vector3 spawnPosition = new Vector3(3.82f, -1.93f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi6, spawnPosition, Quaternion.identity);
        }
        if (score_num == 50)
        {
            Vector3 spawnPosition = new Vector3(4.546614f, -1.91f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi5, spawnPosition, Quaternion.identity);
        }
        if (score_num == 60)
        {
            Vector3 spawnPosition = new Vector3(5.25f, -1.91f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi4, spawnPosition, Quaternion.identity);
        }
        if (score_num == 70)
        {
            Vector3 spawnPosition = new Vector3(5.985f, -1.91f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi3, spawnPosition, Quaternion.identity);
        }
        if (score_num == 80)
        {
            Vector3 spawnPosition = new Vector3(6.72131f, -1.921f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi2, spawnPosition, Quaternion.identity);
        }
        if (score_num == 90)
        {
            Vector3 spawnPosition = new Vector3(7.441582f, -1.925f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi1, spawnPosition, Quaternion.identity);
        }
        if (score_num == 100)
        {
            Vector3 spawnPosition = new Vector3(8.177061f, -1.928f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(burizzi0, spawnPosition, Quaternion.identity);
        }
    }
   

    void Start()
    {

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
        if (score_num > 99)
        {
            fadeSceneLoader.CallCoroutine();
        }
        if (misu_num > 29)
        {
            fadeSceneLoader_2.CallCoroutine();

        }
    }
}
