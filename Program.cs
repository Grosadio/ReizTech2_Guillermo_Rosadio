using System;
using System.Collections.Generic;

//Question2_Guillermo_Rosadio
public class Branch
{
    public int val;
    public IList<Branch> branches;

    public Branch() { }

    public Branch(int val)
    {
        this.val = val;
    }

    public Branch(int val, IList<Branch> branches)
    {
        this.val = val;
        this.branches = branches;
    }
}

public class Solution
{
    public int MaxDepth(Branch root)
    {
        return (root != null ? MaxDepth(root, 1) : 0);
    }

    private int MaxDepth(Branch root, int depth)
    {
        if (root == null)
        {
            return depth;
        }

        int maxDepth = depth;
        if (root.branches != null)
        {
            foreach (Branch child in root.branches)
            {
                maxDepth = Math.Max(maxDepth, MaxDepth(child, (depth + 1)));
            }
        }

        return maxDepth;
    }

    public static void Main(string[] args)
    {
        Branch n1 = new Branch(1);
        Branch n2 = new Branch(2);
        Branch n3 = new Branch(3);
        Branch n4 = new Branch(4);
        Branch n5 = new Branch(5);
        Branch n6 = new Branch(6);
        Branch n7 = new Branch(7);
        Branch n8 = new Branch(8);
        Branch n9 = new Branch(9);
        Branch n10 = new Branch(10);
        Branch n11 = new Branch(11);

        List<Branch> branches1 = new List<Branch>();
        branches1.Add(n2);
        branches1.Add(n3);

        List<Branch> branches2 = new List<Branch>();
        branches2.Add(n4);

        List<Branch> branches2_1 = new List<Branch>();
        branches2_1.Add(n5);
        branches2_1.Add(n6);
        branches2_1.Add(n7);

        List<Branch> branches3 = new List<Branch>();
        branches3.Add(n8);

        List<Branch> branches3_1 = new List<Branch>();
        branches3_1.Add(n9);
        branches3_1.Add(n10);

        List<Branch> branches4 = new List<Branch>();
        branches4.Add(n11);


        n1.branches = branches1;
        n2.branches = branches2;
        n3.branches = branches2_1;
        n5.branches = branches3;
        n6.branches = branches3_1;
        n9.branches = branches4;

        Solution s = new Solution();
        int maxDepth = s.MaxDepth(n1);
        Console.WriteLine("Max depth of the tree is: " + maxDepth);
    }
}