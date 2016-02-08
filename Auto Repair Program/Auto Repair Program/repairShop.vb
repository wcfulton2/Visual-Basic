''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Program Name: Auto Repair Program
'Description: Calculate job total and display relevent information for
'             a hypothetical auto repair shop
'Programmed by: Bill Fulton
'Class: CIS 310 Online
'Date: 02 February 2016 - Winter 2016
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On

Public Class repairShop
    Const SALES_TAX As Double = 0.08 'sales tax rate
    Const LABOR_RATE As Double = 50 'labor rate

    Property inputPartsCost As Double 'user input parts cost
    Property inputLaborHours As Double 'user input labor hours
    Property total As Double 'total cost of services
    Property tax As Double 'tax on parts
    Property laborCost As Double 'cost of labor
    Property partsCost As Double 'cost of parts after tax
    Property subtotal As Double 'subtotal of parts and labor before tax



    Sub New() 'constructor
    End Sub

    Friend Sub calculate() 'calculate all output values - laborCost, subtotal, tax, partsCost, and total
        laborCost = inputLaborHours * LABOR_RATE
        subtotal = inputPartsCost + laborCost
        tax = inputPartsCost * SALES_TAX
        partsCost = inputPartsCost + tax
        total = laborCost + partsCost
    End Sub
End Class
