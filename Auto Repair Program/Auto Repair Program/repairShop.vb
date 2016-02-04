Option Strict On
Public Class repairShop
    Const SALES_TAX As Double = 0.08
    Const LABOR_RATE As Double = 50

    Property inputPartsCost As Double
    Property inputLaborHours As Double
    Property total As Double
    Property tax As Double
    Property laborCost As Double
    Property partsCost As Double
    Property subtotal As Double



    Sub New()
    End Sub

    Friend Sub calculate()
        laborCost = inputLaborHours * LABOR_RATE
        subtotal = inputPartsCost + laborCost
        tax = inputPartsCost * SALES_TAX
        partsCost = inputPartsCost + tax
        total = laborCost + partsCost
    End Sub
End Class
