package creational.singleton

/**
 *@author Alterranius
 */
object Processor {
    const val CORES = 4;
    init {
        println("In work")
    }
}

fun main() {
    println(Processor.CORES)
}