using UnityEditor;
using UnityEngine;

public class RowCreation : EditorWindow
{
    float disX = 0f;
    float disY = 0;
    private bool Generate = false;
    private int count = 0;

    public GameObject row;

    public Vector3 lastRow;

    private int clickedTimes;
    // Add menu item named "My Window" to the Window menu
    [MenuItem("Window/Generate Rows")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(RowCreation));
    }
    
    void OnGUI()
    {
        GUILayout.Label ("Row Creation", EditorStyles.boldLabel);
        disX = EditorGUILayout.FloatField("Distance X", disX);
        disY = EditorGUILayout.FloatField("Distance Y", disY);
        count = (int) EditorGUILayout.Slider("Count", count, 0, 100);
        this.row = (GameObject) EditorGUILayout.ObjectField("Create", this.row, typeof (GameObject), false);
        this.lastRow = EditorGUILayout.Vector3Field("Position", lastRow);
        clickedTimes = EditorGUILayout.IntSlider("Already There", clickedTimes, -1000000, 1000000);
        Generate = EditorGUILayout.LinkButton("Generate");
        if (Generate == true)
        {
            clickedTimes++;
            GameObject go  = Instantiate(row, new Vector3(lastRow.x + disX*(clickedTimes), lastRow.y + disY*(clickedTimes), 0), Quaternion.identity);
            go.name = clickedTimes.ToString();
            go.tag = "Rocks";
        }
    }
    
}