using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomDictionary : MonoBehaviour
{
    Dictionary<AtomType, Atom> typeToClassDictionary = new Dictionary<AtomType, Atom>();
    //Dictionary<AtomType, string> typeToStringDictionary = new Dictionary<AtomType, string>();
    Dictionary<Atom, string> classToStringDictionary = new Dictionary<Atom, string>();

    private void Awake()
    {
        typeToClassDictionary.Add(AtomType.A, ScriptableObject.CreateInstance<AtomA>());
        typeToClassDictionary.Add(AtomType.B, ScriptableObject.CreateInstance<AtomB>());
        typeToClassDictionary.Add(AtomType.C, ScriptableObject.CreateInstance<AtomC>());
        typeToClassDictionary.Add(AtomType.D, ScriptableObject.CreateInstance<AtomD>());
        typeToClassDictionary.Add(AtomType.E, ScriptableObject.CreateInstance<AtomE>());
        typeToClassDictionary.Add(AtomType.F, ScriptableObject.CreateInstance<AtomF>());
        typeToClassDictionary.Add(AtomType.G, ScriptableObject.CreateInstance<AtomG>());
        typeToClassDictionary.Add(AtomType.H, ScriptableObject.CreateInstance<AtomH>());
        /*
        typeToStringDictionary.Add(AtomType.A, "A");
        typeToStringDictionary.Add(AtomType.B, "B");
        typeToStringDictionary.Add(AtomType.C, "C");
        typeToStringDictionary.Add(AtomType.D, "D");
        typeToStringDictionary.Add(AtomType.E, "E");
        typeToStringDictionary.Add(AtomType.F, "F");
        typeToStringDictionary.Add(AtomType.G, "G");
        typeToStringDictionary.Add(AtomType.H, "H");
        */
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomA>(), "A");
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomB>(), "B");
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomC>(), "C");
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomD>(), "D");
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomE>(), "E");
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomF>(), "F");
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomG>(), "G");
        classToStringDictionary.Add(ScriptableObject.CreateInstance<AtomH>(), "H");

        foreach(KeyValuePair<Atom, string> entry in classToStringDictionary)
        {
            print(entry);
        }
    }

    public Atom TypeToClass(AtomType type)
    {
        return typeToClassDictionary[type];
    }

    public string ClassToString(Atom atom)
    {
        return classToStringDictionary[atom];
    }

    /*
    public string TypeToString(AtomType type)
    {
        return typeToStringDictionary[type];
    }
    */
}
