using UnityEngine;
// ReadOnly属性で指定した変数をインスペクターで表示するだけで
// 編集不可能にするために必要なプログラムの一つ
// ReadOnlyDrawerで使用するが中身は空で構わない
public class ReadOnlyAttribute : PropertyAttribute
{
}