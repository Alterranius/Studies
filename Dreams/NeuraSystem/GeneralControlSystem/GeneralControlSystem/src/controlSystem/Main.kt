package controlSystem

/**
 *@author Alterranius
 */
object Test {
    const val FIVE = 5
    const val THREE = 3
    const val FIZZ = "Fizz"
    const val BUZZ = "Buzz"
}

fun main() {
    val toTest = 1 until 10

    val controller: Controller<Int, String> = ControllerBuilder<Int, String>()
        .addRule(AndRule(
            DivCondition(Test.FIVE),
            SupplyTActivity(Test.FIZZ)
        ))
        .addRule(AndRule(
            DivCondition(Test.THREE),
            SupplyTActivity(Test.BUZZ)
        ))
        .setExecutor(Executor.printer)
        .toController()
    toTest.forEach(controller::controlAll)
}