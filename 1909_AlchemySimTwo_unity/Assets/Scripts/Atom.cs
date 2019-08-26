using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AtomType { A, B, C, D, E, F, G, H };


[CreateAssetMenu(menuName = "Atom")]

public class Atom : ScriptableObject
{

    public AtomType atomType;
    public int electrons;

    /*
    public void SetAtomType(string typeString)
    {
        switch (typeString)
        {
            case "A":
                atomType = AtomType.A;
                electrons = 1;
                break;
            case "B":
                atomType = AtomType.B;
                electrons = 2;
                break;
            case "C":
                atomType = AtomType.C;
                electrons = 3;
                break;
            case "D":
                atomType = AtomType.D;
                electrons = 4;
                break;
            case "E":
                atomType = AtomType.E;
                electrons = 5;
                break;
            case "F":
                atomType = AtomType.F;
                electrons = 6;
                break;
            case "G":
                atomType = AtomType.G;
                electrons = 7;
                break;
            case "H":
                atomType = AtomType.H;
                electrons = 8;
                break;
        }
    }
    */

    public void SetAtomType(AtomType type)
    {
        atomType = type;
        SetElectrons();
    }

    public void SetElectrons()
    {
        switch (atomType)
        {
            case AtomType.A:
                electrons = 1;
                break;
            case AtomType.B:
                electrons = 2;
                break;
            case AtomType.C:
                electrons = 3;
                break;
            case AtomType.D:
                electrons = 4;
                break;
            case AtomType.E:
                electrons = 5;
                break;
            case AtomType.F:
                electrons = 6;
                break;
            case AtomType.G:
                electrons = 7;
                break;
            case AtomType.H:
                electrons = 8;
                break;
        }
    }

    public int GetElectrons()
    {
        return electrons;
    }

}

public class AtomA : Atom
{
    private void Awake()
    {
        atomType = AtomType.A;
        electrons = 1;
    }
}

public class AtomB : Atom
{
    private void Awake()
    {
        atomType = AtomType.B;
        electrons = 2;
    }
}

public class AtomC : Atom
{
    private void Awake()
    {
        atomType = AtomType.C;
        electrons = 3;
    }
}

public class AtomD : Atom
{
    private void Awake()
    {
        atomType = AtomType.D;
        electrons = 4;
    }
}

public class AtomE : Atom
{
    private void Awake()
    {
        atomType = AtomType.E;
        electrons = 5;
    }
}

public class AtomF : Atom
{
    private void Awake()
    {
        atomType = AtomType.F;
        electrons = 6;
    }
}

public class AtomG : Atom
{
    private void Awake()
    {
        atomType = AtomType.G;
        electrons = 7;
    }
}

public class AtomH : Atom
{
    private void Awake()
    {
        atomType = AtomType.H;
        electrons = 8;
    }
}