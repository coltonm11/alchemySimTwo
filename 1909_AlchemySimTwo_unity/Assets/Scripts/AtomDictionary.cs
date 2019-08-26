using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomDictionary : MonoBehaviour
{
    public Dictionary<AtomType, Atom> typeToClassDictionary = new Dictionary<AtomType, Atom>();
    Dictionary<Atom, string> classToStringDictionary = new Dictionary<Atom, string>();

    private void Awake()
    {
        typeToClassDictionary.Add(AtomType.A, new AtomA());
        typeToClassDictionary.Add(AtomType.B, new AtomB());
        typeToClassDictionary.Add(AtomType.C, new AtomC());
        typeToClassDictionary.Add(AtomType.D, new AtomD());
        typeToClassDictionary.Add(AtomType.E, new AtomE());
        typeToClassDictionary.Add(AtomType.F, new AtomF());
        typeToClassDictionary.Add(AtomType.G, new AtomG());
        typeToClassDictionary.Add(AtomType.H, new AtomH());

        classToStringDictionary.Add(new AtomA(), "A");
        classToStringDictionary.Add(new AtomB(), "B");
        classToStringDictionary.Add(new AtomC(), "C");
        classToStringDictionary.Add(new AtomD(), "D");
        classToStringDictionary.Add(new AtomE(), "E");
        classToStringDictionary.Add(new AtomF(), "F");
        classToStringDictionary.Add(new AtomG(), "G");
        classToStringDictionary.Add(new AtomH(), "H");
    }

    public Atom TypeToClass(AtomType type)
    {
        return typeToClassDictionary[type];
    }

    public string ClassToString(Atom atom)
    {
        return classToStringDictionary[atom];
    }

}
