from typing import List


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        numsLen: int = len(nums)
        for i in range(0, numsLen):
            for j in range(0, numsLen):
                if i != j:
                    if nums[i] + nums[j] == target:
                        return [i, j]  # [2,3]
        return []


if __name__ == "__main__":
    solution = Solution()
    case1 = [0, 2, 3, 4, 4]
    target1 = 8  # [1, 4]
    case2 = [9, 2, 3, 4]
    target2 = 5  # [1,2]
    case3 = [3, 4, 5, 2, 6]
    target3 = 7  # [0,1]
    case4 = [3, 3]
    target4 = 6  # [0, 1]
    print(solution.twoSum(case4, target4))
