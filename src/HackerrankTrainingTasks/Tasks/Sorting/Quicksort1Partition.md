﻿-------------------------------------------------------------
Quicksort1Partition
-------------------------------------------------------------

The previous challenges covered Insertion Sort, which is a simple and intuitive sorting algorithm with an average case performance of O(n2)O(n2). In these next few challenges, we're covering a divide-and-conquer algorithm called Quicksort (also known as Partition Sort).

Step 1: Divide 
Choose some pivot element, pp, and partition your unsorted array, arar, into three smaller arrays: leftleft, rightright, and equalequal, where each element in left<pleft<p, each element in right>pright>p, and each element in equal=pequal=p.

Challenge 
Given arar and p=ar[0]p=ar[0], partition arar into leftleft, rightright, and equalequal using the Divide instructions above. Then print each element in leftleft followed by each element in equalequal, followed by each element in rightright on a single line. Your output should be space-separated.

Note: There is no need to sort the elements in-place; you can create two lists and stitch them together at the end.

Input Format

The first line contains nn (the size of arar). 
The second line contains nn space-separated integers describing arar (the unsorted array). The first integer (corresponding to ar[0]ar[0]) is your pivot element, pp.

Constraints

1≤n≤10001≤n≤1000
−1000≤x≤1000,x∈ar−1000≤x≤1000,x∈ar
All elements will be unique.
Multiple answer can exists for the given test case. Print any one of them.
Output Format

On a single line, print the partitioned numbers (i.e.: the elements in leftleft, then the elements in equalequal, and then the elements in rightright). Each integer should be separated by a single space.

Sample Input

5
4 5 3 7 2
Sample Output

3 2 4 5 7
Explanation

ar=[4,5,3,7,2]ar=[4,5,3,7,2] 
Pivot: p=ar[0]=4p=ar[0]=4. 
left={}left={}; equal={4}equal={4}; right={}right={}
ar[0]=4≥par[0]=4≥p, so it's added to rightright. 
left={}left={}; equal={4}equal={4}; right={4}right={4}
ar[1]=5≥par[1]=5≥p, so it's added to rightright. 
left={}left={}; equal={4}equal={4}; right={4,5}right={4,5}
ar[2]=3<par[2]=3<p, so it's added to leftleft. 
left={3}left={3}; equal={4}equal={4}; right={4,5}right={4,5}
ar[2]=7≥par[2]=7≥p, so it's added to rightright. 
left={3}left={3}; equal={4}equal={4}; right={4,5,7}right={4,5,7}
ar[2]=2<par[2]=2<p, so it's added to leftleft. 
left={3,2}left={3,2}; equal={4}equal={4}; right={4,5,7}right={4,5,7}
We then print the elements of leftleft, followed by equalequal, followed by rightright, we get: 3 2 4 5 7.

This example is only one correct answer based on the implementation shown, but it is not the only correct answer (e.g.: another valid solution would be 2 3 4 5 7).