using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnsweredQuestions : MonoBehaviour {
    public GameObject LateralText;
    public List<GameObject> answeres;

    public void AddAnsware(Question question, bool answer) {
        int yPosition = 320 - answeres.Count * 52;
        var g = Instantiate(LateralText, this.gameObject.transform.position + new Vector3(0, yPosition, 0), Quaternion.identity, this.gameObject.transform);

        string answerString = answer ? " YES" : " NO";
        var textComponent = g.GetComponent<TextMeshProUGUI>();
        textComponent.text = question.question + answerString;
        Color red, green;
        ColorUtility.TryParseHtmlString("#FF3B3E", out red);
        ColorUtility.TryParseHtmlString("#21BC3C", out green);
        textComponent.color = answer ? green : red;

        this.answeres.Add(g);

    }
}
