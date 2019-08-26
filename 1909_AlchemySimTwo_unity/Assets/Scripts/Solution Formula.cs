using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Solution Formula")]

public class SolutionFormula : ScriptableObject
{
    public AtomType[] moleculeOneTypes;
    public int[] moleculeOneQuantity;

    public AtomType[] moleculeTwoTypes;
    public int[] moleculeTwoQuantity;

    public AtomType[] moleculeThreeTypes;
    public int[] moleculeThreeQuantity;

    public AtomType[] moleculeFourTypes;
    public int[] moleculeFourQuantity;

    public AtomType[] moleculeFiveTypes;
    public int[] moleculeFiveQuantity;
}
