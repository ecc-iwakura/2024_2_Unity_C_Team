using UnityEngine;
using UnityEditor;
// ReadOnly�����Ŏw�肵���ϐ����C���X�y�N�^�[�ŕ\�����邾����
// �ҏW�s�\�ɂ��邽�߂ɕK�v�ȃv���O�����̈��
// �N���X�̑�����ReadOnlyAttribute���g�p����
[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer
{
    // ReadOnly�����Ŏw�肵���ϐ������ۂɕ\���݂̂ŕҏW�s�\�ɂ��Ă���֐�
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginDisabledGroup(true);
        EditorGUI.PropertyField(position, property, label, true);
        EditorGUI.EndDisabledGroup();
    }
}