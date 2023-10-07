using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Celoma {
    acelomado, pseudocelomado, celomado
}

public enum EmbryonicLeaflet{
    driblastic, triblastic, none
}

public enum MouthOrigin{
    protostome, deuterostome, none
}

public enum Symmetry{
    radial, bilateral, none
}

public enum DigestiveSystem {
    complete, incomplete, none
}

public enum Skeleton {
    endoskeleton, exoskeleton, shell, 
}

public enum Reproduction{
    sexually, asexually
}

public enum Fecundation {
    internal, external
}

public enum Habitat{
    aquatic, terrestrial, both 
}

public class Animal : MonoBehaviour {
    public int id;
    public string name;
    bool intracellularDigestion;
    bool vertebrate;
    bool haveblood;
    bool layEggs;
    bool canFly;
    bool haveFur;
    public Celoma celoma;
    public EmbryonicLeaflet embryonicLeaflet;
    public MouthOrigin mouthOrigin;
    public Symmetry symmetry;
    public DigestiveSystem digestiveSystem;
    public Skeleton skeleton;
    public Reproduction reproduction;
    public Fecundation fecundation;
    public Habitat habitat;

    [SerializeField]
    public GameObject image;
    public static List<int> openAnimals = new List<int>();

    public Animal(int id, string name) {
        this.id = id;
        this.name = name;
        this.celoma = celoma;
    }

    public void InitializeAnimal(int id, string name) {
        this.id = id;
        this.name = name;
        this.celoma = celoma;
        
        
        changeImage();
        Animal.openAnimals.Add(this.id);
    }

    public void changeImage() {
        string path = this.id.ToString();
        var sprite = Resources.Load<Sprite>(path);
        Image image = this.image.GetComponent<Image>();
        image.sprite = sprite;
    }

    public static void UpdateOpenAnimalList(int id, bool closeAnimal) {
        if (closeAnimal) {
            openAnimals.Remove(id);
        }
        else {
            openAnimals.Add(id);
        }
    }

    public static void ClearOpenAnimalList() {
        openAnimals.Clear();
    }

    public static bool IsBlond(Animal c) {
        return c.hairColor == Hair.blond;
    }

}