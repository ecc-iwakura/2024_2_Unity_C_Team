using UnityEngine;
using UnityEngine.SceneManagement;

// enum
// enum�͗񋓌^�ƌĂ΂�A�����萔(�񋓒萔�ƌĂ΂��)��\��
// ��A�̖��O�t���l�ō\�������f�[�^�^�̂��Ƃ��w���܂�
// enum���g�����ƂŐ��l�ɈӖ����������邱�Ƃ��ł��܂�
// �����w�肵�Ȃ��ꍇ�͈�ԏォ�珇��0����n�܂鐮���̘A�ԂɂȂ�
// ����̓Q�[���̏�Ԃ�\�����߂Ɏg�p����
// �g������ enum�^�̖��O.�萔�� �ƋL�q���܂�
// �Ⴆ�Ή��� Init ���g�p����ꍇ�� GameMode.Init �ƋL�q���܂�
public enum GameMode
{
    Init,   // 0 : ��������
    Opening, // 1 : �I�[�v�j���O���o��
    GamePlaing, // 2 : �Q�[���v���C��
    GameOver,   // 3 : �Q�[���I�[�o�[���o��
    GameClear   // 4 : �Q�[���N���A���o��
}

public class GameManager : MonoBehaviour
{
    // �C���X�y�N�^�[�ɃQ�[�����[�h��\������p�̕ϐ�
    // ReadOnly�����ŕ\���̂݁A�ҏW�s�ɐݒ�
    // ReadOnly�������g�p���邽�߂ɂ�Script/Common�t�H���_���ɂ���
    // ReadOnlyAttribute.cs �� ReadOnlyDrawer.cs ���K�v
    [SerializeField,ReadOnly]
    [Space(10)]  // Space���� �� �C���X�y�N�^�[�̍��ڂɈ����Ŏw�肵�����Ԃ��󂯂邱�Ƃ��ł���
    private GameMode GameMode;

    // ���ۂɃQ�[�����[�h�𐧌䂷��p�̕ϐ�
    // static���g�p���Ă���ϐ��̓Q�[���ɑ΂���1�������݂��Ȃ�
    // �O�����玩�R�ɕύX�����Ȃ����߂�private�ɐݒ肵�Ă���
    private static GameMode State = 0;


    // �ėp�^�C�}�[
    private float Timer = 0.0f;
    // �I�[�v�j���O���o�̎���
    [Header("�I�[�v�j���O���o�̎���(�b)")]  // Header�����@���@�C���X�y�N�^�[�Ɏw�肵���������R�����g�Ƃ��ĕ\���ł���
    public float OpeningTime = 3.0f;
    // �Q�[���I�[�o�[��ʂɈڍs����܂ł̎���
    [Header("�Q�[���I�[�o�[���o�̎���(�b)")]
    public float GameOverIntervalTime = 3.0f;
    // �Q�[���N���A��ʂɈڍs����܂ł̎���
    [Header("�Q�[���N���A���o�̎���(�b)")]
    public float GameClearIntervalTime = 3.0f;

    void Start()
    {
        // �Q�[�����[�h�����������[�h�ɐݒ�
        State = GameMode.Init;
    }

    void Update()
    {
        // �S����23��ނ���f�U�C���p�^�[���ƌĂ΂��v���O�����݌v��1�ł���
        // �X�e�[�g�p�^�[�����g�p���ăQ�[�����[�h���Ƃɏ����𕪊򂳂���
        // ���ۂɂ�State�̒l��ύX���鎖�ɂ���ĕ��򂳂��Ă���
        switch (State)
        {
            // ���������[�h
            case GameMode.Init:
                // �^�C�}�[�����Z�b�g
                Timer = 0.0f;
                // �Q�[�����[�h���I�[�v�j���O�ɕύX
                State = GameMode.Opening;
                //===================================================
                // �v���C���[�ƓG�̈ړ��t���O��false�ɐݒ�
                //===================================================


           break;
            // �I�[�v�j���O��
            case GameMode.Opening:
                // �^�C�}�[���Z
                Timer += Time.deltaTime;
                // �^�C�}�[���I�[�v�j���O���o�̎��Ԃ𒴂�����
                if (Timer > OpeningTime)
                {
                    // �^�C�}�[�����Z�b�g
                    Timer = 0.0f;
                    // �Q�[�����[�h���v���C���ɕύX
                    State = GameMode.GamePlaing;
                    //===================================================
                    // �v���C���[�ƓG�̈ړ��t���O��true�ɐݒ�
                    //===================================================


                }
                break;
            // �Q�[���v���C��
            case GameMode.GamePlaing:
                // �Q�[���v���C���ɃQ�[���}�l�[�W���[�͉������Ȃ�
                break;
            // �Q�[���I�[�o�[���o��
            case GameMode.GameOver:
                // �^�C�}�[���Z
                Timer += Time.deltaTime;
                // �^�C�}�[���Q�[���I�[�o�[���o�̎��Ԃ𒴂�����
                if (Timer > GameOverIntervalTime)
                {
                    // �Q�[���I�[�o�[�V�[����ǂݍ���
                    SceneManager.LoadScene("OverScene");
                }
                break;
            // �Q�[���N���A���o��
            case GameMode.GameClear:
                // �^�C�}�[���Z
                Timer += Time.deltaTime;
                // �^�C�}�[���Q�[���N���A���o�̎��Ԃ𒴂�����
                if (Timer > GameClearIntervalTime)
                {
                    // �Q�[���N���A�V�[����ǂݍ���
                    SceneManager.LoadScene("ClearScene");
                }
                break;
            // ������State�ɕςȒl���������Ƃ��p�̏���
            // ����̏ꍇ���Ƃقڂ��肦�܂���
            default:
                // ���������[�h�Ɉڍs
                State = GameMode.Init;
                break;
        }
        // �\���p�̃Q�[�����[�h���X�V
        GameMode = State;
    }

    // �Q�[���I�[�o�[���ɌĂяo�����ƂŃQ�[�����[�h���Q�[���N���A�̏�ԂɕύX���邽�߂̊֐�
    // �����G���v���C���[�ɓ��������Ƃ��ɌĂяo��
    public static void GameOvered() 
    {
        // �Q�[�����[�h���Q�[���I�[�o�ɕύX
        State = GameMode.GameOver;
        //===================================================
        // �v���C���[�ƓG�̈ړ��t���O��false�ɐݒ�
        //===================================================


    }
    // �Q�[���N���A���ɌĂяo�����ƂŃQ�[�����[�h���Q�[���N���A�̏�ԂɕύX���邽�߂̊֐�
    // ���̊֐����v���C���[���ŃQ�[�����N���A�����Ƃ��ɌĂяo��
    public static void GameCleared()
    {
        State = GameMode.GameClear;
        //===================================================
        // �v���C���[�ƓG�̈ړ��t���O��false�ɐݒ�
        //===================================================


    }
}

