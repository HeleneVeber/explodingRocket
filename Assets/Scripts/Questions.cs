using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Questions : MonoBehaviour
{
    public Question questionToPlay;
    public TextAsset jsonAsset;
    public string jsonString;

    // Start is called before the first frame update
    void Start()
    {
        jsonAsset = Resources.Load<TextAsset>("Data");
        jsonString = jsonAsset.text;
        Data data = JsonUtility.FromJson<Data>(jsonString);
        Debug.Log(jsonString);
        Debug.Log(data.questionsList[0].questionText);
        questionToPlay.questionText.text = data.questionsList[0].questionText;
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
}
