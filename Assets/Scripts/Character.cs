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

    public static bool IsWoman(Character c) {
        return c.woman;
    }

    public static bool HasHat(Character c) {
        return c.hat;
    }

    public static bool HasGlasses(Character c) {
        return c.glasses;
    }

    public static bool HasBeard(Character c) {
        return c.beard;
    }

    public static bool HasMustache(Character c) {
        return c.mustache;
    }

    public static bool IsBald(Character c) {
        return c.bald;
    }

    public static bool HasBlueEyes(Character c) {
        return c.blueEyes;
    }

    public static bool HasBigNose(Character c) {
        return c.bigNose;
    }

    public static bool HasPinkCheeks(Character c) {
        return c.pinkCheeks;
    }

    public static bool IsBlond(Character c) {
        return c.hairColor == Hair.blond;
    }

    public static bool IsGinger(Character c) {
        return c.hairColor == Hair.ginger;
    }

    public static bool IsBrunette(Character c) {
        return c.hairColor == Hair.brunette;
    }

    public static bool HasBlackHair(Character c) {
        return c.hairColor == Hair.black;
    }

    public static bool HasWhiteHair(Character c) {
        return c.hairColor == Hair.white;
    }

}
