using UnityEngine;
using UnityEditor;
// ReadOnly属性で指定した変数をインスペクターで表示するだけで
// 編集不可能にするために必要なプログラムの一つ
// クラスの属性でReadOnlyAttributeを使用する
[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer
{
    // ReadOnly属性で指定した変数を実際に表示のみで編集不可能にしている関数
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginDisabledGroup(true);
        EditorGUI.PropertyField(position, property, label, true);
        EditorGUI.EndDisabledGroup();
    }
}