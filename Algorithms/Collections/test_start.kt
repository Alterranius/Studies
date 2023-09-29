import Search.BinarySearch
import Search.InterpolateSearch
import Search.JumpSearch
import Search.KMPSearch
import Search.LinearSearch
import Sort.BubbleSort
import Sort.InsertionsSort
import Sort.QuickSort
import Sort.SelectionSort

/**
 *@author Alterranius
 */
fun main() {
    val testArr = intArrayOf(1, 3, 5, 6, 7, 8, 20, 24, 54, 55, 245)
    println(LinearSearch<Int>().search(testArr.toTypedArray(), 3))

    println(BinarySearch<Int>().search(testArr.toTypedArray(), 55))

    println(JumpSearch<Int>().search(testArr.toTypedArray(), 1))

    println(InterpolateSearch().search(testArr.toTypedArray(), 54))

    println(KMPSearch.compilePattern("AABAAC").joinToString(", "))

    println(KMPSearch.searchPattern("SSSSSFFAABACCAABAABVSAABFSDFDSSSSSAABACCAABAABVSAAB", "AABACCAABAABVSAAB"))

    val testRandomArr = intArrayOf(3, 1, 5, 4, 6, 4, 2, 14, 34)
    SelectionSort.sort(testRandomArr, 0, testRandomArr.size - 1)
    println(testRandomArr.joinToString(" "))
}