using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PathfindingMatt : MonoBehaviour
{
    public enum State{Opened,Closed,Untested }
    public struct Point2D
    {
        public Point2D(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }
        public int y { get; set; }
    }
    struct GridInfo
    {
        public bool mWalkable { get; set; }
        public int mTerrainPenalty { get; set; }
        public Point2D mLocation { get; set; }
        public float mG { get; private set; }
        public float mH { get; private set; }
        public float mF { get { return this.mG + this.mH; } }
        public GridInfo mParentNode {
            get { return this.mParentNode; }
            set
            {
                // When setting the parent, also calculate the traversal cost from the start node to here (the 'G' value)
                this.mParentNode = value;
                this.mG = this.mParentNode.mG + GetTraversalCost(this.mLocation, this.mParentNode.mLocation);
            }
        }

        private float GetTraversalCost(Point2D mLocation1, Point2D mLocation2)
        {
            throw new NotImplementedException();
        }

        public GridInfo(bool aWalkable, int aTerrainPenalty, Point2D aLocation) : this()
        {
            this.mWalkable = aWalkable;
            this.mTerrainPenalty = aTerrainPenalty;
            this.mLocation = aLocation;

        }
    }
    public GameObject GridOutline;
    public GameObject GridOutlineBad;
    public int GridSizeX = 10;
    public int GridSizeY = 10;


    // Use this for initialization
    void Start()
    {
        GenerateTiles(GenerateGrid(GridSizeX, GridSizeY));
    }

    // Update is called once per frame
    void Update()
    {

    }
    List<GridInfo> GenerateGrid(int a_X, int a_Y)
    {
        List<GridInfo> Grid = new List<GridInfo>();
        for (int y = 0; y <= a_Y; y++)
        {
            for (int x = 0; x <= a_X; x++)
            {
                Point2D GridLocation = new Point2D(x,y);
                if (y == 0 || y == a_Y || x == 0 || x == a_X || y == 20 && x <= (GridSizeX/2) )
                {

                    Grid.Add(new GridInfo(false, 100, GridLocation));
                }
                else
                {
                    Grid.Add(new GridInfo(true, 0, GridLocation));
                }
            }
        }
        return Grid;
    }
    void GenerateTiles(List<GridInfo> a_Grid)
    {
        //for (int y = 0; y <= a_Y; y++)
        //{
        //    for (int x = 0; x <= a_X; x++)
        //    {
        //        if (a_Grid)
        //    }
        //}
        foreach (GridInfo info in a_Grid)
        {
            if (info.mWalkable == true)
            {
                Instantiate(GridOutline, new Vector3(info.mLocation.x * 6, info.mLocation.y * 6, 0), Quaternion.identity);
            }
            else {
                Instantiate(GridOutlineBad, new Vector3(info.mLocation.x * 6, info.mLocation.y * 6, 0), Quaternion.identity);
            }
        }
    }
}
