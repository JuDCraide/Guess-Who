using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public enum Hair {
    blond,
    ginger,
    brunette,
    black,
    white,
}

public class Character : MonoBehaviour {
    public int id;
    public string name;
    public bool woman;
    public bool glasses;
    public bool hat;
    public bool beard;
    public bool mustache;
    public bool bald;
    public bool blueEyes;
    public bool bigNose;
    public bool pinkCheeks;
    public Hair hairColor;
    [SerializeField]
    public GameObject image;
    public static List<int> openCharacters = new List<int>();

    public Character(int id, string name, bool woman, bool glasses, bool hat, bool beard, bool mustache, bool bald, bool blueEyes, bool bigNose, bool pinkCheeks, Hair hairColor) {
        this.id = id;
        this.name = name;
        this.woman = woman;
        this.glasses = glasses;
        this.hat = hat;
        this.beard = beard;
        this.mustache = mustache;
        this.bald = bald;
        this.blueEyes = blueEyes;
        this.bigNose = bigNose;
        this.pinkCheeks = pinkCheeks;
        this.hairColor = hairColor;
    }

    public void InitializeCharacter(int id, string name, bool woman, bool glasses, bool hat, bool beard, bool mustache, bool bald, bool blueEyes, bool bigNose, bool pinkCheeks, Hair hairColor) {
        this.id = id;
        this.name = name;
        this.woman = woman;
        this.glasses = glasses;
        this.hat = hat;
        this.beard = beard;
        this.mustache = mustache;
        this.bald = bald;
        this.blueEyes = blueEyes;
        this.bigNose = bigNose;
        this.pinkCheeks = pinkCheeks;
        this.hairColor = hairColor;
        changeImage();
        Character.openCharacters.Add(this.id);
    }

    public void changeImage() {
        string path = this.id.ToString();
        //Debug.Log(path);
        var sprinte = Resources.Load<Sprite>(path);
        Image image = this.image.GetComponent<Image>();
        image.sprite = sprinte;
    }

    public static void UpdateOpenCharacterList(int id, bool closeCharacter) {
        if (closeCharacter) {
            openCharacters.Remove(id);
        }
        else {
            openCharacters.Add(id);
        }
    }

    public bool IsWoman() {
        return this.woman;
    }

    public bool HasHat() {
        return this.hat;
    }

    public bool HasGlasses() {
        return this.glasses;
    }

    public bool HasBeard() {
        return this.beard;
    }

    public bool HasMustache() {
        return this.mustache;
    }

    public bool IsBald() {
        return this.bald;
    }

    public bool HasBlueEyes() {
        return this.blueEyes;
    }

    public bool HasBigNose() {
        return this.bigNose;
    }

    public bool HasPinkCheeks() {
        return this.pinkCheeks;
    }

    public bool IsBlond() {
        return this.hairColor == Hair.blond;
    }

    public bool IsGinger() {
        return this.hairColor == Hair.ginger;
    }

    public bool IsBrunette() {
        return this.hairColor == Hair.brunette;
    }

    public bool HasBlackHair() {
        return this.hairColor == Hair.black;
    }

    public bool HasWhiteHair() {
        return this.hairColor == Hair.white;
    }

}
