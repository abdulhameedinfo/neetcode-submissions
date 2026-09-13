/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        var levels = new List<List<int>>();
        if(root == null)
        {
            return levels;
        }

        var queue = new Queue<List<TreeNode>>();
        queue.Enqueue(new List<TreeNode>(){ root });
        levels.Add(new List<int>() { root.val});

        while(queue.Count > 0)
        {
            var nodes = queue.Dequeue();
            var newNodes = new List<TreeNode>();
            var level = new List<int>();

            foreach(TreeNode node in nodes)
            {
                if(node.left != null)
                {
                    level.Add(node.left.val);
                    newNodes.Add(node.left); 
                }

                if(node.right != null)
                {
                    level.Add(node.right.val);
                    newNodes.Add(node.right);
                }
            }
            
            if(level.Count > 0)
                levels.Add(level);
            if(newNodes.Count > 0)
                queue.Enqueue(newNodes);
        }
        return levels;
    }
}
