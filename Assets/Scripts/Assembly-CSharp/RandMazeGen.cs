using UnityEngine;

public class RandMazeGen : MonoBehaviour
{
	private static int infinite = 9999999;

	private int[,] LinkCost;

	private int NNodes;

	public string MAAAAAZWEEEEE;

	private void Start()
	{
		int[,] array = new int[9, 9];
		array[0, 1] = 3;
		array[0, 3] = 2;
		array[0, 8] = 4;
		array[1, 0] = 3;
		array[1, 7] = 4;
		array[2, 3] = 6;
		array[2, 5] = 1;
		array[2, 7] = 2;
		array[3, 0] = 2;
		array[3, 2] = 6;
		array[3, 4] = 1;
		array[4, 3] = 1;
		array[4, 8] = 8;
		array[5, 2] = 1;
		array[5, 6] = 8;
		array[6, 5] = 8;
		array[7, 1] = 4;
		array[7, 2] = 2;
		array[8, 0] = 4;
		array[8, 4] = 8;
		int[,] array2 = array;
		NNodes = array2.GetLength(1);
		LinkCost = new int[NNodes, NNodes];
		for (int i = 0; i < NNodes; i++)
		{
			for (int j = 0; j < NNodes; j++)
			{
				LinkCost[i, j] = array2[i, j];
				if (LinkCost[i, j] == 0)
				{
					LinkCost[i, j] = infinite;
				}
			}
		}
		for (int i = 0; i < NNodes; i++)
		{
			for (int j = 0; j < NNodes; j++)
			{
				if (LinkCost[i, j] < infinite)
				{
					string mAAAAAZWEEEEE = MAAAAAZWEEEEE;
					MAAAAAZWEEEEE = mAAAAAZWEEEEE + " " + LinkCost[i, j] + " ";
				}
				else
				{
					MAAAAAZWEEEEE += " * ";
				}
			}
			MAAAAAZWEEEEE += '\n';
		}
		Prim();
	}

	private void Update()
	{
	}

	public int unReached(bool[] r)
	{
		bool flag = true;
		for (int i = 0; i < r.Length; i++)
		{
			if (!r[i])
			{
				return i;
			}
		}
		return -1;
	}

	public void Prim()
	{
		bool[] array = new bool[NNodes];
		int[] array2 = new int[NNodes];
		array[0] = true;
		for (int i = 1; i < NNodes; i++)
		{
			array[i] = false;
		}
		array2[0] = 0;
		printReachSet(array);
		for (int i = 1; i < NNodes; i++)
		{
			int num;
			int num2 = (num = 0);
			for (int j = 0; j < NNodes; j++)
			{
				for (int k = 0; k < NNodes; k++)
				{
					if (array[j] && !array[k] && LinkCost[j, k] < LinkCost[num2, num])
					{
						num2 = j;
						num = k;
					}
				}
			}
			Debug.Log("Min cost edge: (" + num2 + "," + num + ")cost = " + LinkCost[num2, num]);
			array2[num] = num2;
			array[num] = true;
			printReachSet(array);
			MAAAAAZWEEEEE += '\n';
		}
		printMinCostEdges(array2);
	}

	private void printMinCostEdges(int[] a)
	{
		for (int i = 0; i < NNodes; i++)
		{
			Debug.Log(a[i] + " --> " + i);
		}
	}

	private void printReachSet(bool[] Reached)
	{
		Debug.Log("ReachSet = ");
		for (int i = 0; i < Reached.Length; i++)
		{
			if (Reached[i])
			{
				MAAAAAZWEEEEE = MAAAAAZWEEEEE + i + " ";
			}
		}
		MAAAAAZWEEEEE += '\n';
	}
}
