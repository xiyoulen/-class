using UnityEditor;
using UnityEngine;

public class CoordinateSystemMenu : MonoBehaviour
{
    [MenuItem("Tools/Visibility")]
    private static void ToggleCoordinateSystem()
    {
        GameObject[] coordinateSystems=Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (var obj in coordinateSystems)
        {
            if (obj.name=="Quad")
            {
                obj.SetActive(!obj.activeSelf);
                break;
            }
        }
    }
}
