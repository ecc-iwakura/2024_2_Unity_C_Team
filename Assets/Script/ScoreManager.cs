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
    public FadeSceneLoader_2 fadeSceneLoader_2;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sizai")
        {
            score_num+=10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Gomi")
        {
            misu_num += 10;
            Destroy(collision.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Points" + score_num;
        
        if (score_num >99)
        {
            fadeSceneLoader.CallCoroutine();
            
        }
        if(misu_num>29)
        {
            fadeSceneLoader_2.CallCoroutine();
          
        }
        
    }
}