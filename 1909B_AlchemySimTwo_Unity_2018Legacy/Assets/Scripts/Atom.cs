using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AtomType { A, B, C, D, E, F, G, H };

public class Atom : ScriptableObject
{
    public AtomType atomType;
    public int electrons;
    public double electronegativity;

    public AtomType getType()
    {
        return atomType;
    }

    public int GetElectrons()
    {
        return electrons;
    }

    public double GetElectronegativity()
    {
        return electronegativity;
    }
}

public class AtomA : Atom
{
    private void Awake()
    {
        atomType = AtomType.A;
        electrons = 1;
        electronegativity = 0.98;
    }
}

public class AtomB : Atom
{
    private void Awake()
    {
        atomType = AtomType.B;
        electrons = 2;
        electronegativity = 1.57;
    }
}

public class AtomC : Atom
{
    private void Awake()
    {
        atomType = AtomType.C;
        electrons = 3;
        electronegativity = 2.04;
    }
}

public class AtomD : Atom
{
    private void Awake()
    {
        atomType = AtomType.D;
        electrons = 4;
        electronegativity = 2.55;
    }
}

public class AtomE : Atom
{
    private void Awake()
    {
        atomType = AtomType.E;
        electrons = 5;
        electronegativity = 3.04;
    }
}

public class AtomF : Atom
{
    private void Awake()
    {
        atomType = AtomType.F;
        electrons = 6;
        electronegativity = 3.44;
    }
}

public class AtomG : Atom
{
    private void Awake()
    {
        atomType = AtomType.G;
        electrons = 7;
        electronegativity = 3.98;
    }
}

public class AtomH : Atom
{
    private void Awake()
    {
        atomType = AtomType.H;
        electrons = 8;
        electronegativity = 0;
    }
}