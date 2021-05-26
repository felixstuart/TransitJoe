using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class TwinFinder : EditorWindow
{
    private GameObject it;
    private string tag;
    public GameObject[] all;
    // Add menu item named "My Window" to the Window menu
    [MenuItem("Utilities/Twin")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(TwinFinder));
    }

    public void OnGUI()
    {
        EditorGUILayout.TextArea("This will find the twins for the Isometric Gen Script");
        tag = EditorGUILayout.TextField("Tag", tag);
        all = GameObject.FindGameObjectsWithTag(tag);
        //this.it = (GameObject) EditorGUILayout.ObjectField("Parent", it, typeof (GameObject), true);
        bool Find = EditorGUILayout.LinkButton("Find");
        if (Find)
        {
            Finder();
        }
    }

    public void Finder()
    {
        foreach (UnityEngine.GameObject child in all)
        {
            GameObject go = GameObject.Find((int.Parse(child.name)-1).ToString()); //Finds the previous twin.
            IsometricGen isogen = child.GetComponent<IsometricGen>();
            isogen.twin = go;
            Debug.Log(child.name);
        }
    }
}
