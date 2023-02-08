using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Questions : MonoBehaviour
{
    public TextAsset jsonAsset;
    public string jsonString;

    //public Question question1;

    public void callJson() 
    {
        jsonAsset = Resources.Load<TextAsset>("Data");
        jsonString = jsonAsset.text;
        Data data = JsonUtility.FromJson<Data>(jsonString);
        Debug.Log(jsonString);
        Debug.Log(data.questionDictionary["505000"]);

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
