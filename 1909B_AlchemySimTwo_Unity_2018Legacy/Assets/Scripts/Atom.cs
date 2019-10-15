using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AtomType { A, B, C, D, E, F, G, H };

public class Atom : ScriptableObject
{
    public AtomType atomType;
    public int electrons;
    public float electronegativity;
    public float mass;

    public AtomType getType()
    {
        return atomType;
    }

    public int GetElectrons()
    {
        return electrons;
    }

    public float GetElectronegativity()
    {
        return electronegativity;
    }

    public float GetMass()
    {
        return mass;
    }
}

public class AtomA : Atom
{
    private void Awake()
    {
        atomType = AtomType.A;
        electrons = 1;
        electronegativity = 98; //Of what?
        mass = 6.93f; //Lithium
    }
}

public class AtomB : Atom
{
    private void Awake()
    {
        atomType = AtomType.B;
        electrons = 2;
        electronegativity = 157;
        mass = 9.01f; //Beryllium
    }
}

public class AtomC : Atom
{
    private void Awake()
    {
        atomType = AtomType.C;
        electrons = 3;
        electronegativity = 204;
        mass = 10.8f; //Boron
    }
}

public class AtomD : Atom
{
    private void Awake()
    {
        atomType = AtomType.D;
        electrons = 4;
        electronegativity = 255;
        mass = 12; //Carbon
    }
}

public class AtomE : Atom
{
    private void Awake()
    {
        atomType = AtomType.E;
        electrons = 5;
        electronegativity = 304;
        mass = 14;
    }
}

public class AtomF : Atom
{
    private void Awake()
    {
        atomType = AtomType.F;
        electrons = 6;
        electronegativity = 344;
        mass = 15.99f;
    }
}

public class AtomG : Atom
{
    private void Awake()
    {
        atomType = AtomType.G;
        electrons = 7;
        electronegativity = 398;
        mass = 18.99f;
    }
}

public class AtomH : Atom
{
    private void Awake()
    {
        atomType = AtomType.H;
        electrons = 8;
        electronegativity = 0;
        mass = 20.18f;
    }
}