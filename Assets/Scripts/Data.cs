using System.Collections.Generic;

[System.Serializable]
public class Data {
    public Dictionary <string, QuestionData> questionDictionary; 
}

public class QuestionData {
    public string questionText;
    public List <AnswerData> responses;
}

public class AnswerData {
    public string answerText;
    public int socialDamage;
    public int ecologyDamage;
}