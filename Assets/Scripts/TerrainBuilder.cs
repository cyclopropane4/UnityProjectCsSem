using System;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class TerrainBuilder : MonoBehaviour
{
    private int width = 15;
    private int height = 15;
    Vector3[] Vertices;
    int[] Triangles;

    float scale = 10f;

   void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
       

        Vertices = new Vector3[(width+1)*(height+1)];
        Triangles = new int[width*height*6];

        int vert = 0;
        int tris = 0;

        for(int z = 0; z < width; z++)
        {
            for(int x = 0; x < height; x++)
            {
                Vertices[vert] = new Vector3(x * scale, z * scale, noise.snoise(new float2(x, z) * scale));
                vert++;
            }
        }

        for(int z = 0; z < width; z++)
        {
            for(int x = 0; x < height; x++)
            {
                Triangles[tris +0] = vert +0;
                Triangles[tris +1] = vert + width + 1;
                Triangles[tris +2] = vert + 1;
                Triangles[tris +3] = vert + 1;
                Triangles[tris +4] = vert + width + 1;
                Triangles[tris +5] = vert + width + 2;
            
                vert++;
                tris+=6;
            
            }
        }

        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = Vertices;
        mesh.triangles = Triangles;
    }


} 

