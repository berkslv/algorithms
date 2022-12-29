class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

    def __str__(self):
        list = []
        printed = self
        while printed is not None:
            list.append(printed.val)
            printed = printed.next
        return str(list)

    @classmethod
    def from_list(self, list):
        cur = dummy = ListNode(0)
        for e in list:
            cur.next = ListNode(e)
            cur = cur.next
        return dummy.next


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

    @classmethod
    def from_list(self, items):
        if not items:
            return None
        it = iter(items)
        root = TreeNode(next(it))
        q = [root]
        for node in q:
            val = next(it, None)
            if val is not None:
                node.left = TreeNode(val)
                q.append(node.left)
            val = next(it, None)
            if val is not None:
                node.right = TreeNode(val)
                q.append(node.right)
        return root

    def print(self):
        root = self

        def height(root):
            return 1 + max(height(root.left), height(root.right)) if root else -1
        nlevels = height(root)
        width = pow(2, nlevels+1)

        q = [(root, 0, width, 'c')]
        levels = []

        while (q):
            node, level, x, align = q.pop(0)
            if node:
                if len(levels) <= level:
                    levels.append([])

                levels[level].append([node, level, x, align])
                seg = width//(pow(2, level+1))
                q.append((node.left, level+1, x-seg, 'l'))
                q.append((node.right, level+1, x+seg, 'r'))

        for i, l in enumerate(levels):
            pre = 0
            preline = 0
            linestr = ''
            pstr = ''
            seg = width//(pow(2, i+1))
            for n in l:
                valstr = str(n[0].val)
                if n[3] == 'r':
                    linestr += ' '*(n[2]-preline-1-seg-seg //
                                    2) + '¯'*(seg + seg//2)+'\\'
                    preline = n[2]
                if n[3] == 'l':
                    linestr += ' '*(n[2]-preline-1)+'/' + '¯'*(seg+seg//2)
                    preline = n[2] + seg + seg//2
                # correct the potition acording to the number size
                pstr += ' '*(n[2]-pre-len(valstr))+valstr
                pre = n[2]
            print(linestr)
            print(pstr)
