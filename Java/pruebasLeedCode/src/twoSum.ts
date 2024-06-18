function twoSum(nums: number[], target: number): number[] {
  let twoNumbers: number[] = [];

  for (let j = 0; j < nums.length; j++) {
    for (let i = j + 1; i < nums.length; i++) {
      if (nums[j] + nums[i] == target) {
        twoNumbers.push(j, i);
        return twoNumbers;
      }
    }
  }
  return twoNumbers;
}
console.log(twoSum([2, 7, 11, 15], 9));
console.log(twoSum([3, 2, 4], 6));
console.log(twoSum([3, 3], 6));
