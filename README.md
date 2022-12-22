# Sorting

Assignment E12 in IGME 206

Complete the following methods to create an upside-down array and sorts the columns in descending order:

Main: Prompt the user for the base size of the array. In the example below, the base size is 5. Main calls methods to create, print, and sort the array.
CreateArray: creates a column-major array with an odd number of columns.
PrintArray: prints the current values based on the input base size, as shown in the output, below.
SortArray: sorts the array based on size of the columns in descending order and stores the sorted array in the original array.
           Do not save the original array elsewhere. You must use either an insert or selection sort approach and a ragged/jagged array.
For example, the entire third column of the unsorted array becomes the first column of the sorted array:

Unsorted:
0 0 0 0 0
  0 0 0
    0
Sorted:
0 0 0 0 0
0 0 0
0
