using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private string Level;
    [SerializeField] private GameObject LinePrefab;
    [SerializeField] private List<Material> MaterialSlots = new List<Material>();
    [SerializeField] private List<GameObject> ObjectSlots = new List<GameObject>();

    public void Load()
    {
        string fileName = Level;
        string filePath = Application.dataPath + "/" + "Level" + "/" + fileName + ".json";

        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            LevelData data = JsonUtility.FromJson<LevelData>(jsonString);
            if (data.Level_Mats.Count == 0 && data.Level_ObjectName.Count == 0) return;

            for (int i = 0; i < data.Level_Mats.Count; i++)
            {
                // Add Line Renderers
                GameObject line = Instantiate(LinePrefab);
                line.GetComponent<LineRenderer>().positionCount = 2;
                line.GetComponent<LineRenderer>().SetPosition(0, data.Level_StartPos[i]);
                line.GetComponent<LineRenderer>().SetPosition(1, data.Level_EndPos[i]);

                // Add Edge Colliders
                List<Vector2> colliders = new List<Vector2>();
                colliders.Add(new Vector2(line.GetComponent<LineRenderer>().GetPosition(0).x, line.GetComponent<LineRenderer>().GetPosition(0).y));
                colliders.Add(new Vector2(line.GetComponent<LineRenderer>().GetPosition(1).x, line.GetComponent<LineRenderer>().GetPosition(1).y));

                line.GetComponent<EdgeCollider2D>().points = colliders.ToArray();

                // Add Tag, Material
                for (int j = 0; j < MaterialSlots.Count; j++)
                {
                    if (data.Level_Mats[i] == MaterialSlots[j].name + " (Instance)")
                    {
                        line.GetComponent<LineRenderer>().material = MaterialSlots[j];
                        line.tag = MaterialSlots[j].name;
                    }
                }
            }

            // Add Objects
            for (int i = 0; i < data.Level_ObjectName.Count; i++)
            {
                for (int j = 0; j < ObjectSlots.Count; j++)
                {
                    if (data.Level_ObjectName[i] == ObjectSlots[j].name + "(Clone)")
                    {
                        Instantiate(ObjectSlots[j].gameObject, data.Level_ObjPos[i], Quaternion.identity);
                        break;
                    }
                }
            }

        }
        else
        {
            Debug.Log("No file");
            Debug.Log(filePath);
        }
    }
}

public class LevelData
{
    public List<LineRenderer> Level_Lines = new List<LineRenderer>();
    public List<Vector2> Level_StartPos = new List<Vector2>();
    public List<Vector2> Level_EndPos = new List<Vector2>();
    public List<string> Level_Mats = new List<string>();
    public List<string> Level_ObjectName = new List<string>();
    public List<Vector2> Level_ObjPos = new List<Vector2>();
}