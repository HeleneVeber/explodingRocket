using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Questions : MonoBehaviour
{
    // variables qui permettent de déserializer le Json
    public TextAsset jsonAsset;
    public string jsonString;
    
    // variables liées au SocialHealthBar
    public SocialHealthBar socialHealthBar;

    public int socialInitialHealth = 50;
    public int socialCurrentHealth;
    
    //variables liées au EcologyHealthBar

    public EcologyHealthBar ecologyhealthbar;
    public int ecologyInitialHealth = 50;
    public int ecologyCurrentHealth;
    
    //variables liées au RocketHealthBar
    
    public RocketHealthBar rockethealthbar;
    public int rocketInitialHealth = 0;
    public int rocketCurrentHealth;

    // déclaration buttons
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;

    public Answer answerA;
    public Answer answerB;
    public Answer answerC;
    // variables permettant l'affichage des textes
    public TextQuestion questionToPlay;


    void Start()
    {
        // Ces lignes permettent la désérialiser le Json en allant récupérer le fichier dans resources, en le transformant en une string et en le parsant avec FromJson et basé dans le modèle de l'objet Data. 
        jsonAsset = Resources.Load<TextAsset>("Data");
        jsonString = jsonAsset.text;
        Data data = JsonUtility.FromJson<Data>(jsonString);
        Debug.Log(jsonString);

        //détermine le nombre de points vie
        socialCurrentHealth = socialInitialHealth; // On devrait l'attribuer à maxHealth
        socialHealthBar.SetInitialSocialHealth(socialInitialHealth);
        ecologyCurrentHealth = ecologyInitialHealth; // On devrait l'attribuer à maxHealth
        ecologyhealthbar.SetInitialEcologyHealth(ecologyInitialHealth);
        rocketCurrentHealth = rocketInitialHealth; // On devrait l'attribuer à maxHealth
        rockethealthbar.SetInitialRocketHealth(rocketInitialHealth);
        callJson(data);
    }

    void Update()
    {

    }

    void callJson(Data datargument) {
        buttonA.onClick.AddListener(()=>TakeDamage(datargument.questionsList[0].responses[0].socialDamage, datargument.questionsList[0].responses[0].ecologyDamage, datargument.questionsList[0].responses[0].rocketPoint));
        buttonB.onClick.AddListener(()=>TakeDamage(datargument.questionsList[0].responses[0].socialDamage, datargument.questionsList[0].responses[0].ecologyDamage, datargument.questionsList[0].responses[1].rocketPoint));
        buttonC.onClick.AddListener(()=>TakeDamage(datargument.questionsList[0].responses[0].socialDamage, datargument.questionsList[0].responses[0].ecologyDamage, datargument.questionsList[0].responses[2].rocketPoint));
        
        //affichage de la question et des réponses
        questionToPlay.questionText.text = datargument.questionsList[0].questionText;
        answerA.answerText.text = datargument.questionsList[0].responses[0].answerText;
        answerB.answerText.text = datargument.questionsList[0].responses[1].answerText;
        answerC.answerText.text = datargument.questionsList[0].responses[2].answerText;
}

     void TakeDamage(int socialDamage, int ecologyDamage, int rocketDamage)
    {
        socialCurrentHealth += socialDamage;
        socialHealthBar.SetSocialHealth(socialCurrentHealth);
        ecologyCurrentHealth += ecologyDamage;
        ecologyhealthbar.SetEcologyHealth(ecologyCurrentHealth); 
        rocketCurrentHealth += rocketDamage;
        rockethealthbar.SetRocketHealth(rocketCurrentHealth); 

        // EcologyHealthBar.SetEcologyHealth(currentHealth);
        // if(currentHealth <= 0)
        // {
        //    button.image.color = Color.blue;
        // }
    }
}
