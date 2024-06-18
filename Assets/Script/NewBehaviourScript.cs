using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Image fadePanel;             // �t�F�[�h�p��UI�p�l���iImage�j
    public float fadeDuration = 1.0f;   // �t�F�[�h�̊����ɂ����鎞��
    public float waitDuration = 1.0f;   // �t�F�[�h�C���ƃt�F�[�h�A�E�g�̊Ԃ̑ҋ@����

    private void Start()
    {
        StartCoroutine(FadeLoop());
    }

    private IEnumerator FadeLoop()
    {
        while (true) // �������[�v�Ńt�F�[�h�C���ƃt�F�[�h�A�E�g���J��Ԃ�
        {
            yield return StartCoroutine(FadeIn());
            yield return new WaitForSeconds(waitDuration);
            yield return StartCoroutine(FadeOut());
            yield return new WaitForSeconds(waitDuration);
        }
    }

    public IEnumerator FadeIn()
    {
        float elapsedTime = 0.0f;                 // �o�ߎ��Ԃ�������
        Color startColor = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1.0f); // �t�F�[�h�p�l���̊J�n�F��ݒ�
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 0.0f); // �t�F�[�h�p�l���̍ŏI�F��ݒ�

        // �t�F�[�h�C���A�j���[�V���������s
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        // �o�ߎ��Ԃ𑝂₷
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);  // �t�F�[�h�̐i�s�x���v�Z
            fadePanel.color = Color.Lerp(startColor, endColor, t); // �p�l���̐F��ύX���ăt�F�[�h�C��
            yield return null;                                     // 1�t���[���ҋ@
        }

        fadePanel.color = endColor;  // �t�F�[�h������������ŏI�F�ɐݒ�
    }
    public IEnumerator FadeOut()
    {
        float elapsedTime = 0.0f;                 // �o�ߎ��Ԃ�������
        Color startColor = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 0.0f); // �t�F�[�h�p�l���̊J�n�F��ݒ�
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f); // �t�F�[�h�p�l���̍ŏI�F��ݒ�

        // �t�F�[�h�A�E�g�A�j���[�V���������s
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        // �o�ߎ��Ԃ𑝂₷
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);  // �t�F�[�h�̐i�s�x���v�Z
            fadePanel.color = Color.Lerp(startColor, endColor, t); // �p�l���̐F��ύX���ăt�F�[�h�A�E�g
            yield return null;                                     // 1�t���[���ҋ@
        }

        fadePanel.color = endColor;  // �t�F�[�h������������ŏI�F�ɐݒ�
    }

}