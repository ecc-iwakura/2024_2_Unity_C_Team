using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager_3 : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数
    public int misu_num = 0;
    public FadeSceneLoader_2 fadeSceneLoader_2;
    public FadeSceneLoder_GameClear fadeSceneLoder_GameClear;
    public GameObject huzi1;
    public GameObject huzi2;
    public GameObject huzi3;
    public GameObject huzi4;
    public GameObject huzi5;
    public GameObject huzi6;
    public GameObject huzi7;
    public GameObject huzi8;
    public GameObject huzi9;
    public GameObject huzi10;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sizai")
        {
            audioSource.PlayOneShot(sound1);
            score_num += 2;

            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Gomi")
        {
            fadeSceneLoader_2.CallCoroutine();
            Destroy(collision.gameObject);

            //fadeSceneLoader_2.CallCoroutine();
        }


        if (collision.gameObject.tag == "bomu")
        {
            fadeSceneLoader_2.CallCoroutine();
            Destroy(collision.gameObject);

            //fadeSceneLoader_2.CallCoroutine();
        }

        if (score_num == 10)
        {
            // 生成したい位置を指定する (例: x座標が2、y座標が3の位置)
            Vector3 spawnPosition = new Vector3(2.85f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi1, spawnPosition, Quaternion.identity);


        }
        if (score_num == 20)
        {
            Vector3 spawnPosition = new Vector3(3.517f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi2, spawnPosition, Quaternion.identity);
        }
        if (score_num == 30)
        {
            Vector3 spawnPosition = new Vector3(4.196f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi3, spawnPosition, Quaternion.identity);
        }
        if (score_num == 40)
        {
            Vector3 spawnPosition = new Vector3(4.865f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi4, spawnPosition, Quaternion.identity);
        }
        if (score_num == 50)
        {
            Vector3 spawnPosition = new Vector3(5.525f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi5, spawnPosition, Quaternion.identity);
        }
        if (score_num == 60)
        {
            Vector3 spawnPosition = new Vector3(6.21f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi6, spawnPosition, Quaternion.identity);
        }
        if (score_num == 70)
        {
            Vector3 spawnPosition = new Vector3(6.88f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi7, spawnPosition, Quaternion.identity);
        }
        if (score_num == 80)
        {
            Vector3 spawnPosition = new Vector3(7.56f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi8, spawnPosition, Quaternion.identity);
        }
        if (score_num == 90)
        {
            Vector3 spawnPosition = new Vector3(8.24f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi9, spawnPosition, Quaternion.identity);
        }
        if (score_num == 100)
        {
            Vector3 spawnPosition = new Vector3(8.911f, -3.68f, 0.0f);

            // GameObjectを生成する
            GameObject spawnedObject = Instantiate(huzi10, spawnPosition, Quaternion.identity);

        }
    }
        // Update is called once per frame
        void Update()
        {
            // オブジェクトからTextコンポーネントを取得
            Text score_text = score_object.GetComponent<Text>();
            // テキストの表示を入れ替える
            score_text.text = "完成度" + score_num;


            if (score_num > 99)
            {
                fadeSceneLoder_GameClear.CallCoroutine();
            }
            if (misu_num > 29)
            {
                fadeSceneLoader_2.CallCoroutine();

            }
        }
    
}
