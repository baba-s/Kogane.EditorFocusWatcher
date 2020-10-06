# UniEditorFocusWatcher

エディタがフォーカスされた、フォーカスが外れた時に呼び出されるコールバック

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class Example
{
    static Example()
    {
        EditorFocusWatcher.OnFocused   += () => Debug.Log( "フォーカスされた" );
        EditorFocusWatcher.OnUnfocused += () => Debug.Log( "フォーカスが外れた" );
    }
}
```
