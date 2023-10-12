using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public enum Coelomate
{
    Acoelomate, Pseudocoelomate, Coelomate
}

public enum EmbryonicLeaflet
{
    Driblastic, Triblastic, None
}

public enum MouthOrigin
{
    Protostome, Deuterostome, None
}

public enum Symmetry
{
    Radial, Bilateral, None
}

public enum DigestiveSystem
{
    Complete, Incomplete, None
}

public enum Skeleton
{
    Endoskeleton, Exoskeleton, Shell, None
}

public enum Reproduction
{
    Sexually, Asexually
}

public enum Fecundation
{
    Internal, External
}

public class Animal : MonoBehaviour
{
    public int id;
    public string name;
    public string scientificName;
    bool vertebrate;
    bool blood;
    bool layEggs;
    bool fly;
    bool fur;
    public Coelomate coelomate;
    public EmbryonicLeaflet embryonicLeaflet;
    public MouthOrigin mouthOrigin;
    public Symmetry symmetry;
    public DigestiveSystem digestiveSystem;
    public Skeleton skeleton;
    public Reproduction reproduction;
    public Fecundation fecundation;

    [SerializeField]
    public GameObject image;
    public static List<int> openAnimals = new List<int>();

    public Animal(int id, string name,
        bool vertebrate,
        bool blood,
        bool layEggs,
        bool fly,
        bool fur,
        Coelomate coelomate,
        EmbryonicLeaflet embryonicLeaflet,
        MouthOrigin mouthOrigin,
        Symmetry symmetry,
        DigestiveSystem digestiveSystem,
        Skeleton skeleton,
        Reproduction reproduction,
        Fecundation fecundation
    )
    {
        this.id = id;
        this.name = name;
        this.coelomate = coelomate;
        this.vertebrate = vertebrate;
        this.blood = blood;
        this.layEggs = layEggs;
        this.fly = fly;
        this.fur = fur;
        this.coelomate = coelomate;
        this.embryonicLeaflet = embryonicLeaflet;
        this.mouthOrigin = mouthOrigin;
        this.symmetry = symmetry;
        this.digestiveSystem = digestiveSystem;
        this.skeleton = skeleton;
        this.reproduction = reproduction;
        this.fecundation = fecundation;
    }

    public void InitializeAnimal(
        int id,
        string name,
        bool vertebrate,
        bool blood,
        bool layEggs,
        bool fly,
        bool fur,
        Coelomate coelomate,
        EmbryonicLeaflet embryonicLeaflet,
        MouthOrigin mouthOrigin,
        Symmetry symmetry,
        DigestiveSystem digestiveSystem,
        Skeleton skeleton,
        Reproduction reproduction,
        Fecundation fecundation
    )
    {
        this.id = id;
        this.name = name;
        this.coelomate = coelomate;
        this.vertebrate = vertebrate;
        this.blood = blood;
        this.layEggs = layEggs;
        this.fly = fly;
        this.fur = fur;
        this.coelomate = coelomate;
        this.embryonicLeaflet = embryonicLeaflet;
        this.mouthOrigin = mouthOrigin;
        this.symmetry = symmetry;
        this.digestiveSystem = digestiveSystem;
        this.skeleton = skeleton;
        this.reproduction = reproduction;
        this.fecundation = fecundation;

        changeImage();
        Animal.openAnimals.Add(this.id);
    }

    public void changeImage()
    {
        string path = this.id.ToString();
        var sprite = Resources.Load<Sprite>(path);
        Image image = this.image.GetComponent<Image>();
        image.sprite = sprite;
    }

    public static void UpdateOpenAnimalList(
        int id,
        bool closeAnimal)
    {
        if (closeAnimal)
        {
            openAnimals.Remove(id);
        }
        else
        {
            openAnimals.Add(id);
        }
    }

    public static void ClearOpenAnimalList()
    {
        openAnimals.Clear();
    }

    public static bool Vertebrate(Animal c)
    {
        return c.vertebrate;
    }

    public static bool Blood(Animal c)
    {
        return c.blood;
    }

    public static bool LayEggs(Animal c)
    {
        return c.layEggs;
    }

    public static bool Fly(Animal c)
    {
        return c.fly;
    }

    public static bool Fur(Animal c)
    {
        return c.fur;
    }

    public static bool CoelomateAcoelomate(Animal c)
    {
        return c.coelomate == Coelomate.Acoelomate;
    }
    public static bool CoelomatePseudocoelomate(Animal c)
    {
        return c.coelomate == Coelomate.Pseudocoelomate;
    }
    public static bool CoelomateCoelomate(Animal c)
    {
        return c.coelomate == Coelomate.Coelomate;
    }

    public static bool EmbryonicLeafletDriblastic(Animal c)
    {
        return c.embryonicLeaflet == EmbryonicLeaflet.Driblastic;
    }
    public static bool EmbryonicLeafletTriblastic(Animal c)
    {
        return c.embryonicLeaflet == EmbryonicLeaflet.Triblastic;
    }
    public static bool EmbryonicLeafletNone(Animal c)
    {
        return c.embryonicLeaflet == EmbryonicLeaflet.None;
    }

    public static bool MouthOriginProtostome(Animal c)
    {
        return c.mouthOrigin == MouthOrigin.Protostome;
    }
    public static bool MouthOriginDeuterostome(Animal c)
    {
        return c.mouthOrigin == MouthOrigin.Deuterostome;
    }
    public static bool MouthOriginNone(Animal c)
    {
        return c.mouthOrigin == MouthOrigin.None;
    }

    public static bool SymmetryRadial(Animal c)
    {
        return c.symmetry == Symmetry.Radial;
    }
    public static bool SymmetryBilateral(Animal c)
    {
        return c.symmetry == Symmetry.Bilateral;
    }
    public static bool SymmetryNone(Animal c)
    {
        return c.symmetry == Symmetry.None;
    }

    public static bool DigestiveSystemIncomplete(Animal c)
    {
        return c.digestiveSystem == DigestiveSystem.Incomplete;
    }

    public static bool DigestiveSystemComplete(Animal c)
    {
        return c.digestiveSystem == DigestiveSystem.Complete;
    }

    public static bool DigestiveSystemNone(Animal c)
    {
        return c.digestiveSystem == DigestiveSystem.None;
    }

    public static bool SkeletonExoskeleton(Animal c)
    {
        return c.skeleton == Skeleton.Exoskeleton;
    }
    public static bool SkeletonEndoskeleton(Animal c)
    {
        return c.skeleton == Skeleton.Endoskeleton;
    }
    public static bool SkeletonShell(Animal c)
    {
        return c.skeleton == Skeleton.Shell;
    }
    public static bool SkeletonNone(Animal c)
    {
        return c.skeleton == Skeleton.None;
    }

    public static bool ReproductionSexually(Animal c)
    {
        return c.reproduction == Reproduction.Sexually;
    }
    public static bool ReproductionAsexually(Animal c)
    {
        return c.reproduction == Reproduction.Asexually;
    }

    public static bool FecundationInternal(Animal c)
    {
        return c.fecundation == Fecundation.Internal;
    }
    public static bool FecundationExternal(Animal c)
    {
        return c.fecundation == Fecundation.External;
    }

}