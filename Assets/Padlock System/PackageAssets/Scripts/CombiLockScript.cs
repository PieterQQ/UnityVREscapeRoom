using UnityEngine;
using System.Collections;

public class CombiLockScript : MonoBehaviour
{
    [Header("Combination Controller Reference")]
    [SerializeField] private CombinationController CombinationController;

    [Header("Combination Settings")]
    [SerializeField] private int combiNumber;
    [SerializeField] private int combiLimit;

    [Header("Combination Row")]
    [SerializeField] private bool row1;
    [SerializeField] private bool row2;
    [SerializeField] private bool row3;
    [SerializeField] private bool row4;

    void Awake()
    {
        CombinationController = GetComponentInParent<CombinationController>();
    }

   public  void OnMouseDown()
    {
        transform.Rotate(0, 0, transform.rotation.z + 40);
        CombinationController.SpinSound();
        Rotate();
    }

    void Rotate()
    {
        if (combiNumber <= combiLimit - 1)
        {
            combiNumber = combiNumber + 1;
        }

        else
        {
            combiNumber = 1;
        }

        if (row1)
        {
            CombinationController.combinationRow1 = combiNumber;
        }

        else if (row2)
        {
            CombinationController.combinationRow2 = combiNumber;
        }

        else if (row3)
        {
            CombinationController.combinationRow3 = combiNumber;
        }

        else if (row4)
        {
            CombinationController.combinationRow4 = combiNumber;
        }
    }
}


