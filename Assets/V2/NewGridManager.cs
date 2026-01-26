using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGridManager : MonoBehaviour
{
    public static event Action<Vector2, int, int, int> OnNewCellAdded;

    public int Height;
    public int Width;

    public int Rows;
    public int Columns;

    public Vector2 currentLoc = Vector2.zero;
    public List<Vector2> PosInGrid = new List<Vector2>();

    private void Start()
    {
        int rowCount = 0;

        for(int i = 0; i <= Columns; i++)
        {
            if(i == Columns)
            {
                currentLoc.y -= Height;
                currentLoc.x = 0f;

                rowCount++;
                i = 0;

                if (rowCount == Rows)
                    return;
            }

            PosInGrid.Add(currentLoc);
            currentLoc.x += Width;
        }
    }

}
