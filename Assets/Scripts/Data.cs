using System.Collections.Generic;

[System.Serializable]
public class Data {
    public List <QuestionData> questionsList; 
}

[System.Serializable]
public class QuestionData {
    public string questionText;
    public List <AnswerData> responses;
}

[System.Serializable]
public class AnswerData {
    public string answerText;
    public int socialDamage;
    public int ecologyDamage;
}