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

public enum Blood
{
    Endotherms, // Warm-blooded
    Ectotherms, // Colds-blooded
    None
}

public enum Eggs
{
    Oviparous, Ovoviviparous, Viviparous, None
}

public enum BodyCoverage
{
    Fur, Feathers, Scales, None
}
public class Animal : MonoBehaviour
{
    public int id;
    public string name;
    public string scientificName;
    public bool vertebrate;
    public bool fly;
    public Blood blood;
    public Eggs eggs;
    public BodyCoverage bodyCoverage;
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

    public Animal(
        int id,
        string name,
        string scientificName,
        bool vertebrate,
        bool fly,
        Blood blood,
        Eggs eggs,
        BodyCoverage bodyCoverage,
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
        this.scientificName = scientificName;
        this.coelomate = coelomate;
        this.vertebrate = vertebrate;
        this.blood = blood;
        this.eggs = eggs;
        this.fly = fly;
        this.bodyCoverage = bodyCoverage;
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
        string scientificName,
        bool vertebrate,
        bool fly,
        Blood blood,
        Eggs eggs,
        BodyCoverage bodyCoverage,
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
        this.scientificName = scientificName;
        this.coelomate = coelomate;
        this.vertebrate = vertebrate;
        this.blood = blood;
        this.eggs = eggs;
        this.fly = fly;
        this.bodyCoverage = bodyCoverage;
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

    public static bool Fly(Animal c)
    {
        return c.fly;
    }

    public static bool BloodEndotherms(Animal c)
    {
        return c.blood == Blood.Endotherms;
    }
    public static bool BloodEctotherms(Animal c)
    {
        return c.blood == Blood.Ectotherms;
    }

    public static bool EggsOviparous(Animal c)
    {
        return c.eggs == Eggs.Oviparous;
    }

    public static bool EggsOvoviviparous(Animal c)
    {
        return c.eggs == Eggs.Ovoviviparous;
    }

    public static bool EggsViviparous(Animal c)
    {
        return c.eggs == Eggs.Viviparous;
    }


    public static bool BodyCoverageFur(Animal c)
    {
        return c.bodyCoverage == BodyCoverage.Fur;
    }
    public static bool BodyCoverageFeathers(Animal c)
    {
        return c.bodyCoverage == BodyCoverage.Feathers;
    }
    public static bool BodyCoverageScales(Animal c)
    {
        return c.bodyCoverage == BodyCoverage.Scales;
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