using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SolutionConstructor : MonoBehaviour
{
    public SolutionFormula solutionFormula;
    Solution solution;
    public AtomDictionary atomDictionary;

    private void Start()
    {
        solution = this.GetComponent<Solution>();
        BuildSolution(solutionFormula.moleculeOneTypes, solutionFormula.moleculeOneQuantity);
    }

    private void BuildSolution(AtomType[] atomsToAdd, int[] quantityToAdd)
    {
        print("SOLUTION CONSTRUCTOR: has started building");

        
        if (atomsToAdd.Length == 0)
        {
            print("atomsToAdd.Length == 0");
            return;
        }
        


        Molecule newMolecule = ScriptableObject.CreateInstance<Molecule>();

        
        for (int i = 0; i < atomsToAdd.Length; i++)
        {
            for (int x = 0; x < quantityToAdd[i]; x++)
            {
                Atom atom = atomDictionary.TypeToClass(atomsToAdd[i]);
                newMolecule.AddAtom(atom);
            }
        }

        newMolecule.SetName();

        solution.AddMolecule(newMolecule);
        print("SOLUTION CONSTRUCTOR: called solution.AddMolecule(newMolecule)");

    }

}
