using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Questions : MonoBehaviour
{
    public TextAsset jsonAsset;
    public string jsonString;

    public void callJson () 
    {
        jsonAsset = Resources.Load<TextAsset>("Data");
        jsonString = jsonAsset.text;
        Data questionsDictionary = JsonUtility.FromJson<Data>(jsonString);
        Debug.Log(jsonString);
    }

    // Start is called before the first frame update
    void Start()
    {
        callJson();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
