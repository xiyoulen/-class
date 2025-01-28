using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Script_Exp0210))]
public class Script_Exp0210Editor : Editor
{
    public override void OnInspectorGUI()
    {
        Script_Exp0210 script = (Script_Exp0210)target;

        // 创建一个可以输入的字段，用于修改lineLength
        script.lineLength = EditorGUILayout.FloatField("Line Length", script.lineLength);
        // 创建一个可以输入的字段，用于修改cubeSize
        script.cubeSize = EditorGUILayout.Vector3Field("Cube Size", script.cubeSize);
    }
}
