using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SolutionConstructor : MonoBehaviour
{
    public SolutionFormula solutionFormula;
    public AtomDictionary atomDictionary;
    public ReactionEngine reactionEngine;
    Solution solution;

    private void Start()
    {
        solution = this.GetComponent<Solution>();
        BuildSolution(solutionFormula.moleculeOneTypes, solutionFormula.moleculeOneQuantity);
    }

    private void BuildSolution(AtomType[] atomsToAdd, int[] quantityToAdd)
    {
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

        newMolecule.SetValues();

        solution.AddMolecule(newMolecule);

    }

}
