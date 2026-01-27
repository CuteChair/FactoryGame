using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellConnectionManager : MonoBehaviour
{
    public static CellConnectionManager Instance;

    private Dictionary<int, NewCells> cells = new Dictionary<int, NewCells>();

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        NewGridManager.OnNewCellCreated += AddNewCell;
    }

    private void OnDisable()
    {
        NewGridManager.OnNewCellCreated -= AddNewCell;
    }
    public NewCells RequestForCellInfo(int id)
    {
        if (cells.ContainsKey(id))
        {
            return cells[id];
        }
        else

            return null;
    }

    private void AddNewCell(int id, NewCells newCell)
    {
        cells.Add(id, newCell);
    }

}
