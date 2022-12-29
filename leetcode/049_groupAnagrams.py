# https://leetcode.com/problems/group-anagrams/submissions/867106554/
from typing import List
from collections import defaultdict

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        letters_to_words = defaultdict(list)

        for word in strs:
            letters_to_words[tuple(sorted(word))].append(word)
                    
        return list(letters_to_words.values())



# Test
strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
result = Solution().groupAnagrams(strs)
print(" s: ", strs, "\n result: ", result)
