using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Image fadePanel;             // フェード用のUIパネル（Image）
    public float fadeDuration = 1.0f;   // フェードの完了にかかる時間
    public float waitDuration = 1.0f;   // フェードインとフェードアウトの間の待機時間

    private void Start()
    {
        StartCoroutine(FadeLoop());
    }

    private IEnumerator FadeLoop()
    {
        while (true) // 無限ループでフェードインとフェードアウトを繰り返す
        {
            yield return StartCoroutine(FadeIn());
            yield return new WaitForSeconds(waitDuration);
            yield return StartCoroutine(FadeOut());
            yield return new WaitForSeconds(waitDuration);
        }
    }

    public IEnumerator FadeIn()
    {
        float elapsedTime = 0.0f;                 // 経過時間を初期化
        Color startColor = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1.0f); // フェードパネルの開始色を設定
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 0.0f); // フェードパネルの最終色を設定

        // フェードインアニメーションを実行
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        // 経過時間を増やす
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);  // フェードの進行度を計算
            fadePanel.color = Color.Lerp(startColor, endColor, t); // パネルの色を変更してフェードイン
            yield return null;                                     // 1フレーム待機
        }

        fadePanel.color = endColor;  // フェードが完了したら最終色に設定
    }
    public IEnumerator FadeOut()
    {
        float elapsedTime = 0.0f;                 // 経過時間を初期化
        Color startColor = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 0.0f); // フェードパネルの開始色を設定
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f); // フェードパネルの最終色を設定

        // フェードアウトアニメーションを実行
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        // 経過時間を増やす
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);  // フェードの進行度を計算
            fadePanel.color = Color.Lerp(startColor, endColor, t); // パネルの色を変更してフェードアウト
            yield return null;                                     // 1フレーム待機
        }

        fadePanel.color = endColor;  // フェードが完了したら最終色に設定
    }

}